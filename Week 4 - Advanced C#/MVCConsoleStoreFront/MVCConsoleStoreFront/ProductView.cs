using System;
using System.Collections.Generic;
using System.Text;

namespace MVCConsoleStoreFront
{
    class ProductView
    {
        public Product Product {get;set;}

        public ProductView(Product Product)
        {
            this.Product = Product;
        }

        public void Display()
        {
            Console.WriteLine($"Product Display for: {Product.Name}");
            Console.WriteLine($"Price: {Product.Price}");
            Console.WriteLine($"Weight: {Product.Weight}");
            Console.WriteLine($"Description: {Product.Description}");
        }
    }
}
