namespace Exercise42to44
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input an x and y for your first point in this format: 4 7");
            string input = Console.ReadLine().Trim();
            //Split no params splits along spaces
            //We can assume index is our x and index 1 is our y 
            string[] rawNums = input.Split();
            Point p = new Point(0,0);
            if(rawNums.Length == 2)
            {

                int x1 = int.Parse(rawNums[0]);
                int y1 = int.Parse(rawNums[1]);

                p = new Point(x1, y1);
            }
            else
            {
                Console.WriteLine("Please input exactly 2 integers");
            }
            


            Console.WriteLine("Please input an x and y for your second point in this format: 4 7");
          
            string input2 = Console.ReadLine().Trim();
            //Split no params splits along spaces
            //We can assume index is our x and index 1 is our y 
            string[] rawNums2 = input2.Split();
            Point p2 = new Point(0,0);
            if (rawNums2.Length == 2)
            {
                int x2 = int.Parse(rawNums2[0]);
                int y2 = int.Parse(rawNums2[1]);

                p2 = new Point(x2, y2);
            }
            else
            {
                Console.WriteLine("Please input exactly 2 integers");
            }

            double dist = Math.Sqrt((Math.Pow(p.X - p2.X, 2) + Math.Pow(p.Y - p2.Y, 2)));

            Console.WriteLine(dist);
            double middleOffset = dist / 2;

            Point mid = new Point((p.X + p2.X) / 2, (p.Y + p2.Y) / 2);

            Console.WriteLine($"Mid point X: {mid.X}  Mid point Y: {mid.Y}");



        }
    }
}