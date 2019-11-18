using System;
namespace DataStructure
{
    public class BinarySearchAlgorithm
    {
        public BinarySearchAlgorithm()
        {
            Console.WriteLine("Enter Sorted array");
            int[] inputarray = Common.AddInput();
            Console.WriteLine("Enter the number to find it's 0th based location:");
            int numberToSearch = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("0th based location is " + BinarySearch(inputarray, numberToSearch));
        }
        public static int BinarySearch(int[] inputArray, int noToSearch)
        {
            int median = inputArray.Length / 2;
            int[] firstPart = new int[median];
            return 1;

        }
    }
}
