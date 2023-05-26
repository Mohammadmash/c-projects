using System;

namespace say_hello
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("please write your name");
            name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            Console.WriteLine("press any key to continue");
            Console.ReadKey();
        }
    }
}
