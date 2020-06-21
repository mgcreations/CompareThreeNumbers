using System;

namespace CompareThreeNumbers
{
    class Program
    {
        static void Main()
        {
            int num1, num2, num3;

            Console.Write("Enter 1st number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 3rd number: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
                if (num1 == num3)
                    Console.WriteLine("All 3 numbers are equal.");
                else
                    Console.WriteLine("First 2 numbers are equal.");
            else
                if (num1 == num3)
                Console.WriteLine("The 1st and 3rd number are equal");
            else
                if (num2 == num3)
                Console.WriteLine("The last two numbers are equal.");
            else
                Console.WriteLine("No two numbers are equal");
        }
    }
}
