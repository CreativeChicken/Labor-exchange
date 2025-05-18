using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;

namespace Labor_exchange.Models
{
    public class JobExchange
    {
        public static List<Worksheet> worksheets { get; set; } = new();

        // Метод для пошуку вакансій або анкет безробітних
        public static List<Worksheet> Find(Worksheet worksheetToFind)
        {
            List<Worksheet> finded = new List<Worksheet>();

            foreach (var unit in worksheets)
            {
                if (unit is JobVacancy jobVacancy && worksheetToFind is JobVacancy targetVacancy)
                {
                    if (jobVacancy.Company.Contains(targetVacancy.Company, StringComparison.OrdinalIgnoreCase) &&
                        jobVacancy.Position.Contains(targetVacancy.Position, StringComparison.OrdinalIgnoreCase) &&
                        jobVacancy.Salary.Contains(targetVacancy.Salary, StringComparison.OrdinalIgnoreCase) &&
                        jobVacancy.Housing.Contains(targetVacancy.Housing, StringComparison.OrdinalIgnoreCase))
                    {
                        finded.Add(unit);
                    }
                }
                else if (unit is UnemployedProfile profile && worksheetToFind is UnemployedProfile targetProfile)
                {
                    if (profile.Proffession.Contains(targetProfile.Proffession, StringComparison.OrdinalIgnoreCase) &&
                        profile.Education.Contains(targetProfile.Education, StringComparison.OrdinalIgnoreCase) &&
                        profile.LastJobPlace.Contains(targetProfile.LastJobPlace, StringComparison.OrdinalIgnoreCase) &&
                        profile.Housing.Contains(targetProfile.LastJobPosition, StringComparison.OrdinalIgnoreCase))
                    {
                        finded.Add(unit);
                    }
                }
            }

            return finded;
        }

        // Метод для генерації тестових даних
        public void CreateTestData(int count)
        {
            int i = 1;
            for (; i <= count; i++)
            {
                worksheets.Add(new JobVacancy
                {
                    Id = i,
                    Company = $"Company {i}",
                    Position = $"Position {i}",
                    Conditions = $"Conditions {i}",
                    Salary = $"Salary {i}",
                    Housing = $"Housing {i}",
                    Requirements = $"Requirements {i}"
                });
                worksheets.Add(new UnemployedProfile
                {
                    Id = i,
                    Name = $"Name {i}",
                    Age = 18 + i,
                    Proffession = $"Profession {i}",
                    Education = $"Education {i}",
                    LastJobPlace = $"LastJobPlace {i}",
                    LastJobPosition = $"LastJobPosition {i}",
                    DismissalReason = $"DismissalReason {i}",
                    MaritalStatus = $"MaritalStatus {i}",
                    Housing = $"Housing {i}",
                    Contacts = $"Contacts {i}",
                    JobExpectations = $"JobExpectations {i}"
                });
            }
        }

        // Метод для збереження даних
        public void SaveData(string path)
        {
            using (StreamWriter writer = new(path))
            {
                foreach (Worksheet unit in worksheets)
                {
                    if (unit is UnemployedProfile unemployedProfile)
                    {
                        writer.WriteLine($"Анкета робітника|{unemployedProfile}");
                    }
                    else if (unit is JobVacancy jobVacancy)
                    {
                        writer.WriteLine($"Вакансія роботодавця|{jobVacancy}");
                    }
                }
            }
        }

        // Метод для завантаження даних
        public void LoadData(string path)
        {
            using (StreamReader reader = new(path))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.StartsWith("Анкета робітника|"))
                        worksheets.Add(UnemployedProfile.FromString(line.Substring("Анкета робітника|".Length)));
                    else if (line.StartsWith("Вакансія роботодавця|"))
                        worksheets.Add(JobVacancy.FromString(line.Substring("Вакансія роботодавця|".Length)));
                    else
                        throw new FormatException($"Unrecognized line format: {line}");
                }
            }
        }

        // Метод для сереалізації даних
        public void SerializeData(string path)
        {
            var unemployedProfile = worksheets.Where(u => u is not JobVacancy).Cast<UnemployedProfile>();
            var jobVacancy = worksheets.Where(u => u is JobVacancy).Cast<JobVacancy>();
            string jsonB = JsonSerializer.Serialize(unemployedProfile);
            string jsonTB = JsonSerializer.Serialize(jobVacancy);
            File.WriteAllLines(path, [jsonB, jsonTB]);
        }

        // Метод для десереалізації даних
        public void DeserializeData(string path)
        {
            var lines = File.ReadAllLines(path);
            var unemployedProfile = JsonSerializer.Deserialize<List<UnemployedProfile>>(lines[0]);
            var jobVacancy = JsonSerializer.Deserialize<List<JobVacancy>>(lines[1]);

            worksheets = new List<Worksheet>();
            if (unemployedProfile != null)
                worksheets.AddRange(unemployedProfile);
            if (jobVacancy != null)
                worksheets.AddRange(jobVacancy);
        }

        // Метод для додавання вакансії або анкети
        internal static void AddWorksheet(Worksheet worksheet)
        {
            worksheet.Id = GenerateId();
            worksheets.Add(worksheet);
        }

        // Метод для генерації унікального Id
        private static int GenerateId()
        {
            return worksheets.Select(u => u.Id).Max() + 1;
        }

        // Метод для видалення вакансії або анкети
        public static void RemoveWorksheet(Worksheet worksheet)
        {
            worksheets.Remove(worksheet);
        }
    }
}
