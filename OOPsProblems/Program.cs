using OOPsProblems.Abstraction;
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
            //Que 1
            // Create an object of the Rectangle class
            //Rectangle myRectangle = new Rectangle("red", 4.5, 3.2);

            // Access and modify object properties
            //Console.WriteLine("Length: " + myRectangle.Length);
            //Console.WriteLine("Width: " + myRectangle.Width);
            //Console.WriteLine("Area: " + myRectangle.CalculateArea());

            // Modify object properties
            //myRectangle.Length = 5.1;
            //myRectangle.Width = 2.8;

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
            //Methods method = new Methods();
            //method.allMethods();

            //Programming Constructs
            /*
            ProgrammingConstructs myProgram = new ProgrammingConstructs();
            myProgram.EqualOrNot(10, 12);           //que 1(if else)
            myProgram.IsValidVoterOrNot(18);        //que 3(if else)
            myProgram.IsLargestNumber(54, 54, 65);  //que 1(if else if)
            myProgram.AdmissionCriteria(70, 99, 50);//que 2(if else if)
            */
            //Switch switchcase = new Switch();       //que 1(switch)
            //Console.WriteLine("\n<------------ que1 ------------->");
            //Console.WriteLine("Enter any number between 1 to 7 : ");
            //int input = Convert.ToInt32(Console.ReadLine());
            //switchcase.Weekday(input);

            //Console.WriteLine("\n<------------ que2 ------------->");
            //switchcase.ArithmaticOperations();      //que 2(switch)
            /*
            ForLoop forLoop = new ForLoop();
            Console.WriteLine("\n<------------ que1 ------------->");
            forLoop.GetPowerOfTwo();                //que 1(for loop)
            Console.WriteLine("\n<------------ que2 ------------->");
            forLoop.SumOfSquares();                 //que 2(for loop)
            Console.WriteLine("\n<------------ que3 ------------->");
            forLoop.Factorial();                    //que 3(for loop)
            */
            //WhileLoop whileLoop = new WhileLoop();
            //Console.WriteLine("\n<------------ que1 ------------->");
            //whileLoop.FlipCoinGame();               //que 1(while loop)
            //Console.WriteLine("\n<------------ que2 ------------->");
            //whileLoop.ReverseWord();                //que 2(while loop)
            //Console.WriteLine("\n<------------ que3 ------------->");
            //whileLoop.NaturalNumber();              //que 3(while loop)
            

            //Abstraction 
            Child child = new Child("Rupesh", 07, 36000);//After deduction : 32400
            child.CalculateSalary();
        }
    }
}