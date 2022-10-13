using System.Security.Cryptography.X509Certificates;

namespace LinqExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 43, 19, 20, 55, 12, 90 };

            List<int> evenNums = nums.Where(num => num % 2 ==0).ToList();
            PrintList(evenNums);

            Console.WriteLine();
            List<int> numsUnder50 = nums.Where(num => num <50).ToList();
            PrintList(numsUnder50);

            int oddCount = nums.Count(num => num % 2 == 1);
            Console.WriteLine("Odds Count: "+oddCount);

            //I want to average every number between 15 and 60
            //Without params average does the whole list 
            //With a lambda expression it will average only number that meet the condition 
            double average = nums.Where(num => num > 15 && num < 60).Average();
            Console.WriteLine(average);

            //Linq may be used on any data type, and that includes objects 
            List<string> foods = new List<string>() {"Mac and Cheese", "Hot Dog", "Pasta", "Bread", "Pizza" };

            List<string> pLetters = foods.Where(f => f.ToLower().Contains("p")).ToList();
            PrintList(pLetters);
            Console.WriteLine();
            List<string> longFoods = foods.Where(f => f.Length > 5).ToList();
            PrintList(longFoods);

            //Max grabs the highest humber that matches the input condition, if no condition is input, then it gets the highest number
            int highest = nums.Max();
            Console.WriteLine(highest);
            int highestOdd = nums.Where(n => n % 2 == 1).Max();
            Console.WriteLine(highestOdd);
            int lowest = nums.Min();
            Console.WriteLine(lowest);

            int[] nums2 = { 10, 2330, 112233, 10, 949, 3764, 2942 };

           // Array.Sort(nums2);
            nums2= nums2.OrderByDescending(n => n).ToArray();
            Console.WriteLine();
            foreach(int num in nums2)
            {
                Console.WriteLine(num);
            }
        }

        public static void PrintList(List<int> input)
        {
            for(int i =0; i < input.Count; i++)
            {
                int num = input[i];
                Console.WriteLine($"{i}: {num}");
            }
        }

        public static void PrintList(List<string> input)
        {
            for (int i = 0; i < input.Count; i++)
            {
                string s = input[i];
                Console.WriteLine($"{i}: {s}");
            }
        }
    }
}