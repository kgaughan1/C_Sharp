using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobsPizza.DTO
{
    public partial class Customer
    {
        public System.Guid OrderID { get; set; }
        public string Size { get; set; }
        public string Crust { get; set; }
        public string Sausage { get; set; }
        public string Pepperoni { get; set; }
        public string Onions { get; set; }
        public string Green_Peppers { get; set; }
        public string Total_Cost { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string Payment_Type { get; set; }
        public string Completed { get; set; }
    }
}
