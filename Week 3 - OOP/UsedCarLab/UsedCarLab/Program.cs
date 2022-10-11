using UsedCarLab;

public class Program
{
    public static void Main()
    {
        Car c = new Car("Toyota", "Camry", 2009, 1500);
       
        //Since I've override to string I can do the following: 
        Console.WriteLine(c);

        List<Car> carsInventory = new List<Car>();
        carsInventory.Add(c);
        carsInventory.Add(new Car("Ford", "Tundra", 2000, 2100.00m));
        carsInventory.Add(new Car("Clown", "Buggie", 1590, 10));
        carsInventory.Add(new UsedCar("Chevy", "Nova", 1984, 800, 400000));
        carsInventory.Add(new UsedCar("Honda", "Civic", 2006, 1300, 150000));

        int index = 0;
        foreach(Car car in carsInventory)
        {
            Console.WriteLine(index+ ": " +car);
            index++;
        }

        Console.WriteLine("Which car would you like to remove? Please select by index");
        string input = Console.ReadLine();
        int pick = int.Parse(input);

        carsInventory.RemoveAt(pick);

        index = 0;
        foreach (Car car in carsInventory)
        {
            Console.WriteLine(index + ": " + car);
            index++;
        }
    }
}