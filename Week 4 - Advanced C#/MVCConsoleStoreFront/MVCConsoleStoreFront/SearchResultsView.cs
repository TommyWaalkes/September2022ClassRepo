using System;
using System.Collections.Generic;
using System.Text;

namespace MVCConsoleStoreFront
{
    class SearchResultsView
    {
        //In real MVC, you'd do an import statement saying I must get a list of products in here
        //We'll use a property and constructor to fake it 
        public List<Product> Products { get; set; }

        //The view takes in models to display their data 
        //And sometimes to allow the user to alter/select a specific model
        public SearchResultsView(List<Product> Products)
        {
            this.Products = Products;
        }

        public Product Display()
        {
            Console.WriteLine("Here are your search results");
            //This method has 2 jobs:
            //1) Display all our products 
            //2) Let the user select a product
            for(int i = 0; i < Products.Count; i++)
            {
                Product p = Products[i];
                Console.WriteLine($"{i}: {p.Name}");
            }
            Console.WriteLine("Please select a result to learn more about by index:");
            int input = int.Parse(Console.ReadLine());
            Product output = Products[input];

            return output;
        }


    }
}
