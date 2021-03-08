using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 6;
            bool divisibleByTwo = a % 2 == 0;
            bool divisibleByThree = a % 3 == 0;

            if(divisibleByTwo)
            {
                Console.WriteLine(a + " is divisible by 2");
            }
            else if(divisibleByThree)
            {
                Console.WriteLine(a + " is divisible by 3");
            }
            else
            {
                Console.WriteLine(a + "is not divisible by 2 or 3");
            }


            //random number
            Random random = new Random();
            a = random.Next() % 5;
            Console.WriteLine("Random number generated: " + a);
            switch(a)
            {
                case 0:
                    Console.WriteLine("case 0");
                    break;
                case 1:
                    Console.WriteLine("case 1");
                    break;
                case 2:
                    Console.WriteLine("case 2");
                    break;
                default:
                    Console.WriteLine("default case");
                    break;
            }

        }
    }
}
