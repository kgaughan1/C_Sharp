using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance11_Sealed
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    sealed class Automobile
    {
        public void Drive()
        {
            Console.WriteLine("Automobile is driving.");
        }
    }

    // NOTE: The class car cannot be inherited from Automobile because the Automobile class is sealed.
    class Car : Automobile
    {

    }

    class Animal
    {
        public virtual void Walk()
        {
            Console.WriteLine("This animal is walking.");
        }
    }

    class Feline : Animal
    {
        public sealed override void Walk()
        {
            Console.WriteLine("This feline is prowling.");
        }
    }

    // Note: The Walk function in the HouseCat class cannot be overriden because the Walk function in the Feline class is sealed.
    class HouseCat : Feline
    {
        public override void Walk()
        {
            Console.WriteLine("This kitty is pouncing.");
        }
    }
}
