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
        public string Company { get; set; } = "Невідомо";
        public string Position { get; set; } = "Невідомо";
        public string Conditions { get; set; } = "Невідомо";
        public string Salary { get; set; } = "Невідомо";
        public string Housing { get; set; } = "Невідомо";
        public string Requirements { get; set; } = "Невідомо";
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
                throw new FormatException("Недійсний формат.");

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
                errorMessage += "Фірма не може бути пустою.\n";
            if (string.IsNullOrEmpty(Position))
                errorMessage += "Посада не може бути пустою.\n";
            if (string.IsNullOrEmpty(Conditions))
                errorMessage += "Умови праці не можуть бути пустими.\n";
            if (string.IsNullOrEmpty(Salary))
                errorMessage += "Заробітня плата не може бути пустою.\n";
            if (string.IsNullOrEmpty(Housing))
                errorMessage += "Житлові умови не можуть бути пустими.\n";
            if (string.IsNullOrEmpty(Requirements))
                errorMessage += "Вимоги до фахівця не можуть бути пустими.\n";
            return errorMessage;
        }
    }
}
