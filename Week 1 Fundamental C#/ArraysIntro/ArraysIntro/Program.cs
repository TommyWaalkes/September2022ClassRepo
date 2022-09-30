namespace ArraysIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //This syntax is useable in almost all languages 
            //Java, C++ 
            string[] names = new string[5];

            names[0] = "Tommy";
            names[1] = "Jose";
            names[2] = "Diana";
            names[3] = "Jimmy";
            names[4] = "Savanah";

            foreach(string name in names)
            {
                Console.WriteLine(name);
            }

            
            //Printing an array directly in C# will show only its typing not its contents 
            //To see its contents, you must use a loop
            Console.Write(names);
            Console.WriteLine();

            //I want to make a method that tells whether each age in the array is legally allowed to drink 
            //21 

            //Only some languages allow you to fill values in ahead of time: C# and Javascript
            int[] ages = { 11, 15, 22, 17, 28, 21, 7, 20 };

            for(int i =0; i < ages.Length; i++)
            {
                int a = ages[i];
                bool canDrink = DrinkingAge(a);

                if (canDrink == true)
                {
                    Console.WriteLine($"a {a} year old can drink in the USA legally");
                }
                else
                {
                    Console.WriteLine($"a {a} year old cannot drink legally in the USA");
                }
            }


            Console.WriteLine(ages[-10]);



        }

        public static bool DrinkingAge(int age)
        {
            if(age >= 21)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}