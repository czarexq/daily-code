using System;
namespace test
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter todays temperature: ");
            int temperature = Convert.ToInt32(Console.ReadLine());

            string message = (temperature >= 15) ? "It's warm outside!" : "It's cold outside";
            Console.WriteLine(message);

        }
    }
}