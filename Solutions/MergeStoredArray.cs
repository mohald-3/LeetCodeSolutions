namespace LeetCodeSolutions.Solutions
{
    public static class MergeStoredArray
    {
        private static void Merge(int[] nums1, int m, int[] nums2, int n)
        {

            int pointer1 = m - 1;                   // Pointer for nums1 (valid elements)
            int pointer2 = n - 1;                   // Pointer for nums2
            int placementPointer = m + n - 1;       // Pointer for placement in nums1

            // Merge from the back
            while (pointer1 >= 0 && pointer2 >= 0)
            {
                if (nums1[pointer1] > nums2[pointer2])
                {
                    nums1[placementPointer] = nums1[pointer1];
                    pointer1--;
                }
                else
                {
                    nums1[placementPointer] = nums2[pointer2];
                    pointer2--;
                }
                placementPointer--;
            }

            // If there are leftover elements in nums2, copy them (nums1 is already sorted)
            while (pointer2 >= 0)
            {
                nums1[placementPointer] = nums2[pointer2];
                pointer2--;
                placementPointer--;
            }
        }

        public static void RunMergeStoredArray()
        {
            AnsiConsole.MarkupLine("[green]Running: Best Time to Buy and Sell Stock[/]\n");

            // Sample input arrays
            int[] case1num1 = [1, 2, 3, 0, 0, 0];
            int case1m = 3;
            int[] case1num2 = [2, 5, 6];
            int case1n = 3;

            int[] case2num1 = [1];
            int case2m = 1;
            int[] case2num2 = [];
            int case2n = 0;

            int[] case3num1 = [1, 2, 3, 0, 0, 0];
            int case3m = 3;
            int[] case3num2 = [2, 5, 6];
            int case3n = 3;



            AnsiConsole.MarkupLine("[bold]Test Case 1:[/]");
            AnsiConsole.MarkupLine($"  num1 result: [yellow]{string.Join(", ", case1num1)}[/]");
            AnsiConsole.MarkupLine($"  num2 result: [yellow]{string.Join(", ", case1num2)}[/]");
            Merge(case1num1, case1m, case1num2, case1n);
            AnsiConsole.MarkupLine($"  Merge result: [blue]{string.Join(", ", case1num1)}[/]");

            AnsiConsole.MarkupLine("[bold]Test Case 2:[/]");
            AnsiConsole.MarkupLine($"  Merge result: [yellow]{string.Join(", ", case2num1)}[/]");
            AnsiConsole.MarkupLine($"  Merge result: [yellow]{string.Join(", ", case2num2)}[/]");
            Merge(case2num1, case2m, case2num2, case2n);
            AnsiConsole.MarkupLine($"  Merge result: [blue]{string.Join(", ", case2num1)}[/]");

            AnsiConsole.MarkupLine("[bold]Test Case 3:[/]");
            AnsiConsole.MarkupLine($"  Merge result: [yellow]{string.Join(", ", case3num1)}[/]");
            AnsiConsole.MarkupLine($"  Merge result: [yellow]{string.Join(", ", case3num2)}[/]");
            Merge(case3num1, case3m, case3num2, case3n);
            AnsiConsole.MarkupLine($"  Merge result: [blue]{string.Join(", ", case3num1)}[/]");

        }
    }
}
