using System;
namespace DataStructure
{
    public class SelectionSortAlgorithm
    {
        public static void Main1()
        {
            Console.WriteLine("Selection sort");
            int[] inputarray = Common.AddInput();
            Console.WriteLine("Sorted ");
            Common.Print(SelectiomSortAlgo(inputarray));
            Console.ReadLine();
        }
        public static int[] SelectiomSortAlgo(int[] inputArray)
        {
            int value = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                GetMinNumber(inputArray, i, out value);
                inputArray = Swap(inputArray, i, value);
            }
            return inputArray;
        }
        public static void GetMinNumber(int[] input, int startIndex, out int position)
        {
            int minNumber = input[startIndex];
            position = startIndex;
            if (startIndex + 1 == input.Length)
            {
                return;
            }
            for (int i = startIndex; i < input.Length - 1; i++)
            {
                if (minNumber > input[i + 1])
                {
                    minNumber = input[i + 1];
                    int value = i + 1;
                    position = value;
                    GetMinNumber(input, i + 1, out value);
                }
            }
        }
        public static int[] Swap(int[] inputArray, int i, int minValueIndex)
        {
            int minVal = inputArray[minValueIndex];
            inputArray[minValueIndex] = inputArray[i];
            inputArray[i] = minVal;
            return inputArray;
        }
    }
}
