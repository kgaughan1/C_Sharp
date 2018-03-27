using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Prompt user to enter in a name.
            Console.WriteLine("Enter your name, please:");

            // Now read the name entered.
            string name = Console.ReadLine();

            // Greet the user with the name that was enterd.
            Console.WriteLine("Hello, " + name);

            // Wait for user to acknowledge the results.
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
    }
}
