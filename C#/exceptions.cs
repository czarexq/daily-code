using System;
namespace test
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Write first number:");
                int num_1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Write second number:");
                int num_2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num_1 / num_2);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("You can't divide by 0!");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Type only int numbers!");
            }
            catch (Exception e)
            {
                Console.WriteLine("There was some error!");
            }

        }
    }
}