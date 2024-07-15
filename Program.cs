using System.Configuration;

namespace CodingTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? connectionString = ConfigurationManager.AppSettings["connectionString"];
            DatabaseController dbController = new(connectionString!);
            CodingTracker tracker = new(dbController);

            bool running = true;

            while (running)
            {
                Console.Clear();
                Interface.ShowHeading();
                var choice = Interface.GetUserSelection();
                switch (choice)
                {
                    case "Start live session":
                        tracker.StartLiveSession();
                        break;
                    case "Manual entry":
                        break;
                    case "View records":
                        break;
                    case "Update record":
                        break;
                    case "Delete record":
                        break;
                    case "Exit":
                        running = false;
                        break;
                }
            }
        }
    }
}
