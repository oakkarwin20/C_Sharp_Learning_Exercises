using System;

namespace ArrayChallenge_Brackeys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many siblings do you have?");
            int siblingCount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What are the name of your siblings?");
            string[] siblings = new string[siblingCount];

            for (int i = 0; i < siblings.Length; i++)
            {
                siblings[i] = Console.ReadLine();
            }

            Console.WriteLine("---------------------- \n  we are in Alphabetical order");

            Array.Sort(siblings);

            for (int i = 0; i < siblings.Length; i++)
            {
                int rank = i + 1;
                Console.WriteLine($"{rank}.{siblings[i]}"); 
            }
        }
    }
}
