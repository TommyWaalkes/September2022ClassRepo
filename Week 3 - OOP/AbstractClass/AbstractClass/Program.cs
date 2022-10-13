namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Panda p = new Panda(3000);
            Console.WriteLine("Feeding the Panda");
            p.Eat(FoodType.Meat, 6000);
            Console.WriteLine(p.IsSated);

            p.Eat(FoodType.Plants, 6000);
            Console.WriteLine(p.IsSated);
        }
    }
}