using System.Diagnostics;

namespace CodingTracker
{
    public class CodingTracker
    {
        private DatabaseController dbController;
        public CodingTracker(DatabaseController dbController)
        {
            this.dbController = dbController;
            dbController.InitializeDatabase();
        }

        public void StartLiveSession()
        {
            Console.Clear();
            bool sessionLive = true;

            DateTime sessionStart = DateTime.Now;
            Stopwatch liveTracker = new Stopwatch();
            liveTracker.Start();
            Console.WriteLine("Live session running. Press ESC to end.");

            while (sessionLive)
            {

                TimeSpan elapsed = liveTracker.Elapsed;
                string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}", elapsed.Hours, elapsed.Minutes, elapsed.Seconds);

                Console.SetCursorPosition(0, 1);
                Console.Write($"Elapsed time: {elapsedTime}\n");
                Thread.Sleep(1000);

                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape)
                {
                    liveTracker.Stop();
                    DateTime sessionEnd = DateTime.Now;
                    Console.WriteLine("Session ended. Press any key to return to main menu.");
                    Console.ReadKey();
                    sessionLive = false;
                }
            }
        }
    }
}
