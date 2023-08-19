using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Lists
{
    internal class Order
    {
        private static int count = 0;
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get; set; }
        public Order() : this(0) { }
        public Order(decimal price)
        {
            Number = ++count;
            Date = DateTime.Now;
            Total = price;
        }
        public override string ToString()
        {
            return $"№{Number} - {Total}$. Date: {Date}";
        }
    }
}
