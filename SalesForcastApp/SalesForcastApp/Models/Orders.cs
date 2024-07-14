using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesForcastApp.Models
{
    public class Orders
    {
        public string OrderId { get; set; } = "";
        public string OrderDate { get; set; } = "";
        public string ShipMode { get; set; } = "";
        public string CustomerId { get; set; } = "";
        public string Segment { get; set; } = "";   
        public string Country { get; set; } = "";   
        public string City { get; set; } = "";
        public string State { get; set; } = "";
        public string PostalCode { get; set; } = "";
        public string Region { get; set; } = "";
    }
}
