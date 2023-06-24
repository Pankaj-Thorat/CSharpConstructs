using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsProblems
{
    public class Rectangle
    {
        // Fields
        public double Length { get; set; }
        public double Width { get; set; }

        // Constructor
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        // Method to calculate the area
        public double CalculateArea()
        {
            return Length * Width;
        }
    }
}
