using System;
namespace test
{
    class Program
    {
        static void Main()
        {
            bool running = true;

            while (running)
            {
                string bot_pick;
                Console.WriteLine("Rock, paper or scissors?:");
                string user_choice = Console.ReadLine();
                user_choice = user_choice.ToUpper();
                while (user_choice != "ROCK" && user_choice != "PAPER" && user_choice != "SCISSORS")
                {
                    Console.WriteLine("Rock, paper or scissors?:");
                    user_choice = Console.ReadLine();
                    user_choice = user_choice.ToUpper();
                }



                Random random = new Random();
                int bot_choice = random.Next(1, 4);

                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Your pick:" + user_choice);
                switch (bot_choice)
                {
                    case 1:
                        bot_pick = "rock";
                        Console.WriteLine("Bot pick: " + bot_pick);
                        break;

                    case 2:
                        bot_pick = "paper";
                        Console.WriteLine("Bot pick: " + bot_pick);
                        break;
                    case 3:
                        bot_pick = "scissors";
                        Console.WriteLine("Bot pick: " + bot_pick);
                        break;
                }


                if (bot_choice == 1 && user_choice == "SCISSORS")
                {
                    Console.WriteLine("You lose!");
                }
                else if (bot_choice == 1 && user_choice == "PAPER")
                {
                    Console.WriteLine("You win!");
                }
                else if (bot_choice == 2 && user_choice == "ROCK")
                {
                    Console.WriteLine("You lose!");
                }
                else if (bot_choice == 2 && user_choice == "SCISSORS")
                {
                    Console.WriteLine("You win!");
                }
                else if (bot_choice == 3 && user_choice == "PAPER")
                {
                    Console.WriteLine("You lose!");
                }
                else if (bot_choice == 3 && user_choice == "ROCK")
                {
                    Console.WriteLine("You win!");
                }
                else
                {
                    Console.WriteLine("It's a tie");
                }
                Console.WriteLine("---------------------------------------");
            }
        }
    }
}
