using System;
namespace test
{
    class Program
    {
        static void Main()
        {
            String[] Cars = { "BMW", "Audi", "Porshe" };
            
            for (int i = 0; i<Cars.Length; i++)
            {
                Console.WriteLine(Cars[i]);
            }
        }
    }
}
