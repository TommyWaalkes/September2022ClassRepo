public class Program
{
    public static void Main()
    {
        string userInput = GetUserInput("Welcome to our exponents app, please input an int and I will print out an exponents table.");
        Console.WriteLine(userInput);

        int num = int.Parse(userInput);
      

        for(int i =1; i <=num; i++)
        {
            double root = SqrtNum(i);
            int square = SquareNum(i);
            int cube = CubeNum(i);

            //String interpolation is a short hand way of constructing a string 
            //Instead of adding different piece together, you place values inside the string
            Console.WriteLine($"{root} \t {i} \t {square} \t {cube}");
        }
    }

    public static string GetUserInput(string message)
    {
        Console.WriteLine(message);
        string input = Console.ReadLine();
        return input;
    }

    public static int SquareNum(int num)
    {
        return num * num;
    }

    public static int CubeNum(int num)
    {
        return num * num * num;
    }

    public static double SqrtNum(int num)
    {
        return Math.Round( Math.Sqrt(num), 2);
    }
}