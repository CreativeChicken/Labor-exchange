using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Labor_exchange.Models
{
    public class JobVacancy : Worksheet
    {
        public string Company { get; set; } = "Unknown";
        public string Position { get; set; } = "Unknown";
        public string Conditions { get; set; } = "Unknown";
        public string Salary { get; set; } = "Unknown";
        public string Housing { get; set; } = "Unknown";
        public string Requirements { get; set; } = "Unknown";
        public bool IsArchived { get; set; } = false;

        // Вивід даних у вигляді рядка та помітка архівування
        public override string ToString()
        {
            return (IsArchived ? "[У АРХІВІ] " : "") + $"{Company} | {Position} | {Conditions} | {Salary} | {Housing} | {Requirements}";
        }

        // Метод для перетворення рядка в об'єкт JobVacancy
        public static JobVacancy FromString(string line)
        {
            var arr = line.Split('|');
            if (arr.Length != 6)
                throw new FormatException("Invalid format for JobVacancy.");

            return new JobVacancy
            {
                Id = Convert.ToInt32(arr[1]),
                Company = arr[2],
                Position = arr[3],
                Conditions = arr[4],
                Salary = arr[5],
                Housing = arr[6],
                Requirements = arr[7]
            };
        }

        // Метод для перевірки валідності даних
        public string Validate()
        {
            string errorMessage = "";
            if (string.IsNullOrEmpty(Company))
                errorMessage += "Company must not be empty.\n";
            if (string.IsNullOrEmpty(Position))
                errorMessage += "Position must not be empty.\n";
            if (string.IsNullOrEmpty(Conditions))
                errorMessage += "Conditions must not be empty.\n";
            if (string.IsNullOrEmpty(Salary))
                errorMessage += "Salary must not be empty.\n";
            if (string.IsNullOrEmpty(Housing))
                errorMessage += "Housing must not be empty.\n";
            if (string.IsNullOrEmpty(Requirements))
                errorMessage += "Requirements must not be empty.\n";
            return errorMessage;
        }
    }
}
