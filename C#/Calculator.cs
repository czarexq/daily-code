using System;
namespace test
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Jaką operację chcesz zrobić?" +
                "\n1. Mnożenie (*)" +
                "\n2. Dzielenie (/)" +
                "\n3. Dodawanie (+)" +
                "\n4. Odejmowanie (-)" +
                "\nNapisz symbol operacji którą chcesz wykonać:");
            char choice = char.Parse(Console.ReadLine());

            Console.WriteLine("Podaj pierwszą liczbę:");
            double first_num = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę:");
            double second_num = double.Parse(Console.ReadLine());

            if (choice == '*')
            {
                Console.WriteLine($"Wynik: {first_num} * {second_num} = {first_num * second_num}");
            }
            else if (choice == '/')
            {
                Console.WriteLine($"Wynik: {first_num} / {second_num} = {first_num / second_num}");
            }
            else if (choice == '+')
            {
                Console.WriteLine($"Wynik: {first_num} + {second_num} = {first_num + second_num}");
            }
            else if (choice == '-')
            {
                Console.WriteLine($"Wynik: {first_num} - {second_num} = {first_num - second_num}");
            }
        }
    }
}