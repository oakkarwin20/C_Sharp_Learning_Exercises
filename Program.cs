using System;

namespace BasicMathGameChallenge_Brackeys
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer1;
            int answer2;

            //Question 1 
            int a = 10 + 15 + 20;

            //Question 2
            int b = 2 + 4 * 8;

            //response from player
            string response;

            Console.WriteLine($"Hi, Welcome to Oakkar's math game!\n IF YOU ARE READY TO PLAY THIS GAME SAY 'YESSIR'! ");
            response = Console.ReadLine();

            if (response == "YESSIR")
            {
                Console.WriteLine("THAT'S THE ENERGY I NEED!");
            }

            else
            {
                Console.WriteLine("You're no fun, as punishment, you have to do math exercises now!");
            }

            Console.WriteLine($"Perfect! \n Lets start with QUESTION 1\n What is 10 + 15 + 20?");
            answer1 = Convert.ToInt32(Console.ReadLine() );

            if (a == answer1)
            {
                Console.WriteLine("CONGRATS! YOUR ANSWER IS CORRECT!"); 
            }

            else
            {
                Console.WriteLine("Sorry, that's the wrong asnwer.");
            }

            Console.WriteLine($"Now moving onto QUESTION 2! \n What is 2 + 4 * 8?");
            answer2 = Convert.ToInt32(Console.ReadLine());

            if (answer2 == b)
            {
                Console.WriteLine("CONGRATS! YOU GOT THE RIGHT ANSWER AGAIN!");
            }

            else
            {
                Console.WriteLine("Unfortunately, that's not the right answer :(");
            }

            Console.WriteLine("THAT'S ALL THE QUESTIONS I HAVE FOR NOW. THANKS FOR COMING TO PLAY! \n BYE AND REMEMBER TO ALWAYS KEEP PRACTICING YOUR MATH SKILLS!");

        }
    }
}
