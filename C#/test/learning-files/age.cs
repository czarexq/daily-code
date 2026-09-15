using System;
namespace test
{
    class Programs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your name");
            string name = Console.ReadLine();
            Console.WriteLine("Write your age");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Hii {name}, to 100 years old left you {100 - age} years!");
            if (age % 2 == 0)
            {
                Console.WriteLine("Fun fact: Your age is even numnber");
            }

        }

    }
}