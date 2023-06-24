using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsProblems
{
    public class Shape
    {
        // Field
        public string Color { get; set; }

        // Constructor
        public Shape(string color)
        {
            Color = color;
        }

        // Method
        public virtual void Display()
        {
            Console.WriteLine("Color: " + Color);
        }
    }
}
