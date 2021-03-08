using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsLab
{
    class Program
    {
        static void Main(string[] args)
        {

            int r = 0;
            Random random = new Random();
            while(r < 5)
            {
                //pick a number between 0 and 10
                r = random.Next(0, 10);
                Console.WriteLine("random number: " + r);
            }


            string[] words = { "this", "is", "an", "array", "of", "strings" };
            Console.WriteLine("for loop");
            for(int i=0; i<words.Length; i++)
            {
                string word = words[i];
                Console.Write(word + " ");
            }
            Console.Write("\n\n"); //2 new line characters


            foreach (var word in words)
            {
                if(word.Equals("is"))
                {
                    Console.Write("definitely is ");
                    continue;
                }
                else if (word.Equals("array"))
                {
                    Console.Write("amazing loop structure!");
                    break;
                }
                Console.Write(word + " ");
            }

        }
    }
}
