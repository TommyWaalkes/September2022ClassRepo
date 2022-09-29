
public class Program
{
    public static void Main()
    {
        double rad = GetRandomRadius();
        double p = GetPerimeter(rad);
        Console.WriteLine("Radius: "+rad);
        Console.WriteLine("Perimeter: "+p);
    }

    //Parameters are usually a piece of data needed to run the method 
    public static double GetPerimeter(double radius)
    {
        double perimeter = 2 * Math.PI * radius;
        return perimeter;
    }

    public static double GetRandomRadius()
    {
        Random r = new Random();
        double radius = r.Next(1,101);
        return radius;
    }
}