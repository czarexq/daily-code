using System;
namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int computer_choise = rand.Next(1, 10);

            int attempt = 1;

            Console.WriteLine("Guess the number (1-10):");
            int guess = int.Parse(Console.ReadLine());
            Console.WriteLine(computer_choise);
            while (guess != computer_choise)                

                if (guess > computer_choise)
                {
                    Console.WriteLine("Incorect!!!\nAwwwh... too high, try again");
                    guess = int.Parse(Console.ReadLine());
                    
                    attempt += 1;
                }
                else if (guess < computer_choise)
                {
                    Console.WriteLine("Incorect!!!\nAwwwh... too low, try again");
                    guess = int.Parse(Console.ReadLine());
                    attempt += 1;
                }


            Console.WriteLine($"Correct!! You got this at {attempt} attempt!");
        }
    }
}