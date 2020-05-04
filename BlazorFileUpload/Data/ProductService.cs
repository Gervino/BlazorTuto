using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorFileUpload.Data
{
    public class ProductService
    {
        //RadzenGrid
        List<Product_RadzenGrid> products = new List<Product_RadzenGrid>
        {
            new Product_RadzenGrid(){ ProductID = 1, ProductName = "Computer", Price = 500000, PurchaseDate = Convert.ToDateTime("01-Mar-2019")},
            new Product_RadzenGrid(){ ProductID = 2, ProductName = "Laptop", Price = 500000, PurchaseDate = Convert.ToDateTime("02-Mar-2019")},
            new Product_RadzenGrid(){ ProductID = 3, ProductName = "Mouse", Price = 500, PurchaseDate = Convert.ToDateTime("03-Mar-2019")},
            new Product_RadzenGrid(){ ProductID = 4, ProductName = "Keyboard", Price = 300, PurchaseDate = Convert.ToDateTime("01-Mar-2019")},
            new Product_RadzenGrid(){ ProductID = 5, ProductName = "Printer", Price = 5000, PurchaseDate = Convert.ToDateTime("01-Mar-2019")},
            new Product_RadzenGrid(){ ProductID = 6, ProductName = "Pendrive", Price = 1200, PurchaseDate = Convert.ToDateTime("09-Mar-2019")},
            new Product_RadzenGrid(){ ProductID = 7, ProductName = "Speaker", Price = 6000, PurchaseDate = Convert.ToDateTime("01-Apr-2019")},
            new Product_RadzenGrid(){ ProductID = 8, ProductName = "Cable", Price = 300, PurchaseDate = Convert.ToDateTime("22-May-2019")}
        };

        public async Task<List<Product_RadzenGrid>> ProductList()
        {
            return await Task.FromResult(products);
        }

        //DropDownDataGrid
        List<Product_DropDownDataGrid> products_Drop = new List<Product_DropDownDataGrid>
        {
            new Product_DropDownDataGrid(){ ProductId = "101", ProductName = "Computer", Price = 500000},
            new Product_DropDownDataGrid(){ ProductId = "102", ProductName = "Laptop", Price = 500000},
            new Product_DropDownDataGrid(){ ProductId = "103", ProductName = "Mouse", Price = 500},
            new Product_DropDownDataGrid(){ ProductId = "104", ProductName = "Keyboard", Price = 300},
            new Product_DropDownDataGrid(){ ProductId = "105", ProductName = "Printer", Price = 5000},
            new Product_DropDownDataGrid(){ ProductId = "106", ProductName = "Pendrive", Price = 1200},
            new Product_DropDownDataGrid(){ ProductId = "107", ProductName = "Speaker", Price = 6000},
            new Product_DropDownDataGrid(){ ProductId = "108", ProductName = "Cable", Price = 300}
        };

        public async Task<List<Product_DropDownDataGrid>> ProductList_DropDownDataGrid()
        {
            return await Task.FromResult(products_Drop);
        }
    }
}
