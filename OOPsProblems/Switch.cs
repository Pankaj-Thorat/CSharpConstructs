using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace OOPsProblems
{
    internal class Switch
    {
        public void Weekday(int x)
        {

            string weekday;

            switch (x)
            {
                case 1:
                    weekday = "Monday";
                    break;
                case 2:
                    weekday = "Tuesday";
                    break;
                case 3:
                    weekday = "Wednesday";
                    break;
                case 4:
                    weekday = "Thursday";
                    break;
                case 5:
                    weekday = "Friday";
                    break;
                case 6:
                    weekday = "Saturday";
                    break;
                case 7:
                    weekday = "Sunday";
                    break;
                default:
                    weekday = "Invalid number. Please enter a number between 1 and 7.";
                    break;
            }
            Console.WriteLine("Weekday: " + weekday);
        }

        public void ArithmaticOperations()
        {
            double number1, number2;
            Console.Write("Enter the first number: ");
            number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            number2 = Convert.ToDouble(Console.ReadLine());

            bool showMenu = true;
            while (showMenu)
            {
                Console.WriteLine("\nSelect an arithmetic operation:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice (1-5): ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        double additionResult = number1 + number2;
                        Console.WriteLine("Addition: " + additionResult);
                        break;
                    case 2:
                        double subtractionResult = number1 - number2;
                        Console.WriteLine("Subtraction: " + subtractionResult);
                        break;
                    case 3:
                        double multiplicationResult = number1 * number2;
                        Console.WriteLine("Multiplication: " + multiplicationResult);
                        break;
                    case 4:
                        if (number2 != 0)
                        {
                            double divisionResult = number1 / number2;
                            Console.WriteLine("Division: " + divisionResult);
                        }
                        else
                        {
                            Console.WriteLine("Cannot divide by zero.");
                        }
                        break;
                    case 5:
                        showMenu = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}
