using System.Diagnostics;

namespace Illion0.Services.background
{
    public class workservice : BackgroundService
    {

        public static int count = 0;

        private const int generalDelay = 1 * 10  * 1000;
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                await Task.Delay(generalDelay, stoppingToken);
                await DoBackupAsync();
            }
        }

        private static async Task DoBackupAsync()
        {
            DateTime today = DateTime.Today;
            DateTime mid = today.AddDays(1).AddSeconds(-1);

            Console.WriteLine("Executing background task");
            Debug.WriteLine("Executing background task"+DateTime.Now);
            // here we can write logic for taking backup at midnight
            if (DateTime.Now==today)
            {
                Console.WriteLine("Executing midnight task");

               // TakeBackup();
            }

            DateTime dt3 = new DateTime(2022, 4, 22, 12, 9, 10);

            

            if (DateTime.Now.Hour == dt3.Hour && DateTime.Now.Minute==dt3.Minute)
            {
                if (count==0) {
                    Debug.WriteLine("Executing background task of backup ");

                }

                count++;
            }
            else
            {
                count = 0;
            }

            Debug.WriteLine("Executing background task count" + count);
        }
    }
}
