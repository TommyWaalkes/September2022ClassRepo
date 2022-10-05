namespace ShoppingCartLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //So the adds only get done once we leave our collection outside the loop
            Dictionary<string, double> itemsToPrices = new Dictionary<string, double>();

            itemsToPrices.Add("Spam", .99);
            itemsToPrices.Add("Onions", 3.99);
            itemsToPrices.Add("Potatoes", 1.99);
            itemsToPrices.Add("Beer", 5.99);

            List<string> cart = new List<string>();
            int num = -1;
            string s = cart[num];
            bool goOn = true;
            while (goOn == true)
            {
                Console.WriteLine("Which item would you like to order? Please enter either the name of the item or select the item by number");

                int menuNum = 0;
                foreach (string key in itemsToPrices.Keys)
                {
                    Console.WriteLine(menuNum +": "+ key + " $" + itemsToPrices[key]);
                    menuNum++;
                }

                bool inputNum = false;
                string input = Console.ReadLine();
                int index = -1;
                //Wrap the code we know may throw an exception in the try block
                try
                {
                    //An Exception is a runtime error built into C# 
                    //When an exception the code will be stopped in its tracks unless you catch the exception 
                    //Exceptions exist to guide you towards fixing the error, always always always read the exception message
                    index = int.Parse(input);
                    inputNum = true;
                }
                //We'll decide how we react to the exception in the catch block
                catch( FormatException e)
                {
                    //With catch you can call out and react to any exception, if you use expection here, it will catch any exception that happens 
                    //Generally it is good form to try and catch specific exception 
                    inputNum = false;
                }
                if (inputNum == true)
                {
                    if(index >=0 && index < itemsToPrices.Keys.Count)
                    {
                        string item = itemsToPrices.Keys.ToList()[index];
                        cart.Add(item);
                    }
                }
                else
                {
                    if (itemsToPrices.Keys.Contains(input))
                    {
                        //Let's proceed with the rest of our code
                        //We can later using the cart to look up all of our prices in the dictionary 
                        cart.Add(input);
                    }
                    else
                    {
                        Console.WriteLine($"I'm sorry {input} is not available, lets try that again!");
                    }
                }
                goOn = goAgain();
            }

            DisplayCart(cart, itemsToPrices);
        }

        public static void DisplayCart(List<string> items, Dictionary<string, double> itemsToPrices)
        {
            double sum = 0;
            Console.WriteLine("Here is your shopping cart: ");
            for(int i = 0; i < items.Count; i++)
            {
                string item = items[i];
                double price = itemsToPrices[item];
                sum += price;
                Console.WriteLine(item + " " + price);
            }

            Console.WriteLine("Grand Total: "+sum);
        }

        public static bool goAgain()
        {
            Console.WriteLine("Would you like to add another item to your cart? Y/N");

            string input = Console.ReadLine().Trim().ToLower();

            if(input == "y")
            {
                return true;
            }
            else if(input == "n")
            {
                return false; 
            }
            else
            {
                Console.WriteLine("Hey I didn't understand that lets try again");
                return goAgain();
            }
        }
    }
}