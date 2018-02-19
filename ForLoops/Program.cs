﻿using System;

namespace ForLoops
{
    class Program // Class
    {
        static void Main(string[] args) // Methode
        {
            int num5 = -340;
            num5 = 34 % 5;
            num5 = num5 + 6;
            Console.WriteLine("The outcome of num5 is {0} ", num5 + "\n");
            for (int i = 2; i <= 6; i = i + 2)
            {
                Console.WriteLine("The outcome of i is " + (i + 2));
            }
            HelloWorld(); // Voer de methode uit en/of invoke the method
            HelloWorld(); // Voer de methode uit en/of invoke the method
            var helloWorld = new HelloWorld(); // Instantieer de andere klasse
            helloWorld.SayHello(); // Voer de methode uit en/of invoke the method
            ProgramFlow.Looping.Num(); // invoke the method
            ProgramFlow.Looping.Count(); // invoke the method
        }

        static void HelloWorld() // Method
        {
            var a = "Hello ";       // declare and initialize a data type
            var b = "World!";
            var c = a + b;
            Console.WriteLine("\n" + "Using method HelloWorld: "+ c);
            Console.ReadLine();
        }
    }

    public class HelloWorld // Class
    {
        public HelloWorld() // Constructor
        {

        }

        ~HelloWorld()
        {
                            // deconstructor body
        }

        public string a { get; set; } // Property

        public void SayHello() // Methode en/of declare a method
        {
            Console.WriteLine("Using method SayHello: " + "Hello" + "\n");
        }

    }
}

namespace ProgramFlow
{
    class Looping
    {
        public static void Num()
        {
            for (int num = 0; num < 11; num++)
            {
            Console.WriteLine("The outcome of forloop is " + (num));
            }
            Console.ReadLine();
        }

        public static void Count()
        {
            int[] countless = { 231, 385, 395, 898, 1001 };
            foreach(int count in countless)
            {
            Console.WriteLine("The outcome of foreach is " + (count));
            }
            Console.ReadLine();
        }
    }
}

