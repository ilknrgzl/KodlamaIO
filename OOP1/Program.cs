using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnıtsInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitPrice = 35, ProductName = "Kalem", UnıtsInStock = 5 };

            //PascalCase   //camelCase
            //case sensitive 

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

            //productManager.topla(2, 3);
            //productManager.topla2(3, 6);

            //int toplamSonuc = productManager.topla(3, 6);

            //Console.WriteLine(toplamSonuc*2);




            Console.ReadLine();


        }
    }
}
