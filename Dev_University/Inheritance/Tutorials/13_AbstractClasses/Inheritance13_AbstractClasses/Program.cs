using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance13_AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            car.Drive();

            var feline = new Feline();

            feline.Walk();

            Console.ReadLine();
        }
    }

    abstract class Automobile
    {
        public virtual void Drive()
        {
            Console.WriteLine("I have an automobile.");
        }
    }

    class Car : Automobile
    {
        public override void Drive()
        {
            Console.WriteLine("I have a car.");
        }
    }

    abstract class Animal
    {
        public abstract void Walk();
    }

    class Feline : Animal
    {
        public override void Walk()
        {
            Console.WriteLine("Feline is pouncing.");
        }
    }
}
