using System;

namespace Inheritance09
{
    class Program
    {
        static void Main(string[] args)
        {
            var mbr = new MasterBedroom() { Width = 10, Length = 12 };
            var br = new Bedroom() { Width = 14, Length = 14 };

            //Console.WriteLine(mbr.GetType().ToString());
            //Console.WriteLine(typeof(MasterBedroom).ToString());

            // IsSubClassOf() - Allows you to determine whether a class inherits
            //                  from a parent (or grandparent) class.

            //Console.WriteLine(typeof(Kitchen).IsSubclassOf(typeof(Room))); // true
            //Console.WriteLine(typeof(MasterBedroom).IsSubclassOf(typeof(Bedroom))); // true
            //Console.WriteLine(typeof(MasterBedroom).IsSubclassOf(typeof(Room))); //true
            //Console.WriteLine(typeof(MasterBedroom).IsSubclassOf(typeof(Kitchen))); // false

            // IsInstanceOfType() - Same idea, but allows you to work with
            //                      instances of classes (rather than classes)

            //Console.WriteLine(typeof(MasterBedroom).IsInstanceOfType(mbr)); // true
            //Console.WriteLine(typeof(Bedroom).IsInstanceOfType(mbr)); // true
            //Console.WriteLine(typeof(Room).IsInstanceOfType(mbr)); // true
            //Console.WriteLine(typeof(Kitchen).IsInstanceOfType(mbr)); // false

            // IsAssignableFrom() - Determines whether an instance of a specified 
            //                      type can be assigned to an instance of the 
            //                      current type.

            //Console.WriteLine(typeof(MasterBedroom).IsAssignableFrom(typeof(Bedroom))); // false
            //MasterBedroom test1 = new MasterBedroom();
            //test1 = br;
            // Cannot be directly compared!

            //Console.WriteLine(typeof(Bedroom).IsAssignableFrom(typeof(MasterBedroom))); // true
            //Bedroom test2 = new Bedroom();
            //test2 = mbr;

            Console.ReadLine();
        }
    }

    class Room
    {
        public int Width { get; set; }
        public int Length { get; set; }
    }

    class Kitchen : Room
    {
    }

    class Bedroom : Room
    {
    }

    class Guestroom : Bedroom
    {
    }

    class MasterBedroom : Bedroom
    {
    }
}
