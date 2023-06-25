using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsProblems
{
    internal class Variables
    {
        public void allVariables()
        {
            Console.WriteLine("\n<---------- Que 6 ----------->");
            //Integer variable
            int age = 25;
            Console.WriteLine("Age: " + age);

            // Floating-point variable
            double pi = 3.14159;
            Console.WriteLine("Pi: " + pi);

            // Character variable
            char grade = 'A';
            Console.WriteLine("Grade: " + grade);

            // Boolean variable
            bool isStudent = true;
            Console.WriteLine("Is student? " + isStudent);

            // String variable
            string name = "John Doe";
            Console.WriteLine("Name: " + name);

            // Constant variable
            const int numberOfMonths = 12;
            Console.WriteLine("Number of months: " + numberOfMonths);

            // Nullable variable
            int? nullableNumber = null;
            Console.WriteLine("Nullable number: " + nullableNumber);

            // Array variable
            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Numbers: " + string.Join(", ", numbers));

            // Object variable
            object myObject = "Hello, World!";
            Console.WriteLine("Object: " + myObject);
        }
    }
}

