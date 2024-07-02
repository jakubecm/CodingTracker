using Spectre.Console;

namespace CodingTracker
{
    public class Interface
    {
        public static void ShowHeading()
        {
            var headline = new FigletText("Coding Tracker")
            .Centered()
            .Color(Color.Green);

            var panel = new Panel(headline)
                .NoBorder()
                .Padding(0, 0, 0, 2); // Padding values: left, top, right, bottom

            AnsiConsole.Write(panel);
        }

        public static string GetUserSelection()
        {
            string[] choices = { "Start live session", "Manual entry", "View records", "Update record", "Delete record", "Exit" };

            return AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .Title("What would you like to do?")
                .PageSize(6)
                .AddChoices(choices)
                .HighlightStyle(new Style(Color.Green, decoration: Decoration.Bold)));
        }
    }
}
