using System;

namespace Inheritance08
{
    class Program
    {
        static void Main(string[] args)
        {
            // D is a double-literal
            var employee = new Employee() { Name = "Fernando", HourlyRate = 15D };

            Console.WriteLine(employee.ToString());
            //Console.WriteLine(employee.GetType().ToString());

            Console.ReadLine();
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public double HourlyRate { get; set; }

        public override string ToString()
        {
            //return base.ToString();
            return $"{Name} is paid {HourlyRate}";
        }
    }
}
