using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesForcastApp.Models
{
    public class Customer
    {
        public string CustomerId { get; set; } = "";
        public string CustomerName { get; set; } = "";
    }
}
