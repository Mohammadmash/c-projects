using System;

namespace number_to_triple
{
    class Program
    {
        static void Main(string[] args)
        {
            int y;
            Console.WriteLine("enter the number for triple");
            string number = Console.ReadLine();
            y = int.Parse(number);
            y *= 3;
            Console.WriteLine(y);
            Console.ReadKey();
        }
    }
}
