namespace RoomCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool goOn = true;

            while (goOn)
            {
                Console.WriteLine("Welcome to our Room Calculator App");

                Console.WriteLine("Pleasei input a length: ");
                double length = double.Parse(Console.ReadLine());

                Console.WriteLine("Please input a width: ");
                double width = double.Parse(Console.ReadLine());

                Console.WriteLine("Please input a height: ");
                double height = double.Parse(Console.ReadLine());

                double area = length * width;

                double perimeter = 2 * length + 2 * width;

                double volume = area * height;

                Console.WriteLine("Area: " + area);
                Console.WriteLine("Perimeter: " + perimeter);
                Console.WriteLine("Volume: " + volume);

                if(area <= 250)
                {
                    Console.WriteLine("This Room is small");
                }
                else if(area<650 && area > 250)
                {
                    Console.WriteLine("This is a medium room");
                }
                else
                {
                    Console.WriteLine("This Room is large and in charge");
                }

                bool askAgain = true;
                while (askAgain)
                {
                    Console.WriteLine("Would you like to continue? Y/N");
                    string input = Console.ReadLine().ToLower();
                    //3 cases to care about: 
                    //Yes - continue the program 
                    //No - end the program 
                    //Anything else - ask the question 

                    if(input == "y")
                    {
                        goOn = true;
                        askAgain = false;
                    }
                    else if(input == "n")
                    {
                        goOn = false;
                        askAgain = false;
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry I didn't understand that let's try that again");
                        askAgain = true;
                    }
                }
            }
        }
    }
}