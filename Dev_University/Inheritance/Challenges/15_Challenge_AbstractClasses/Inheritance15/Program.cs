using System;
using System.Collections.Generic;

namespace Inheritance15
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pay an hourly employee Bob who works for 40 hours
            // Bob's hourly rate is $27.50

            // Pay a salaried employee Steve who works one week.
            // Steve's yearly salary is $50,000

            var Bob = new HourlyEmployee
            {
                Name = "Bob",
                HoursWorked = 40,
                HourlyWage = 27.50

            };

            var Steve = new SalariedEmployee
            {
                Name = "Steve",
                PaymentCycle = 1, // Gets paid weekly.
                Salary = 50000
            };

            List<Employee> List = new List<Employee>();
            List.Add(Bob);
            List.Add(Steve);

            PayEmployees(List);

            Console.ReadLine();

        }

        static void PayEmployees(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                employee.PayEmployee();
            }
        }
    }

    abstract class Employee
    {
        public string Name { get; set; }

        public abstract void PayEmployee();
    }

    class HourlyEmployee : Employee
    {
        public double HoursWorked { get; set; }
        public double HourlyWage { get; set; }

        public override void PayEmployee()
        {
            double wages = HoursWorked * HourlyWage;
            Console.WriteLine($"{Name}'s total wages are: {HoursWorked} * {HourlyWage} = {wages}.");
        }
    }

    class SalariedEmployee : Employee
    {
        public double PaymentCycle { get; set; }
        public double Salary { get; set; }

        public override void PayEmployee()
        {
            double numOfPayments = 52 / PaymentCycle;
            double wages = Salary / numOfPayments;
            Console.WriteLine($"{Name}'s total wages are: {Salary} / {numOfPayments} = {wages}.");
        }
    }


}
