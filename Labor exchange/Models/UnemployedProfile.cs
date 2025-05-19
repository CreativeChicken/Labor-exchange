using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Labor_exchange.Models
{
    public class UnemployedProfile : Worksheet
    {
        public string Name { get; set; } = "Невідомо";
        public int Age { get; set; } = 18;
        public string Proffession { get; set; } = "Невідомо";
        public string Education { get; set; } = "Невідомо";
        public string LastJobPlace { get; set; } = "Невідомо";
        public string LastJobPosition { get; set; } = "Невідомо";
        public string DismissalReason { get; set; } = "Невідомо";
        public string MaritalStatus { get; set; } = "Невідомо";
        public string Housing { get; set; } = "Невідомо";
        public string Contacts { get; set; } = "Невідомо";
        public string JobExpectations { get; set; } = "Невідомо";
        public bool IsArchived { get; set; } = false;

        // Вивід даних у вигляді рядка та помітка архівування
        public override string ToString()
        {
            return (IsArchived ? "[У АРХІВІ] " : "") + $"{Name} | {Age} | {Proffession} | {Education} | {LastJobPlace} | {LastJobPosition} | {DismissalReason} | {MaritalStatus} | {Housing} | {Contacts} | {JobExpectations} ";
        }

        // Метод для перетворення рядка в об'єкт UnemployedProfile
        public static UnemployedProfile FromString(string line)
        {
            var arr = line.Split('|');
            if (arr.Length != 11)
                throw new FormatException("Недійсний формат.");

            return new UnemployedProfile
            {
                Id = Convert.ToInt32(arr[1]),
                Name = arr[2],
                Age = Convert.ToInt32(arr[3]),
                Proffession = arr[4],
                Education = arr[5],
                LastJobPlace = arr[6],
                LastJobPosition = arr[7],
                DismissalReason = arr[8],
                MaritalStatus = arr[9],
                Housing = arr[10],
                Contacts = arr[11],
                JobExpectations = arr[12]
            };
        }

        // Метод для перевірки валідності даних
        public string Validate()
        {
            string errorMessage = "";
            if (string.IsNullOrEmpty(Name))
                errorMessage += "Ім'я не може бути пустим.\n";
            if (Age < 18 || Age > 100)
                errorMessage += "Вік має бути від 18 до 100.\n";
            if (string.IsNullOrEmpty(Proffession))
                errorMessage += "Професія не може бути пустою.\n";
            if (string.IsNullOrEmpty(Education))
                errorMessage += "Освіта не може бути пустою.\n";
            if (string.IsNullOrEmpty(LastJobPlace))
                errorMessage += "Місце останнього працевлаштування не може бути пустим.\n";
            if (string.IsNullOrEmpty(LastJobPosition))
                errorMessage += "Посада останнього працевлаштування не може бути пустою.\n";
            if (string.IsNullOrEmpty(DismissalReason))
                errorMessage += "Причина звільнення не може бути пустою.\n";
            if (string.IsNullOrEmpty(MaritalStatus))
                errorMessage += "Сімейний стан не може бути пустим.\n";
            if (string.IsNullOrEmpty(Housing))
                errorMessage += "Житлові умови не можуть бути пустими.\n";
            if (string.IsNullOrEmpty(Contacts))
                errorMessage += "Контактні координати не можуть бути пустими.\n";
            if (string.IsNullOrEmpty(JobExpectations))
                errorMessage += "Вимоги до майбутньої роботи не можуть бути пустими.\n";

            return errorMessage;
        }
    }
}
