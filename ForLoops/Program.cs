
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
            RetangleArray.Array();
            Reference reference = new Reference();
            Reference.Concatenate();
            Reference.Trim();
            String name = "John";
            int age = 20;
            HelloWorld();
            Person person = new Person(name, age); // create an object
            person.SayHello(); // invoke the method
            person.ChangeName();
            person.ChangeAge();
            person.Display(); // invoke the method
            ProgramFlow.Looping.Num(); // invoke the method
            ProgramFlow.Looping.Count(); // invoke the method
            ProgramFlow.FlowControl.SwitchStatement();
            ProgramFlow.Looping.WhileLoop();
            ProgramFlow.Looping.DoWhileLoop();
        }

        protected static void HelloWorld() // Method
        {
            var a = "Hello ";       // declare and initialize a data type
            var b = "World!";
            var c = a + b;
            Console.WriteLine("\n" + "Using method HelloWorld: " + c);
            Console.ReadLine();
        }
    }

    class RetangleArray
    {
        public static void Array()
        {
            int[,] numbers = { { 17, 66 }, { 34, 57 } };
            string[,,] names = { { { "Willem", "22", "Road" }, { "Max", "33", "HighWay" }, { "Tommy", "17", "Speed" } } };
            Console.WriteLine($"The outcome of Multidimensional Arrays numbers row 2 and colomn 1 is {numbers[1,0]}");
            Console.WriteLine($"The outcome of Three Arrays names is {names[0,2,2]}");
            numbers[0,1] = 88;
            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();
        }
    }
    class Reference
    {
        internal static void Concatenate()
        {
            string name = "Susan";
            name = name + " Smith";
            Console.WriteLine("\n" + $"Using Concatenate: {name}");
            Console.WriteLine("\n" + $"Using ToUpper: {name.ToUpper()}");
            Console.WriteLine($"Using ToLower: {name.ToLower()}");
            Console.WriteLine($"The lenght of Susan Smith: {name.Length}");
            Console.ReadKey();
        }

        internal static void Trim()
        {
            string str = "      A good programmer looks both ways before crossing a one-way street";
            Console.WriteLine("\n" + $"Without trim: {str}");
            Console.WriteLine($"With trim: {str.Trim()}");
            Console.ReadKey();
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
            Console.WriteLine($"Your new name is: {name}");
            Console.WriteLine($"Your new age is: {age}" + "\n");
        }

        public string a { get; set; } // Property

        public void SayHello() // Methode en/of declare a method
        {
            Console.WriteLine($"\n" + "Using method SayHello: \"Hello\"" + "\n");
        }

    }
}

namespace ProgramFlow
{
    class Looping
    {
        internal static void WhileLoop()
        {
            int count = 0;
            while (count <=5)
            {
                Console.WriteLine($"The value of WhileLoop is {count}");
                count++;
            }
            Console.ReadLine();
        }

        public static void DoWhileLoop()
        {
            int x = 0;
            do
            {
                Console.WriteLine($"The value of DoWhileLoop is {x}");
                x++; 
            }
            while (x <= 5);
            Console.ReadLine();
        }

        public static void Num()
        {
            for (int num = 10; num > -1; num--)
            {
                Console.WriteLine("The outcome of forloop Decrement is " + (num));
            }

            for(int numbs = 0; numbs < 11; numbs++)
            {
                Console.WriteLine($"The outcome of forloop Increment is {numbs}");
            }
            Console.ReadLine();
        }

        public static void Count()
        {
            int[] countless = { 231, 385, 395, 898, 1001 };
            foreach (int count in countless)
            {
                Console.WriteLine("The outcome of foreach is " + (count));
            }
            Console.ReadLine();
        }
    }

    class FlowControl
    {
        public static void SwitchStatement()
        {
            int letter = 300;
            switch (letter)
            {
                case 100: Console.WriteLine("The letter is 100");
                    break;
                case 200: Console.WriteLine("The letter is 200");
                    break;
                case 300: Console.WriteLine("The letter is 300");
                    break;
                case 400: Console.WriteLine("The letter is 400");
                    break;
                default: Console.WriteLine("The letter is beyond our scope");
                    break;
            }
            Console.ReadKey();
        }
    }
}
