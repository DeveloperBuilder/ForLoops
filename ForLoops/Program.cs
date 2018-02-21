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
            Console.WriteLine("The outcome of num5 is {0} ", num5 + "\n");
            for (int i = 2; i <= 6; i = i + 2)
            {
                Console.WriteLine("The outcome of i is " + (i + 2));
            }
            String name = "John";
            int age = 20;
            Person person = new Person(name, age); // create an object
            person.SayHello(); // invoke the method
            person.ChangeName();
            person.ChangeAge();
            person.Display(); // invoke the method
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

    class Person // Class
    {
        //Properties
        String name;
        int age;

        // constructor with name and age parameters
        public Person(String name, int age) // Constructor
        {
            this.name = name;
            this.age = age;
        }

        ~Person()
        {
            this.name = null;       // deconstructor body
            this.age = 0;
        }

        // appends String to the name
        public void ChangeName()
        {
            name = name + ", the rockstar!";
        }

        // change the age
        public void ChangeAge()
        {
            age = age + 100;
        }

        // display the new name and age values
        public void Display()
        {
            Console.WriteLine("Your new name is: " + name);
            Console.WriteLine("Your new age is: " + age + "\n" );
        }

    public string a { get; set; } // Property

        public void SayHello() // Methode en/of declare a method
        {
            Console.WriteLine("\n" + "Using method SayHello: " + "Hello" + "\n");
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

