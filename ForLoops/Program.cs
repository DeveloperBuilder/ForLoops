using System;

namespace ForLoops
{
    class Program // Class
    {
        static void Main(string[] args) // Methode
        {
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
