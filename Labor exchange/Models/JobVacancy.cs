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

        public override string ToString() =>
            $"{Company}|{Position}|{Conditions}|{Salary}|{Housing}|{Requirements}";

        public static JobVacancy FromString(string line)
        {
            var arr = line.Split('|');
            if (arr.Length != 6)
                throw new FormatException("Invalid format for JobVacancy.");

            return new JobVacancy
            {
                Company = arr[0],
                Position = arr[1],
                Conditions = arr[2],
                Salary = arr[3],
                Housing = arr[4],
                Requirements = arr[5]
            };
        }
    }
}
