using System;

namespace MVCConsoleStoreFront
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductController pc = new ProductController();
            pc.Welcome();
        }
    }
}
