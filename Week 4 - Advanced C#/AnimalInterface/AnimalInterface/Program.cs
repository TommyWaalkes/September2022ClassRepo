namespace AnimalInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wolf w = new Wolf();

            w.Eat("meat", 200);
            Console.WriteLine(w.IsSated());
            w.Eat("meat", 200);
            w.Eat("meat", 200);
            w.Eat("meat", 200);
            Console.WriteLine(w.IsSated());
        }
    }
}