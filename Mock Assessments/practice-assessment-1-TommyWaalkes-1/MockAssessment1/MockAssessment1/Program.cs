class Program
{
    //This assessment will be on Methods, if you are not asked to do anything in main, you are not going graded on 
    //Whats in main, However, it is encouraged you use main to test your code
    public static void Main()
    {
        Console.WriteLine(IsTheSame(10,10));
        Console.WriteLine(IsTheSame(10,5));

        Console.WriteLine(Subtract(17,7));
        Console.WriteLine(Subtract(20, 8));

        Console.WriteLine(FindBuildingType(3));
        Console.WriteLine(FindBuildingType(10));
        Console.WriteLine(FindBuildingType(20));
        Console.WriteLine(FindBuildingType(80));



    }

    public static bool IsTheSame(int num1, int num2)
    {
        if (num1 == num2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static double Subtract(double num1, double num2)
    {
        double result = num1 - num2;
        return result;
    }

    public static string FindBuildingType(int floors)
    {
        //What if the user inputs 0? 
        //For a lab we'd disect that and think about putting validation - that's a good instinct 
        //For assessment, you only need to put in what the assessment asks for,
        //anything beyond that will have no affect on your grade
        if(floors <= 3)
        {
            return "This is a House!";
        }
        else if (floors >= 4 && floors <= 10)
        {
            return "This is an office building!";
        }
        else if(floors >=11 && floors <= 49)
        {
            return "This is a skyscraper!";
        }
        else
        {
            return "This is a SUPER skyscraper!";
        }
    }
}