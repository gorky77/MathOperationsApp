using System;

namespace CallingMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asking the user for a number to perform math operations on
            Console.WriteLine("Enter a number:");
            int input = Convert.ToInt32(Console.ReadLine());

            // Performing the math operations using the methods in MathMethods class
            int result1 = MathMethods.AddTen(input);
            int result2 = MathMethods.MultiplyByTwo(input);
            int result3 = MathMethods.SubtractFive(input);

            // Displaying the results to the user
            Console.WriteLine("After adding 10: " + result1);
            Console.WriteLine("After multiplying by 2: " + result2);
            Console.WriteLine("After subtracting 5: " + result3);

            // Keeping the console window open
            Console.ReadLine();
        }
    }
}

