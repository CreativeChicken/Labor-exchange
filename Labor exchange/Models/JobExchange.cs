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
        public List<Worksheet> worksheets { get; set; } = new();

        public void CreateTestData(int count)
        {
            int i = 1;
            for (; i <= count; i++)
            {
                worksheets.Add(new JobVacancy
                {
                    Company = $"Company {i}",
                    Position = $"Position {i}",
                    Conditions = $"Conditions {i}",
                    Salary = $"Salary {i}",
                    Housing = $"Housing {i}",
                    Requirements = $"Requirements {i}"
                });
                worksheets.Add(new UnemployedProfile
                {
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

        public void SerializeData(string path)
        {
            var unemployedProfile = worksheets.Where(u => u is not JobVacancy).Cast<UnemployedProfile>();
            var jobVacancy = worksheets.Where(u => u is JobVacancy).Cast<JobVacancy>();
            string jsonB = JsonSerializer.Serialize(unemployedProfile);
            string jsonTB = JsonSerializer.Serialize(jobVacancy);
            File.WriteAllLines(path, [jsonB, jsonTB]);
        }

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
    }
}
