using Spectre.Console;
using System.Globalization;

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

        public static string GetDateTimeInput()
        {
            return AnsiConsole.Prompt(
                new TextPrompt<string>("[bold white]Your answer:[/] ")
                .PromptStyle("green")
                .ValidationErrorMessage("[red]That is not a valid format[/]")
                .Validate(date =>
                {
                    string format = "dd-MM-yyyy HH:mm:ss";
                    DateTime temp;

                    bool isValid = DateTime.TryParseExact(date, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out temp);

                    return isValid ? ValidationResult.Success() : ValidationResult.Error("[bold red]Please enter the date in correct format[/]");
                })
            );
        }
    }
}
