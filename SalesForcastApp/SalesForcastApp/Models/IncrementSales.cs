using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesForcastApp.Models
{
    public class IncrementSales
    {
        public string State { get; set; } = "";
        public double TotalSales {  get; set; }
        public double IncrementedSales {  get; set; }
        public double NewSales { get; set; }
    }
}
