namespace DictionaryExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //With the dictionary it is 100% up to the programmer to enforce the relationship between keys and values 
            Dictionary<string, int> namesToAges = new Dictionary<string, int>();

            //A key may only appear once in a dictionary 
            //But as many different keys may point to the same values 
            //put another way, keys may not repeat, whearas values may repeat as much as you wish 
            //This rule for keys exists to prevent ambigous situations 
            namesToAges.Add("Jimmy", 8);
            namesToAges.Add("Sarah", 15);
            namesToAges.Add("Hank", 42);

            //How do we retrieve values from a dictionary? 
            int hanksAge = namesToAges["Hank"];
            Console.WriteLine(hanksAge);
            
            //This gives you all your values in a list format 
            //namesToAges.Values;

            //Same idea for keys 
            //namesToAges.Keys; 

            //This how to iterate through a dictionary, there are not sequential indexes 
            //so a for loop can't be used as easily here 
            foreach(KeyValuePair<string, int> kvp in namesToAges)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }

            //These methods are handy particularly for avoiding adding existing keys
            //If a key exists, then you may go grab its value
            bool hasJimmy = namesToAges.ContainsKey("Jimmy");
            bool has8 = namesToAges.ContainsValue(8);

            if(hasJimmy == true)
            {
                int age = namesToAges["Jimmy"];
                Console.WriteLine(age);
            }

        }
    }
}