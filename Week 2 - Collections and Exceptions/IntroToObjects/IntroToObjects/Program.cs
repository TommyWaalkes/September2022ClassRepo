namespace IntroToObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car("Ford", "Tacoma", "White", 2011);
            c.Year = 2017;

            Console.WriteLine(c.Year);

            Console.WriteLine("Miles: "+c.MilesTraveled);

            c.Drive();
            Console.WriteLine("Miles: " + c.MilesTraveled);

            //Objects are useable as list and array types 
            List<Car> cars = new List<Car>();
            cars.Add(new Car("Ford", "Windstar", "Red", 1999));
            cars.Add(new Car("Ford", "Taurus", "Blue", 2011));
            cars.Add(new Car("Toyota", "Camry", "Blue", 2009));
            cars.Add(new Car("GM", "Nova", "Red", 2017));

            //In this case c is a variable that pops into existance for linq 
            //
            List<Car> redCars = cars.Where(c => c.Color == "Red").ToList();
            PrintCars(redCars);
            Console.WriteLine();

            List<Car> oldCars = cars.Where(c => c.Year < 2010).ToList();
            PrintCars(oldCars);
        }

        //I am using static since I am in program.cs 
        public static void PrintCars(List<Car> cars)
        {
            for(int i = 0; i < cars.Count; i++)
            {
                Car c = cars[i];
                Console.WriteLine($"Make: {c.Make}, Model: {c.Model}");
            }
        }
    }
}