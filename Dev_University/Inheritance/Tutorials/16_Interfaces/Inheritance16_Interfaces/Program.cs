using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance16_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var appointment = new Appointment()
            {
                Name = "Bob",
                StartDateTime = DateTime.Now.AddHours(1),
                EndDateTime = DateTime.Now.AddHours(2),
                Price = 100D
            };

            var book = new Book()
            {
                Title = "How to Implement Interfaces",
                Price = 50D
            };

            List<IPurchasable> items = new List<IPurchasable>();
            items.Add(appointment);
            items.Add(book);

            CompleteTransaction(items);

            Console.ReadLine();
        }

        static void CompleteTransaction(List<IPurchasable> items)
        {
            //foreach (var item in items)
            //{
            //    item.Purchase();
            //}

            items.ForEach(p => p.Purchase());
        }
    }

    public class Appointment : IPurchasable
    {
        public string Name { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public double Price { get; set; }

        public void Purchase()
        {
            Console.WriteLine($"Payment for Appointment for {Name} from {StartDateTime} to {EndDateTime} for {Price.ToString("C0")}.");
        }
    }

    public class Book : IPurchasable
    {
        public string Title { get; set; }
        public double Price { get; set; }

        public void Purchase()
        {

            Console.WriteLine($"Purchasing {Title} for {Price.ToString("C0")}.");
        }
    }

    interface IPurchasable
    {
        double Price { get; set; }

        void Purchase();
    }
}

