using System;
using System.Collections.Generic;

namespace ListsArrays_Brackeys
{
    class Program
    {
        static void Main(string[] args)
        {
            //when working with arrays, you write ".length" to get the count
            //when working with lsits, you write ".count" to get the count

            List<string> siblings = new List<string>();

            siblings.Add("oak");
            siblings.Add("thuta");
            siblings.Add("nge");
            siblings.Add("ganda");

            for (int i = 0; i < siblings.Count; i++)
            {
                Console.WriteLine(siblings[i]);
            }

            siblings.Remove("nge");
            siblings.RemoveAt(1);

            Console.WriteLine("---------------");

            for (int i = 0; i < siblings.Count; i++)
            {
                Console.WriteLine(siblings[i]);
            }
        }
    }
}
