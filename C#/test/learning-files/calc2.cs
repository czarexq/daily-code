using System;
namespace test
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the first number: ");
            double num_1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the first number: ");
            double num_2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose an operation:\n" +
                "'+' - add\n" +
                "'-' - substract\n" +
                "'*' - multiply\n" +
                "'/' - divide\n");
            char option = Convert.ToChar(Console.ReadLine());

            switch (option)
            {
                case '+':
                    Console.WriteLine($"{num_1} + {num_2} = "+ add(num_1, num_2));
                    break;
                case '-':
                    Console.WriteLine($"{num_1} - {num_2} = " + substract(num_1, num_2));
                    break;
                case '*':
                    Console.WriteLine($"{num_1} * {num_2} = " + multiply(num_1, num_2));
                    break;
                case '/':
                    Console.WriteLine($"{num_1} / {num_2} = " + divide(num_1, num_2));
                    break;
            }

        }

        static double add(double num_1,double num_2)
        {
            double result = num_1 + num_2;
            return result;
        }
        static double substract(double num_1, double num_2)
        {
            double result = num_1 - num_2;
            return result;
        }
        static double multiply(double num_1, double num_2)
        {
            double result = num_1 * num_2;
            return result;
        }
        static double divide(double num_1, double num_2)
        {
            double result = num_1 / num_2;
            return result;
        }

    }
}