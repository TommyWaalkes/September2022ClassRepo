using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCConsoleStoreFront
{
    public class ProductController
    {
        //In MVC, this list doesn't care where the list of products comes from 
        //So on my backend, I plug in and out different data sources such as: 
        //1) Files 
        //2) Databases
        //3) APIs
        //Regardless of source, the data get plopped right into our productsDB 
        public List<Product> ProductsDB { get; set; } = new List<Product>();

        //We'll use our constructor to fake filling in our Database 
        //We'll learn later how to put different data sources into this list
        public ProductController()
        {
            ProductsDB.Add(new Product() { Name ="Nacho Cheese", Price=3.50, Description="Yummy nacho cheese, smear it on anything", Weight =.75, Category="Food" });
            ProductsDB.Add(new Product() { Name = "Bill Clinton's Book", Price = 20.00, Description = "Thrilling murder mystery about presidents and stuff", Weight = 1.5, Category="Books" });
            ProductsDB.Add(new Product() { Name = "Mega Truck", Price = 1000000, Description = "Big truck for mining the size of like a sky scraper", Weight = 900000, Category="Hardware" });
            ProductsDB.Add(new Product() { Name = "Mario Kart", Price = 30, Description = "The classic Kart racing game, blue shells are stupid, I'm not mad you're mad ", Weight = .20, Category="Video Games" });
            ProductsDB.Add(new Product() { Name = "City Skylines", Price = 30, Description = "Classic City Bulding game which is highly realistic", Weight = .20, Category="Video Games" });
        }

        //This will be our controller 
        //And in controllers the methods that manage and display views are called actions
        public void Welcome()
        {
            //An action's job is 2 things: 
            //1) pull in data decide how it gets used 
            //2) passing data down to our view
            WelcomeView wv = new WelcomeView();
            wv.Display();

            //To jump to another "page" we call its action
            Search();
        }

        public void Search()
        {
            SearchView sv = new SearchView();
            string category = sv.Display();

            List<Product> products = ProductsDB.Where(x => x.Category.ToLower() == category.ToLower()).ToList();

            //Redirect to the results page
            SearchResults(products);
            
        }

        public void SearchResults(List<Product> foundProducts)
        {
            SearchResultsView srv = new SearchResultsView(foundProducts);
            Product selectedProduct = srv.Display();

            //Redirect to Product view 
            Product(selectedProduct);
        }

        public void Product(Product p)
        {
            //The views job is show off the full details of the product
            ProductView pv = new ProductView(p);
            pv.Display();
        }
    }
}
