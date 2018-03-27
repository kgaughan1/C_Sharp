using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobsPizza.DTO.Exceptions
{
    public class CustomerInputNameException : Exception
    {
        public string errorMessage { get; set; }
    }
}
