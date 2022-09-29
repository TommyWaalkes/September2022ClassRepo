namespace RandomDiceRoller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Random r = new Random();

                //With the next method in C#, the first number aka the min is inclusive 
                //The second aka your max number is exclusive 
                int roll = r.Next(1, 7);

                Console.WriteLine(roll);
            }
        }
    }
}