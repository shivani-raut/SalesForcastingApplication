using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesForcastApp.Models
{
    public class OrderProductInfo
    {
        public string OrderId { get; set; } = "";
        public string ProductId { get; set; } = "";
        public double Sales { get; set; }
        public int Quantity {  get; set; }
        public double Discount {  get; set; }
        public double Profit {  get; set; }
    }
}
