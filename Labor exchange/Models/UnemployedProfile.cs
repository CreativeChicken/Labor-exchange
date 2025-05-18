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
        public string Name { get; set; } = "Unknown";
        public int Age { get; set; } = 18;
        public string Proffession { get; set; } = "Unknown";
        public string Education { get; set; } = "Unknown";
        public string LastJobPlace { get; set; } = "Unknown";
        public string LastJobPosition { get; set; } = "Unknown";
        public string DismissalReason { get; set; } = "Unknown";
        public string MaritalStatus { get; set; } = "Unknown";
        public string Housing { get; set; } = "Unknown";
        public string Contacts { get; set; } = "Unknown";
        public string JobExpectations { get; set; } = "Unknown";
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
                throw new FormatException("Invalid format for UnemployedProfile.");

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
                errorMessage += "Name must not be empty.\n";
            if (Age < 18 || Age > 100)
                errorMessage += "Age must be between 18 and 100.\n";
            if (string.IsNullOrEmpty(Proffession))
                errorMessage += "Profession must not be empty.\n";
            if (string.IsNullOrEmpty(Education))
                errorMessage += "Education must not be empty.\n";
            if (string.IsNullOrEmpty(LastJobPlace))
                errorMessage += "Last job place must not be empty.\n";
            if (string.IsNullOrEmpty(LastJobPosition))
                errorMessage += "Last job position must not be empty.\n";
            if (string.IsNullOrEmpty(DismissalReason))
                errorMessage += "Dismissal reason must not be empty.\n";
            if (string.IsNullOrEmpty(MaritalStatus))
                errorMessage += "Marital status must not be empty.\n";
            if (string.IsNullOrEmpty(Housing))
                errorMessage += "Housing must not be empty.\n";
            if (string.IsNullOrEmpty(Contacts))
                errorMessage += "Contacts must not be empty.\n";
            if (string.IsNullOrEmpty(JobExpectations))
                errorMessage += "Job expectations must not be empty.\n";

            return errorMessage;
        }
    }
}
