﻿using System;
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
            //Que 1
            // Create an object of the Rectangle class
            Rectangle myRectangle = new Rectangle("red", 4.5, 3.2);

            // Access and modify object properties
            Console.WriteLine("Length: " + myRectangle.Length);
            Console.WriteLine("Width: " + myRectangle.Width);
            Console.WriteLine("Area: " + myRectangle.CalculateArea());

            // Modify object properties
            myRectangle.Length = 5.1;
            myRectangle.Width = 2.8;

            // Access updated object properties
            //Console.WriteLine("Length: " + myRectangle.Length);
            //Console.WriteLine("Width: " + myRectangle.Width);
            //Console.WriteLine("Area: " + myRectangle.CalculateArea());
            //Console.WriteLine("Color: " + myRectangle.Color);

            //Que 6
            //create an object for Variables class
            //Variables variable = new Variables();
            //variable.allVariables();

            // Que 7
            Methods method = new Methods();
            method.allMethods();

            //Programming Constructs

            ProgrammingConstructs myProgram = new ProgrammingConstructs();
            myProgram.EqualOrNot(10, 12);           //que 1(if else)
            myProgram.IsValidVoterOrNot(18);        //que 3(if else)
            myProgram.IsLargestNumber(54, 54, 65);  //que 1(if else if)
            myProgram.AdmissionCriteria(70, 65, 51);//que 2(if else if)
        }
    }
}