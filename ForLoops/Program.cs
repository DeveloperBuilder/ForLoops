using System;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
        static void HelloWorld(string[] args)
        {
            var a = "Hello ";
            var b = "World!";
            var c = a + b;
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}
