namespace NumberAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome, please input your name.");
            string name = Console.ReadLine();

            bool goOn = true;

            while (goOn == true)
            {

                Console.WriteLine("Welcome to our Number Analyzer, " + name + ". Please input a number between 1 and 100 inclusive.");
                string input = Console.ReadLine();
                int num = int.Parse(input);

                if (num >= 1 && num <= 100)
                {
                    Console.WriteLine("Good work, " + name +" you entered a valid number");
                    //Analyze the number
                    bool isEven = num % 2 == 0;

                    if (isEven == true)
                    {
                        if (num >= 2 && num <= 24)
                        {
                            Console.WriteLine("Even and less than 25.");
                        }
                        else if (num >= 26 && num <= 60)
                        {
                            Console.WriteLine("Even and between 26 and 60 inclusive");
                        }
                        else
                        {
                            Console.WriteLine("Even and greater than 60.");
                        }
                    }
                    else
                    {
                        if(num <= 60)
                        {
                            Console.WriteLine("Odd and less than 60.");
                        }
                        else
                        {
                            Console.WriteLine("Odd and greater than 60.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("That number was not between 1 and 100, " + name);
                }

                goOn = AskToContinue();
            }
        }

        public static bool AskToContinue()
        {
            Console.WriteLine("Would you like to continue? Y/N");
            string input = Console.ReadLine().ToLower();
            //3 Posibilities
            //y - return true 
            //n - return false 
            //Anything else - try asking again

            if(input == "y")
            {
                //Return statements in methods pass data outside of the method 
                //Return statements must return something matching the datatype 
                //we set in the method's signature.
                //When you hit a return it ends the method and takes you back to where the method was called. 
                return true;
            }
            else if(input == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("I didn't understand that, please try again.");
               return AskToContinue();
            }
        }
    }
}