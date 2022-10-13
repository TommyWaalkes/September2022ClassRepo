namespace Params
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double avg = AverageParams(10, 98, 10, 17);
            Console.WriteLine(avg);

            double[] nums = { 70, 83, 91, 77 };
            double avg2 = AverageParams(nums);
            Console.WriteLine(avg2);
        }

        //Doing the average this way, I may only ever pass 2 values into this method 
        public static double AverageNums(double num1, double num2)
        {
            double avg = (num1 + num2) / 2;
            return avg;
        }

        //the params keyword allows us to pass in as many or as few parameters as we wish, 
        //Useful for when we don't know how many numbers we want to average 

        //Params will always go next to an Array, params will dump all of them into that array 
        //If you are using parama next to parameter, it must be the last parameter in the method 
       
        public static double AverageParams( params double[] nums)
        {
            return nums.Average();
        }

    }
}