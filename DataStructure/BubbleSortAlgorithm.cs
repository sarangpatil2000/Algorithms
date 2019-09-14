using System;
namespace DataStructure
{
    public class BubbleSortAlgorithm
    {
        public static void Main1()
        {
            Console.WriteLine("Bubble sort");
            int[] inputarray = Common.AddInput();
            Console.WriteLine("Sorted ");
            Common.Print(BubbleSortAlgo(inputarray));
        }
        public static int[] BubbleSortAlgo(int[] input)
        {
            int lengthOfArray = input.Length;
            int n = lengthOfArray;
            bool canBreak = true;
            while (n > 0 && canBreak)
            {
                canBreak = false;
                for (int i = 0; i < n - 1; i++)
                {
                    if (input[i] > input[i + 1])
                    {
                        canBreak = true;
                        swap(input, i);
                    }
                }
                n--;
            }
            return input;
        }
        public static void swap(int[] input, int i)
        {
            int value = input[i];
            input[i] = input[i + 1];
            input[i + 1] = value;
        }
    }
}
