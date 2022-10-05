namespace StudentDBExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Tommy", "Phil", "Joey" };
            bool goOn = true;

            while (goOn == true)
            {
            Console.WriteLine("Hello, which student would you like to learn more about? Please input a number from 1 to " + names.Length);
                int index = -1;
                string input;
                //You want to wrap your try block around as few lines as possible, it makes tracking down exceptions much easier
                try
                {
                    input = Console.ReadLine();
                    index = int.Parse(input);
                    string selectedName = names[index -1];
                    Console.WriteLine(selectedName);
                }
                //The Format Exeception e is a catch block variable represent the exception 
                //We can use that variable e to learn info about exception using 2 different properties: 
                //Message and Stack trace
                catch (FormatException e)
                {
                    Console.WriteLine("Your input was not a valid number please try again, the valid range for indexes is 1 to " + names.Length);
                    Console.WriteLine(e.Message);
                    continue;

                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine("Your input was outside the accepted range, please input a number between 1 and " + names.Length);
                    continue;
                }
            }
        }
    }
}