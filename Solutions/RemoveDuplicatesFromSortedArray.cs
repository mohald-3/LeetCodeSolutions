namespace LeetCodeSolutions.Solutions
{
    public class RemoveDuplicatesFromSortedArray
    {
        public static int RemoveDuplicates(int[] nums)
        {
            //edge case
            if (nums.Length == 0) return 0;

            int uniqueIndex = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[uniqueIndex])
                {
                    uniqueIndex++;
                    nums[uniqueIndex] = nums[i];
                }
            }
            return uniqueIndex + 1;
        }


        public static void RunRemoveDuplicatesFromSortedArray()
        {
            AnsiConsole.MarkupLine("[green]Running: Best Time to Buy and Sell Stock[/]\n");

            // Sample input arrays
            int[] num1 = { 1, 1, 2 };
            int[] num2 = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };


            // Test Case 1
            AnsiConsole.MarkupLine("[bold]Test Case 1:[/]");
            AnsiConsole.MarkupLine($"  Original list: [yellow]{string.Join(", ", num1)}[/]");
            int result1 = RemoveDuplicates(num1);
            AnsiConsole.MarkupLine($"  Unique count: [blue]{result1}[/]");
            AnsiConsole.MarkupLine($"  Modified list: [blue]{string.Join(", ", num1.Take(result1))}[/]\n");

            // Test Case 2
            AnsiConsole.MarkupLine("[bold]Test Case 2:[/]");
            AnsiConsole.MarkupLine($"  Original list: [yellow]{string.Join(", ", num2)}[/]");
            int result2 = RemoveDuplicates(num2);
            AnsiConsole.MarkupLine($"  Unique count: [blue]{result2}[/]");
            AnsiConsole.MarkupLine($"  Modified list: [blue]{string.Join(", ", num2.Take(result2))}[/]");

        }
    }
}
