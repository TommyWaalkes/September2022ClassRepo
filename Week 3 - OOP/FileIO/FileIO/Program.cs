public class Program
{
    public static void Main()
    {
        //Why use File IO? - Stands for Input and Output
        //The main use is to store data permanently, any data in your program disappears once its done running 
        //This is how files are saved in any program, think MS word or a video game. 
        //While languages might use slightly setups for File IO, the general idea will be the same no matter the language
        //Every language can do File IO, save for Javascript 

        //Read -  grab the content of the file 
        //Write - overwrite the content of the file 

        //The trick with file IO will be figuring out file paths 

        //Relative paths should work no matter the computer
        //
        //Working with files and string methods go in hand in hand

        //In C# there are several ways of doing this process 
        //I picked this approach specifically since it mirrors how most other languages behave 
        string relPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName ;
        Console.WriteLine(relPath);
        string fixedRel = relPath.Substring(0,relPath.LastIndexOf("bin"));
        Console.WriteLine(fixedRel);
        //Console.WriteLine(relPath);
        //Notice the @ symbol, for filepaths we use the @ symbol since the \ sets up specials characters like \n
        //It tells C# to not treat the \ as special characters 
        string filePath = @"C:\Users\Tommy\Desktop\Class Repo\September2022ClassRepo\Week 3 - OOP\FileIO\FileIO\Country.txt";
        Console.WriteLine(filePath);
        StreamReader reader = new StreamReader(fixedRel + @"\Country.txt");
        string textDump = reader.ReadToEnd();
        Console.WriteLine(textDump);

        string[] countries = textDump.Split(',');

        foreach (string country in countries)
        {
            Console.WriteLine(country);
        }

        //Anything that opens a file places a lock on it 
        //Nothing else can look at that open file, otherwise it'd create some weird errors 
        //To release the lock we must close the reader 
        reader.Close();

        StreamWriter streamWriter = new StreamWriter(filePath);

        Console.WriteLine("Please input a new country");
        string input = Console.ReadLine();

        List<string> inputCountries = countries.ToList();

        inputCountries.Add(input);

        string outputToFile = "";

        for(int i = 0; i < inputCountries.Count; i++)
        {
            outputToFile += inputCountries[i];
            if(i < inputCountries.Count - 1)
            {
                outputToFile += ",";
            }
        }

        //Write overrides the content of the file with the input string, 
        //It does NOT add to the file.
        streamWriter.Write(outputToFile);
        streamWriter.Close();

    }
}