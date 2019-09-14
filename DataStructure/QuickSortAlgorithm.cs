using System;

namespace DataStructure
{
    class MainClass
    {
        public static void Main1(string[] args)
        {
            Console.WriteLine("Quick sort");
            Console.WriteLine();
            string input = Console.ReadLine();
            string[] inputarrayString = input.Split(new char[] { ',' });
            int[] inputarray = new int[inputarrayString.Length];
            Console.WriteLine("You have written");
            for (int i = 0; i < inputarray.Length; i++)
            {
                Console.WriteLine(inputarrayString[i]);
                inputarray[i] = Convert.ToInt32(inputarrayString[i]);
            }
            QuickSort(inputarray, 0, inputarray.Length-1);
            Console.WriteLine("Sorted ");
            for (int i = 0; i < inputarray.Length; i++)
            {
                Console.WriteLine(inputarray[i]);
            }

        }
        public static void QuickSort(int[] inputArray, int right, int left)
        {
            if (right < left)
            {
                int part = partition(inputArray, right, left);

                QuickSort(inputArray, right, part - 1);
                
                QuickSort(inputArray, part + 1, left);
            }
        }
        public static int partition(int[] inputArray, int right, int left)
        {
            int pivot = inputArray[left];
            for (int i = right; i < left; i++)
            {
                if (inputArray[i] <= pivot)
                {
                    swap(inputArray, i, right);
                    right++;
                }
            }
            swap(inputArray, left, right);
            return right;
        }
        public static void swap(int[] inputArray, int i, int right)
        {
            int value = inputArray[i];
            inputArray[i] = inputArray[right];
            inputArray[right] = value;
        }
    }
}
