namespace CodingTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Interface.ShowHeading();

            bool running = true;

            while (running)
            {
                var choice = Interface.GetUserSelection();
                switch (choice)
                {
                    case "Start live session":
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
