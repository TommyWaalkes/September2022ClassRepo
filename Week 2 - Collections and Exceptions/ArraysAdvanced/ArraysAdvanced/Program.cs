namespace ArraysAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Tommy", "Jimmy", "Timmy", "Janey" };

            //Let's do a shallow copy and see what it looks like: 
            string[] namesCopy = names;
            names[0] = "Pam";
            //PrintNames(names);
            //PrintNames(namesCopy);

            //Say we need to unlink our copies, we need to do a deep copy
            string[] namesDeepCopy = new string[names.Length];

            //The main point is that you can use array.copy when you want to copy your array. 
            Array.Copy(names, namesDeepCopy, names.Length);

            namesDeepCopy[0] = names[0];

            names[0] = "Booboo";

            PrintNames(names);
            PrintNames(namesDeepCopy);

            //Sort Example: 
            string[] students = { "2 chains","#JimBob", "Frank", "Zack", "Phillip", "12345","Jane", "Boyd" };
            PrintNames(students);

            Array.Sort(students);

            PrintNames(students);

            //Binary search returns the index where the search term is first found
            //Many language actually don't have built in search functions 
            int index = Array.BinarySearch(students, "Zack");
            Console.WriteLine(index);

            //Personally I prefer making a new array, but clear is nice for large datasets (millions +) 
            //Clear will set all values in the array to their default
            Array.Clear(students);
            PrintNames(students);

        }

        //Print talks to the console and NOT the method
        public static void PrintNames(string[] names)
        {
            Console.WriteLine("Printing Array");
            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(i+" "+names[i]);
            }
            Console.WriteLine();
        }
    }
}