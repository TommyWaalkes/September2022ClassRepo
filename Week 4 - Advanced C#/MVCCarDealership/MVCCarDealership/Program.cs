namespace MVCCarDealership
{
    internal class Program
    {
        static void Main(string[] args)
        {
           CarController cc = new CarController();
            cc.CarList();
        }
    }
}