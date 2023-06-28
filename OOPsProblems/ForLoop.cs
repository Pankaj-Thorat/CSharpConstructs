using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsProblems
{
    internal class ForLoop
    {
        public void GetPowerOfTwo()
        {
            Console.WriteLine("Enter The Power Value of 2 :");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n >= 0 && n < 31)
            {
                Console.WriteLine("Powers of 2 that are less than or equal to 2^" + n + ":");
                int powerOf2 = 1;
                for (int i = 0; i <= n; i++)
                {
                    Console.WriteLine(powerOf2);
                    powerOf2 *= 2;
                }
            }
            else
            {
                Console.WriteLine("Error: Power value must be between 0 and 30 (inclusive).");
            }
        }

        public void SumOfSquares()
        {
            Console.WriteLine("Enter The N Value for sum of squares :");
            int n = Convert.ToInt32(Console.ReadLine());

            int sumOfNumber = 0;
            for (int i = 0; i <= n; i++)
            {
                sumOfNumber += i*i;
            }
            Console.WriteLine(sumOfNumber);
        }

        public void Factorial()
        {
            Console.WriteLine("Enter The N Value for factorial :");
            int n = Convert.ToInt32(Console.ReadLine());

            int multiOfNumber = 1;
            for (int i = 1; i <= n; i++)
            {
                multiOfNumber *= i;
            }
            Console.WriteLine(multiOfNumber);
        }
    }
}
