using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsProblems
{
    internal class Methods
    {
        // Method without a return value
        public static void PrintMessage()
        {
            Console.WriteLine("Hello, World!");
        }

        // Method with a return value
        public static int AddNumbers(int a, int b)
        {
            return a + b;
        }

        // Method with parameters and output parameter with expression body
        public static void DivideNumbers(int dividend, int divisor, out int quotient) => quotient = dividend / divisor;

        // Method with optional parameters
        public static void DisplayInfo(string name, int age = 0)
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
        }

        // Method with variable number of arguments (params)
        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }
        public void allMethods()
        {
            // Calling different types of methods
            Console.WriteLine("\n<---------- Que 7 ----------->");
            PrintMessage();

            int result = AddNumbers(10, 5);
            Console.WriteLine("Result of addition: " + result);

            int quotient;
            DivideNumbers(20, 4, out quotient);
            Console.WriteLine("Quotient: " + quotient);

            DisplayInfo("Pankaj Thorat");
            DisplayInfo("Tony Stark", 50);

            int sum = Sum(1, 2, 3, 4, 5);
            Console.WriteLine("Sum: " + sum);
        }
    }
}
