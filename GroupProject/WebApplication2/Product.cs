using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2
{
    public class Product
    {
        public DateTime Date { get; set; }

        public string Item { get; set; }

        public double Price { get; set; }

        public Product(DateTime date, string item, double price)
        {
            this.Date = date;
            this.Item = item;
            this.Price = price;
        }

        public override string ToString()
        {
            return string.Format("{0} | {1} | {2}", this.Date, this.Item, this.Price);
        }
    }
}