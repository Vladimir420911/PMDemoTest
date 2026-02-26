using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class OrderRecord
    {
        public string NameProduct { get; set; }
        public DateTime SaleDate { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public double Cost { get { return Price * Count; } }
    }
}
