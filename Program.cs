using System;

namespace WhileLoopsChallenge_Brackeys_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numberGen = new Random();

            int roll1 = 0;
            int roll2 = 0;
            int attempt = 0;

            Console.WriteLine("Press Enter to roll the dice");

            while (roll1 + roll2 != 12)
            {
                Console.ReadKey();

                roll1 = numberGen.Next(1, 7);
                roll2 = numberGen.Next(1, 7);
                Console.WriteLine($"You rolled a {roll1} and a {roll2}");
                attempt++;
            }

            Console.WriteLine($"It took you {attempt} attempts to roll a perfect tweleve!!! \n Good Job :)");
        }
    }
}
