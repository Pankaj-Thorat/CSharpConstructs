using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an object of the Rectangle class
            Rectangle myRectangle = new Rectangle(4.5, 3.2);

            // Access and modify object properties
            Console.WriteLine("Length: " + myRectangle.Length);
            Console.WriteLine("Width: " + myRectangle.Width);
            Console.WriteLine("Area: " + myRectangle.CalculateArea());

            // Modify object properties
            myRectangle.Length = 5.1;
            myRectangle.Width = 2.8;

            // Access updated object properties
            Console.WriteLine("Length: " + myRectangle.Length);
            Console.WriteLine("Width: " + myRectangle.Width);
            Console.WriteLine("Area: " + myRectangle.CalculateArea());
        }
    }
}