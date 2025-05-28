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
    // Клас для дій над вакансіями та анкетами безробітних
    public class JobExchange
    {
        public static List<Worksheet> worksheets { get; set; } = new();

        // Метод для пошуку вакансій або анкет безробітних
        public static List<Worksheet> Find(Worksheet worksheetToFind)
        {
            List<Worksheet> finded = new List<Worksheet>();

            foreach (var worksheet in worksheets)
            {
                if (worksheet is JobVacancy jobVacancy && worksheetToFind is JobVacancy targetVacancy)
                {
                    if (jobVacancy.Company.Contains(targetVacancy.Company, StringComparison.OrdinalIgnoreCase) &&
                        jobVacancy.Position.Contains(targetVacancy.Position, StringComparison.OrdinalIgnoreCase) &&
                        jobVacancy.Salary.Contains(targetVacancy.Salary, StringComparison.OrdinalIgnoreCase) &&
                        jobVacancy.Housing.Contains(targetVacancy.Housing, StringComparison.OrdinalIgnoreCase))
                    {
                        finded.Add(worksheet);
                    }
                }
                else if (worksheet is UnemployedProfile profile && worksheetToFind is UnemployedProfile targetProfile)
                {
                    if (profile.Proffession.Contains(targetProfile.Proffession, StringComparison.OrdinalIgnoreCase) &&
                        profile.Education.Contains(targetProfile.Education, StringComparison.OrdinalIgnoreCase) &&
                        profile.LastJobPlace.Contains(targetProfile.LastJobPlace, StringComparison.OrdinalIgnoreCase) &&
                        profile.LastJobPosition.Contains(targetProfile.LastJobPosition, StringComparison.OrdinalIgnoreCase))
                    {
                        finded.Add(worksheet);
                    }
                }
            }

            return finded;
        }

        // Метод для генерації тестових даних
        public void CreateTestData(int count)
        {
            for (int i = 1; i <= count; i++)
            {
                worksheets.Add(new JobVacancy
                {
                    Id = i,
                    Company = $"Фірма {i}",
                    Position = $"Посада {i}",
                    Conditions = $"Умови праці {i}",
                    Salary = $"Зарплата {i}",
                    Housing = $"Житлові умови {i}",
                    Requirements = $"Вимоги до фахівця {i}"
                });
                worksheets.Add(new UnemployedProfile
                {
                    Id = i,
                    Name = $"Ім'я {i}",
                    Age = 18 + i,
                    Proffession = $"Професія {i}",
                    Education = $"Освіта {i}",
                    LastJobPlace = $"Останнє місце роботи {i}",
                    LastJobPosition = $"Остання посада {i}",
                    DismissalReason = $"Причина звільнення {i}",
                    MaritalStatus = $"Сімейний стан {i}",
                    Housing = $"Житлові умови {i}",
                    Contacts = $"Контакти {i}",
                    JobExpectations = $"Вимоги від роботи {i}"
                });
            }
        }

        // Метод для сереалізації даних
        public void SerializeData(string path)
        {
            var unemployedProfile = worksheets
                .Where(w => w is not JobVacancy)
                .Cast<UnemployedProfile>();
            var jobVacancy = worksheets
                .Where(w => w is JobVacancy)
                .Cast<JobVacancy>();
            string jsonB = JsonSerializer
                .Serialize(unemployedProfile);
            string jsonTB = JsonSerializer
                .Serialize(jobVacancy);
            File.WriteAllLines(path, [jsonB, jsonTB]);
        }

        // Метод для десереалізації даних
        public void DeserializeData(string path)
        {
            var lines = File.ReadAllLines(path);
            var unemployedProfile = JsonSerializer
                .Deserialize<List<UnemployedProfile>>(lines[0]);
            var jobVacancy = JsonSerializer
                .Deserialize<List<JobVacancy>>(lines[1]);

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
            return worksheets.Select(w => w.Id).Max() + 1;
        }

        // Метод для видалення вакансії або анкети
        public static void RemoveWorksheet(Worksheet worksheet)
        {
            worksheets.Remove(worksheet);
        }
    }
}
