namespace BlockBuster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VHS v = new VHS("Shrek", 90, Genre.Comedy, 
                new List<string>() { "Get out of my swamp", "You're a monster", "Final Wedding Scene" });

            //v.PrintScenes();
            //v.Play();
            //v.Play();
            //v.Play();
            //v.Play();
            //v.Play();

            DVD d = new DVD("Lord of the Rings", 180, Genre.Drama, 
                new List<string>() { "Bilbos Birthday", "Keep it secret keep it safe", "Rivendell", "Mines of Moria" });
            //  d.Play();

            Blockbuster b = new Blockbuster();

            Movie m = b.Checkout();
            m.Play();
        }
    }
}