using System;

namespace test
{
    class Program
    {
        static void Main()
        {
            int[,] block = {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9 }
            };

            for (int i =0; i<block.GetLength(0);i++)
            {
                for (int j = 0; j < block.GetLength(1); j++)
                {
                    Console.Write(block[i, j]);
                }
                Console.WriteLine("");
            }
            int result = 0;
            for (int i = 0; i<block.GetLength(0); i++)
            {
                result += block[i, i];
            }
            Console.WriteLine(result);
        }
    }
}
