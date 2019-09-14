using System;
namespace DataStructure
{
    public class MergeSortAlgorithm
    {
        public static void Main1()
        {
            Console.WriteLine("Merge sort");
            int[] inputarray = Common.AddInput();
            MergeSort(inputarray);
            Console.WriteLine("Sorted ");
            Common.Print(inputarray);
        }
        public static void MergeSort(int[] inputArray)
        {
            if (inputArray.Length < 2)
                return;
            int middle = inputArray.Length / 2;
            int[] leftarray = new int[middle];
            for (int i = 0; i < middle; i++)
            {
                leftarray[i] = inputArray[i];
            }
            MergeSort(leftarray);
            int[] rightarray = new int[inputArray.Length - middle];
            for (int j = 0; j < (inputArray.Length - middle); j++)
            {
                rightarray[j] = inputArray[middle + j];
            }
            MergeSort(rightarray);
            ChangePosition(inputArray, leftarray, rightarray);
        }
        public static void ChangePosition(int[] inputArray, int[] leftarray, int[] rightarray)
        {
            int lengthOfLeft = leftarray.Length;
            int lengthOfRight = rightarray.Length;
            int lengthOfArray = inputArray.Length;
            int l = 0, r = 0, a = 0;
            while (l < lengthOfLeft && r < lengthOfRight && a < lengthOfArray)
            {
                if (leftarray[l] <= rightarray[r])
                {
                    inputArray[a] = leftarray[l];
                    l++;
                }
                else
                {
                    inputArray[a] = rightarray[r];
                    r++;
                }
                a++;
            }
            while (a < lengthOfArray)
            {
                if (l == lengthOfLeft && r < lengthOfRight)
                {
                    inputArray[a] = rightarray[r];
                    r++;
                    a++;
                }
                if (r == lengthOfRight && l < lengthOfLeft)
                {
                    inputArray[a] = leftarray[l];
                    l++;
                    a++;
                }
            }
        }
    }
}