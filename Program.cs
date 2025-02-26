namespace LeetCodeSolutions
{
    internal class Program
    {
        private static void Main()
        {
            // Dictionary mapping menu choices to solution methods
            var solutionsMenu = new Dictionary<string, Action>
            {
                { "1. Best Time to Buy and Sell Stock", BestTimeToBuyAndSellStock.RunBestTimeToBuyAndSellStock }
                // Add more problems as needed...
            };

            while (true)
            {
                var choices = solutionsMenu.Keys.ToList(); // Force list conversion
                choices.Add("Quit");

                var choice = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                        .Title("Select a problem to run or [red]Quit[/]?")
                        .PageSize(10)
                        .MoreChoicesText("[grey](Move up and down to reveal more solutions)[/]")
                        .AddChoices(choices)
                    );

                if (choice == "Quit")
                {
                    Environment.Exit(0);
                }

                // Run the selected solution
                if (solutionsMenu.ContainsKey(choice))
                {
                    AnsiConsole.Clear();
                    solutionsMenu[choice].Invoke();

                    AnsiConsole.MarkupLine("\n[grey]Press any key to return to the menu...[/]");
                    Console.ReadKey(true);
                    AnsiConsole.Clear();
                }
                else
                {
                    AnsiConsole.MarkupLine("[red]Invalid choice. Try again.[/]");
                }
            }
        }
    }
}
