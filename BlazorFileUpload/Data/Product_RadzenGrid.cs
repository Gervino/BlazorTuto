using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorFileUpload.Data
{
    public class Product_RadzenGrid
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}
