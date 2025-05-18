using Labor_exchange.Models;

namespace Labor_exchange
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!File.Exists("data.txt"))
            {
                var Worksheet = new JobExchange();
                Worksheet.CreateTestData(35);
                Worksheet.SerializeData("data.txt");
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
