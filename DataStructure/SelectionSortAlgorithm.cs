using System;
namespace DataStructure
{
    public class SelectionSortAlgorithm
    {
        public static void Main()
        {
            Console.WriteLine("Selection sort");
            int[] inputarray = Common.AddInput();
            Console.WriteLine("Sorted ");
            Common.Print(SelectiomSortAlgo(inputarray));
        }
        public static int[] SelectiomSortAlgo(int[] inputArray)
        {
            return inputArray;
        }
    }
}
