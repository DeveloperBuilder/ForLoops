using System;

namespace ForLoops
{
    class Program // Class
    {
        static void Main(string[] args) // Methode
        {
            int num5 = -340;
            num5 = 34 % 5;
            num5 = num5 + 6;
            Console.WriteLine("The outcome of num5 is {0} ", num5);
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            HelloWorld(); // Voer de methode uit
            HelloWorld(); // Voer de methode uit
            var helloWorld = new HelloWorld(); // Instantieer de andere klasse
            helloWorld.SayHello(); // Voer de methode uit
        }

        static void HelloWorld() // Methode
        {
            var a = "Hello ";
            var b = "World!";
            var c = a + b;
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }

    public class HelloWorld // Class
    {
        public HelloWorld() // Constructor
        {
            
        }

        public string a { get; set; } // Property

        public void SayHello() // Methode
        {
            Console.WriteLine("Hello");
        }
    }
}

namespace ProgramFlow
{
    class Looping
    {
        public static Num()
        {
            for (int num = 0; num > 11; num++)
            {
            Console.WriteLine(num);
            }
        }
        public static Count(int count); 
        {
            int[] countless = { 231, 385, 395, 898, 1001 }; 
            foreach(int count in countless)
            {
            Console.WriteLine(count);
            }
        }
    }
}
