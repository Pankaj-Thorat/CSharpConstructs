using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsProblems.Inheritance
{
    //Single Inheritance
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating.");
        }
    }

    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking.");
        }
    }

    //Multiple Inheritance (Through Interfaces)
    interface IShape
    {
        double GetArea();
    }

    interface IDrawable
    {
        void Draw();
    }

    class Circle : IShape, IDrawable
    {
        public double Radius { get; set; }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public void Draw()
        {
            Console.WriteLine("Drawing a circle.");
        }
    }

    //Multilevel Inheritance
    class Vehicle
    {
        public void Start()
        {
            Console.WriteLine("Vehicle started.");
        }
    }

    class Car : Vehicle
    {
        public void Drive()
        {
            Console.WriteLine("Car is driving.");
        }
    }

    class SportsCar : Car
    {
        public void Accelerate()
        {
            Console.WriteLine("Sports car is accelerating.");
        }
    }


}
