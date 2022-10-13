namespace ListExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //In newer versions of C#, you do not need to put in the using statement for collections 
            //I'm talking versions that came out this year 
            List<int> nums = new List<int>();
            nums.Add(100);
            nums[0] = 1000;
            Console.WriteLine(nums[0]);
            nums[-100] = 90;

            //This line converts the list to an array 
            int[] n = nums.ToArray();

            //You may also go the other direction usig toList(), most collections (and arrays) have a toList() 
            List<int> num2 = n.ToList();

            //.Net loves lists, so ToList() appears very frequently 
            //Why would you want to swap between an array and a list? 
            //1) Certain built in methods expect either an array or a list 
            //2) Converting to arrays is handy when you want to have a set amount of elements. 
            //3) Converting from any other collection into a more useable format, some collections are difficult to iterate through
        }
    }
}