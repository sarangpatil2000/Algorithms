using System;
namespace DataStructure
{
    public class RecurssionTest
    {
        public static double factorial = 1;
        public static void Main1()
        {
            Console.WriteLine("Enter number to find factorial");
            int number = Convert.ToInt32(Console.ReadLine());
            factorial = Factorial(number);
            Console.WriteLine("Output of Factorial : {0}", factorial);
            Console.ReadLine();
        }
        public static double Factorial(int num)
        {
            if (num == 0)
                return 1;
            factorial = factorial * num;
            if (num > 1)
            {
                Factorial(num - 1);
            }
            return factorial;

        }
    }
}
