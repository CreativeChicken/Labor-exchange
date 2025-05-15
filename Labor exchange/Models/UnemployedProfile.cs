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
            $"{GetType().Name}|{Number}|{Name}|{Age}|{Proffession}|{Education}|{LastJobPlace}|{LastJobPosition}|{DismissalReason}|{MaritalStatus}|{Housing}|{Contacts}|{JobExpectations}";

        public static UnemployedProfile FromString(string line)
        {
            var arr = line.Split('|');
            if (arr.Length != 11)
                throw new FormatException("Invalid format for UnemployedProfile.");

            return new UnemployedProfile
            {
                Number = Convert.ToInt32(arr[1]),
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
    }
}
