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

        public override string ToString()
        {
            return $"{Company} | {Position} | {Conditions} | {Salary} | {Housing} | {Requirements}";
        }

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
    }
}
