using System;
namespace DataStructure
{
    public class InsertionSortAlgorithm
    {
        public static void Main()
        {
            Console.WriteLine("Insertion sort");
            int[] inputarray = Common.AddInput();
            Console.WriteLine("Sorted ");
            Common.Print(InsertionSortAlgo(inputarray));
            Console.ReadLine();
        }
        public static int[] InsertionSortAlgo(int[] inputArray)
        {
            return InsertionSort(inputArray);
        }

        static int[] InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
            return arr;
        }
    }

}
