using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobsPizza.Domain
{
    public class CustomerManager
    {
        public static List<DTO.Customer> GetCustomers()
        {
            var customers = Persistence.CustomersRepository.GetCustomers();

            return customers;
        }

        public static void AddCustomer(DTO.Customer customer)
        {
            try
            {
                Persistence.CustomersRepository.AddCustomer(customer);
            }
            catch (Exception)
            {
                // Log it.
                throw;
            }
        }

        public static double calcTotal(DTO.Customer customer)
        {
            double value = 0;

            if (customer.Size == "Small") value += 12;
            if (customer.Size == "Medium") value += 14;
            if (customer.Size == "Large") value += 16;
            if (customer.Crust == "Thick") value += 2;
            if (customer.Sausage == Boolean.TrueString) value += 2;
            if (customer.Pepperoni == Boolean.TrueString) value += 1.50;
            if (customer.Onions == Boolean.TrueString) value += 1;
            if (customer.Green_Peppers == Boolean.TrueString) value += 1;

            return value;
        }

        public static void CompleteOrder(Guid orderID)
        {
            Persistence.CustomersRepository.CompleteOrder(orderID);
        }
    }
}
