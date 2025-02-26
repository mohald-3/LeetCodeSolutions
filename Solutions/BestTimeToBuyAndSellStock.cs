using Spectre.Console;

namespace LeetCodeSolutions.Solutions
{
    public static class BestTimeToBuyAndSellStock
    {
        private static int MaxProfit(int[] prices)
        {
            int minPrice = int.MaxValue;
            int maxProfit = 0;

            foreach (int price in prices)
            {
                if (price < minPrice)
                {
                    minPrice = price;
                }
                else if (price - minPrice > maxProfit)
                {
                    maxProfit = price - minPrice;
                }
            }

            return maxProfit;
        }

        public static void RunBestTimeToBuyAndSellStock()
        {
            AnsiConsole.MarkupLine("[green]Running: Best Time to Buy and Sell Stock[/]\n");

            // Sample input arrays
            int[] prices1 = { 7, 1, 5, 3, 6, 4 };
            int[] prices2 = { 7, 6, 4, 3, 1 };

            var result1 = MaxProfit(prices1);
            var result2 = MaxProfit(prices2);

            AnsiConsole.MarkupLine("[bold]Test Case 1:[/]");
            AnsiConsole.MarkupLine($"  Prices: [yellow]{string.Join(", ", prices1)}[/]");
            AnsiConsole.MarkupLine($"  Max Profit: [blue]{result1}[/]\n");

            AnsiConsole.MarkupLine("[bold]Test Case 2:[/]");
            AnsiConsole.MarkupLine($"  Prices: [yellow]{string.Join(", ", prices2)}[/]");
            AnsiConsole.MarkupLine($"  Max Profit: [blue]{result2}[/]");
        }
    }
}
