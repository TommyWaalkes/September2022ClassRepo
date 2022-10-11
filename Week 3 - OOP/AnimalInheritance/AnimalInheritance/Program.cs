using AnimalInheritance;

public class Program
{
    public static void Main()
    {
        Deer d = new Deer();
        Console.WriteLine("Feeding the Deer");
        Console.WriteLine(d.IsSated);
        d.Eat("Plants", 1500);
        Console.WriteLine(d.IsSated);
        // d.base.Eat("Meat", 1000);
        Console.WriteLine();
        Console.WriteLine("Feeding the Cat");
        Cat c = new Cat();
        Console.WriteLine(c.IsSated);
        c.Eat("Meat", 1000);
        Console.WriteLine(c.IsSated);

        Console.WriteLine();
        Console.WriteLine("Feeding The Chimp");
        Chimp ch = new Chimp();
        Console.WriteLine(ch.IsSated);
        ch.Eat("Plants", 2000);
        Console.WriteLine(ch.IsSated);
        ch.Eat("Meat", 300);
        Console.WriteLine(ch.IsSated);
        
        Console.WriteLine();
        Console.WriteLine("Feeding the Bush");
        Bush b = new Bush();
        Console.WriteLine(b.IsSated);
        b.Eat("light", 50);
        Console.WriteLine(b.IsSated);
        Console.WriteLine();
        Console.WriteLine("Feeding the Panda");
        Panda p = new Panda();
        Console.WriteLine(p.IsSated);
        p.Eat("plants", 3005);
        Console.WriteLine(p.IsSated);
        p.Eat("plants", 3000);
        Console.WriteLine(p.IsSated);
        Console.WriteLine();
        Console.WriteLine("Feeding the Wolf");
        Wolf w = new Wolf();
        Console.WriteLine(w.IsSated);
        w.Eat("meat", 800);
        Console.WriteLine(w.IsSated);
        w.Eat("meat", 800);
        w.Eat("meat", 800);
        w.Eat("meat", 800);
        Console.WriteLine(w.IsSated);

        Console.WriteLine();
        Console.WriteLine("Feeding Pig");
        Pig pigy = new Pig();
        Console.WriteLine(pigy.IsSated);
        pigy.Eat("meat", 3000);
        Console.WriteLine(pigy.IsSated);
        pigy.Eat("plants", 1000);
        Console.WriteLine(pigy.IsSated);

        //Note that since all these variables are animals, they can all be hearded into the same list 
        //This is an example of polymorphism 
        //The one downside to doing this, is that any data
        //or method specific to an animal child falls off when placed in the list
        List<Animal> animals   = new List<Animal>();

        animals.Add(p);
        animals.Add(w);
        animals.Add(pigy);
        animals.Add(ch);

    }
}