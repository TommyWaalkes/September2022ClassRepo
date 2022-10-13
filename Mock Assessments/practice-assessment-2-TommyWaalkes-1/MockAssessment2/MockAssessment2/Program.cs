public class Program
{
    public static void Main()
    {
        //You may use main to test your code, but if the test doesnt ask you to do anything in main,
        //you will not be graded on whats in main 

        //This first approach is good when you know what values you ahead of time 
        //I generally tend to default to this 
        string[] people = { "Vader", "Luke", "Yoda", "Kylo Ren" };

        //This is what most languages use to init arrays 
        //Is good for when you might not know the size of the array or what you will put into it
        string[] people2 = new string[5];
        people2[0] = "Chewwy";


        int index = AddStarCharacterIndexOf(people);

        Console.WriteLine(index);

        Dictionary<string, int> jediToPowers = new Dictionary<string, int>();
        jediToPowers.Add("Yoda", 1000000);
        jediToPowers.Add("Anakin Skywalker", 9999999);
        jediToPowers.Add("Jimmy Scrambles",10);
        jediToPowers.Add("TaunTaun", 2);

        string strongest = DeathStarCombat(jediToPowers);
        Console.WriteLine(strongest);

        string[] planets = {"Dagobah", "Ryloth", "Genosis", "Endor" };
        List<string> planetsReversed = ConvertPlanets(planets);
        foreach(string planet in planetsReversed)
        {
            Console.WriteLine(planet);
        }
        Console.WriteLine();
        List<string> planetsReversed2 = ConvertPlanetsLongWay(planets);
        foreach( string planet in planetsReversed2)
        {
            Console.WriteLine(planet);
        }

        List<int> droids = new List<int>() { 10,15,20,25};

        Console.WriteLine(AverageDroids(droids));

        Console.WriteLine(TryToCatchDarthVader("66"));
        Console.WriteLine(TryToCatchDarthVader("z34wxrtcysdghj"));

    }

    public static int AddStarWarsCharacter(string[] people)
    {
        //it wants us to find the index of "Yoda" 
        for(int i = 0; i < people.Length; i++)
        {
            if(people[i] == "Yoda")
            {
                return i;
            }
        }
        return -1;
    }

    //Guessing that finding indexes with linq isn't possible 
    public static int AddStarCharacterIndexOf(string[] people)
    {
        int index = Array.IndexOf(people, "Yoda");
        return index;
    }

    public static string DeathStarCombat(Dictionary<string, int> jediToPowers)
    {
        int highest = 0;
        string strongestJedi = "";
        foreach( KeyValuePair<string, int> kvp in jediToPowers)
        {
            if(kvp.Value > highest)
            {
                highest = kvp.Value;
                strongestJedi = kvp.Key;
            }
        }

        return strongestJedi;
    }

    public static List<string> ConvertPlanets(string[] planents)
    {
        List<string> list = planents.Reverse().ToList();
        return list;
    }

    public static List<string> ConvertPlanetsLongWay(string[] planets)
    {
        string[] reversed = new string[planets.Length];

        int j = 0; 
        //Space shuttle loop 
        for(int i = planets.Length - 1; i >= 0; i--)
        {
            reversed[j] = planets[i];
            j++;
        }

        List<string> output = new List<string>();
        foreach(string s in reversed)
        {
            output.Add(s);
        }

        return output;
    }

    public static double AverageDroids(List<int> droids)
    {
        double average = droids.Where(d => d % 2 == 0).Average();
        return average;
    }

    public static string TryToCatchDarthVader( string input)
    {
        try
        {
            int num = int.Parse(input);

            return "Vader was Captured!";
        }
        catch(FormatException e)
        {
            return "Vader got away!";
        }
    }
}