using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OOPsProblems
{
    public class Rectangle : Shape
    {
        // Fields
        public double Length { get; set; }
        public double Width { get; set; }

        // Constructor
        public Rectangle(string color, double length, double width) : base(color)
        {
            Length = length;
            Width = width;
        }

        //Polymorphism override
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Length: " + Length);
            Console.WriteLine("Width: " + Width);
            Console.WriteLine("Area: " + CalculateArea());
        }

        // Method to calculate the area
        public double CalculateArea()
        {
            return Length * Width;
        }
    }
}
