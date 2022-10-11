using AnimalInheritance;

public class Program
{
    public static void Main()
    {
        Deer d = new Deer();
        Console.WriteLine(d.IsSated);
        d.Eat("Plants", 1500);
        Console.WriteLine(d.IsSated);
        // d.base.Eat("Meat", 1000);

        Cat c = new Cat();
        Console.WriteLine(c.IsSated);
        c.Eat("Meat", 1000);
        Console.WriteLine(c.IsSated);

        Chimp ch = new Chimp();
        Console.WriteLine(ch.IsSated);
        ch.Eat("Plants", 2000);
        Console.WriteLine(ch.IsSated);
        ch.Eat("Meat", 300);
        Console.WriteLine(ch.IsSated);
        
        Console.WriteLine();
        Bush b = new Bush();
        Console.WriteLine(b.IsSated);
        b.Eat("light", 50);
        Console.WriteLine(b.IsSated);
        Console.WriteLine();

        Panda p = new Panda();
        Console.WriteLine(p.IsSated);
        p.Eat("plants", 3000);
        Console.WriteLine(p.IsSated);
        p.Eat("plants", 3000);
        Console.WriteLine(p.IsSated);
    }
}