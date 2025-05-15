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

        public override string ToString() =>
            $"{GetType().Name}|{Name}|{Age}|{Proffession}|{Education}|{LastJobPlace}|{LastJobPosition}|{DismissalReason}|{MaritalStatus}|{Housing}|{Contacts}|{JobExpectations}";

        public static UnemployedProfile FromString(string line)
        {
            var arr = line.Split('|');
            if (arr.Length != 11)
                throw new FormatException("Invalid format for UnemployedProfile.");

            return new UnemployedProfile
            {
                Name = arr[0],
                Age = Convert.ToInt32(arr[1]),
                Proffession = arr[2],
                Education = arr[3],
                LastJobPlace = arr[4],
                LastJobPosition = arr[5],
                DismissalReason = arr[6],
                MaritalStatus = arr[7],
                Housing = arr[8],
                Contacts = arr[9],
                JobExpectations = arr[10]
            };
        }
    }
}
