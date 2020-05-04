using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorFileUpload.Data
{
    public class Product
    {
        public string ProductName { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            ProductName = name;
            Price = price;
        }
    }
}
