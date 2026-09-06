using System;
namespace test
{
    class Program
    {
        static void Main()
        {
            string name = "Adam";
            uint age = 16;
            Console.WriteLine("Hello Adam! It's your birthday!!");
            SingHappyBirthday(name, age);

        }

        static void SingHappyBirthday(string name, uint age)
        {
            Console.WriteLine("Happy Birthday to YOU!");
            Console.WriteLine("Happy Birthday to " + name + "!");
            Console.WriteLine("Happy Birthday to YOUUU!");
            Console.WriteLine("Happy Birthday to you! You are now " + age + "!");
            Console.WriteLine("");
        }
    }
}