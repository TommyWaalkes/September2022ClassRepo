namespace MVCCountries
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CountryController cc = new CountryController();
            cc.WelcomeAction();
           
        }
    }
}