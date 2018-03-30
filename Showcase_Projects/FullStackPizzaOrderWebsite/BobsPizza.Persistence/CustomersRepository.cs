using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BobsPizza.DTO.Exceptions;

namespace BobsPizza.Persistence
{
    public class CustomersRepository
    {
        public static List<DTO.Customer> GetCustomers()
        {
            BobsPizzaDatabaseEntities db = new BobsPizzaDatabaseEntities();

            var dbCustomers = db.Customers.ToList();

            var dtoCustomers = new List<DTO.Customer>();

            foreach (var dbCustomer in dbCustomers)
            {
                var dtoCustomer = new DTO.Customer();

                dtoCustomer.OrderID = dbCustomer.OrderID;
                dtoCustomer.Size = dbCustomer.Size;
                dtoCustomer.Crust = dbCustomer.Crust;
                dtoCustomer.Sausage = dbCustomer.Sausage;
                dtoCustomer.Pepperoni = dbCustomer.Pepperoni;
                dtoCustomer.Onions = dbCustomer.Onions;
                dtoCustomer.Green_Peppers = dbCustomer.Green_Peppers;
                dtoCustomer.Total_Cost = dbCustomer.Total_Cost;
                dtoCustomer.Name = dbCustomer.Name;
                dtoCustomer.Address = dbCustomer.Address;
                dtoCustomer.Zip = dbCustomer.Zip;
                dtoCustomer.Phone = dbCustomer.Phone;
                dtoCustomer.Payment_Type = dbCustomer.Payment_Type;
                dtoCustomer.Completed = dbCustomer.Completed;

                dtoCustomers.Add(dtoCustomer);
            }

            return dtoCustomers;
        }

        public static void CompleteOrder(Guid orderID)
        {
            var db = new BobsPizzaDatabaseEntities();

            var order = db.Customers.FirstOrDefault(p => p.OrderID == orderID);
            order.Completed = "True";
            db.SaveChanges();
        }

        public static void AddCustomer(DTO.Customer newCustomer)
        {
            BobsPizzaDatabaseEntities db = new BobsPizzaDatabaseEntities();
            var dbCustomers = db.Customers;

            var customer = new Customer();

            if (newCustomer.Name.Trim().Length == 0)
                throw new CustomerInputNameException();
            else if (newCustomer.Address.Trim().Length == 0)
                throw new CustomerAddressException();
            else if (newCustomer.Zip.Trim().Length == 0)
                throw new CustomerZipException();
            else if (newCustomer.Phone.Trim().Length == 0)
                throw new CustomerPhoneException();

            customer.OrderID = newCustomer.OrderID;
            customer.Size = newCustomer.Size;
            customer.Crust = newCustomer.Crust;
            customer.Sausage = newCustomer.Sausage;
            customer.Pepperoni = newCustomer.Pepperoni;
            customer.Onions = newCustomer.Onions;
            customer.Green_Peppers = newCustomer.Green_Peppers;
            customer.Total_Cost = newCustomer.Total_Cost;
            customer.Name = newCustomer.Name;
            customer.Address = newCustomer.Address;
            customer.Zip = newCustomer.Zip;
            customer.Phone = newCustomer.Phone;
            customer.Payment_Type = newCustomer.Payment_Type;
            customer.Completed = newCustomer.Completed;

            try
            {
                dbCustomers.Add(customer);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                // Log the exception.
                throw ex;
            }

        }
    }
}
