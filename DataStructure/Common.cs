using System;
namespace DataStructure
{
    public class Common
    {
        public static int[] AddInput()
        {
            Console.WriteLine();
            string input = Console.ReadLine();
            string[] inputarrayString = input.Split(new char[] { ',' });
            int[] inputarray = new int[inputarrayString.Length];
            Console.WriteLine("You have written");
            Console.WriteLine(string.Join(",", inputarrayString));
            for (int i = 0; i < inputarray.Length; i++)
            {
                inputarray[i] = Convert.ToInt32(inputarrayString[i]);
            }
            return inputarray;
        }
        public static void Print(int[] inputArray)
        {
            Console.WriteLine(string.Join(",",inputArray));
            Console.ReadLine();
        }
    }
}
