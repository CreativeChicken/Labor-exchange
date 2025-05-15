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
            var Worksheet = new JobExchange();
            Worksheet.CreateTestData(100);
            Worksheet.SerializeData("data.txt");

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}