using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance12_ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var automobile = new Automobile();

            automobile.MyExtensionMethod();

            Console.ReadLine();
        }
    }

    sealed class Automobile
    {
        public void Drive()
        {
            Console.WriteLine("Automobile is driving.");
        }
    }

    static class AutomobileExtensions
    {
        public static void MyExtensionMethod(this Automobile automobile)
        {
            Console.WriteLine("I was able to add an extension method.");
            automobile.Drive();
        }
    }
}
