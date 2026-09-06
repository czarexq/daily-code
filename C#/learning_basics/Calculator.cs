using System;

namespace test
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Which operation do you want to perform?" +
                "\n1. Multiplication (*)" +
                "\n2. Division (/)" +
                "\n3. Addition (+)" +
                "\n4. Subtraction (-)" +
                "\nEnter the symbol of the operation you want to perform:");
            char choice = char.Parse(Console.ReadLine());

            Console.WriteLine("Enter the first number:");
            double first_num = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            double second_num = double.Parse(Console.ReadLine());

            if (choice == '*')
            {
                Console.WriteLine($"Result: {first_num} * {second_num} = {first_num * second_num}");
            }
            else if (choice == '/')
            {
                Console.WriteLine($"Result: {first_num} / {second_num} = {first_num / second_num}");
            }
            else if (choice == '+')
            {
                Console.WriteLine($"Result: {first_num} + {second_num} = {first_num + second_num}");
            }
            else if (choice == '-')
            {
                Console.WriteLine($"Result: {first_num} - {second_num} = {first_num - second_num}");
            }
        }
    }
}
