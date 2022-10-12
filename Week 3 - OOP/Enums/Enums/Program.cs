using Enums;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Please select a day of the week to meet up");
        string input = Console.ReadLine();
        //2 values that go into enum.Parse,
        //first is the enum you wish to parse to,
        //second is the value you're trying to parse
        DaysOfTheWeek day = (DaysOfTheWeek) Enum.Parse( typeof(DaysOfTheWeek), input);
        //SelectDayToMeet(input); 
        SelectDayToMeetEnum(day);

        List<MusicCD> musicCollection = new List<MusicCD>();

        musicCollection.Add(new MusicCD("White Noise", 1000, "The CRTs", MusicGenre.Vaporwave));
        musicCollection.Add(new MusicCD("Floral Shoppe", 54, "Macintosh Plus", MusicGenre.Vaporwave));
        musicCollection.Add(new MusicCD("Full Moon Fever", 45, "Tom Petty", MusicGenre.Rock));
        musicCollection.Add(new MusicCD("Deltron 3030", 60, "Deltron 3030", MusicGenre.Rap));
        musicCollection.Add(new MusicCD("Into the Great Wide Open", 50, "Tom Petty and the Heartbreakers", MusicGenre.Rock));
        List<MusicCD> searchResults = SearchByGenre(MusicGenre.Rock, musicCollection);
        Console.WriteLine();
        foreach(MusicCD musicCD in searchResults)
        {
            Console.WriteLine(musicCD.Title);
        }
    }

    public static List<MusicCD> SearchByGenre(MusicGenre searchGenre, List<MusicCD> searchList)
    {
        return searchList.Where(cd => cd.Genre == searchGenre).ToList();
    }

    public static void SelectDayToMeet(string input)
    {
        if(input == "Tuesday")
        {
            Console.WriteLine("Cool I can meet that day");
        }
        else if(input == "Wednesday")
        {
            Console.WriteLine("That day doesnt work I have water my cats homework");
        }

    }
    //An enum variable can only be one of the preset enum values 
    //I am guaruteed to get a day of the week put into this method 
    //We only have to account for the days, and nothing else
    public static void SelectDayToMeetEnum(DaysOfTheWeek day)
    {
        //This how you call a specific value inside an enum 
        //Commonly series of if statements and/or swtich statements are common with enums
        if(day == DaysOfTheWeek.Tuesday)
        {
            Console.WriteLine("Cool that day works for me");
        }
        else if(day == DaysOfTheWeek.Wednesday)
        {
            Console.WriteLine("I have to water my cats homework");
        }
    }
}

//There are 2 places to put enums either in their own file or lumped into the file the uses them most frequently 
public enum DaysOfTheWeek
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}