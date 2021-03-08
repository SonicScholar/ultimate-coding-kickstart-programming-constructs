using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            //assignment
            int a = 8;
            int b = 5;

            // arithmetic
            Console.WriteLine("arithmetic");
            Console.WriteLine(a + b); //13
            Console.WriteLine(a - b); //3
            Console.WriteLine(a * b); //40
            Console.WriteLine(a / b); //1.6 ?
            Console.WriteLine((double)a / 5); //cast to double
            Console.WriteLine(a % b); //1 remainder 3
            Console.WriteLine();

            // concatenation
            string s1 = "hello";
            string s2 = "world";

            Console.WriteLine("concatenation");
            Console.WriteLine(s1 + " " + s2);
            Console.WriteLine();

            // comparison
            Console.WriteLine("comparison");
            Console.WriteLine(1 < 2);
            Console.WriteLine(2 <= 2);
            Console.WriteLine(1.5 > 0);
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
            Console.WriteLine(!(a == b));
            Console.WriteLine('z' > 'm');
            Console.WriteLine();

            // Logic
            Console.WriteLine("logical");
            Console.WriteLine(true && false); //false
            Console.WriteLine(true || false); //true
            Console.WriteLine(true == false); //false
            Console.WriteLine();

            // bitwise logic - use the Calculator App in Programmer Mode!
            Console.WriteLine("bitwise");
            Console.WriteLine(0xFF & 0x7); //0x7
            Console.WriteLine(0x7 | 0xB); //0xF
            Console.WriteLine(0b11 | 0b1011); //15 decimal
            Console.WriteLine(~0xFFFFFF00); //0x000000FF
            Console.WriteLine(~0b11111111111111111111111100000000); //0b11111111 //0xFF //255

            //array access
            int[] numbers = new int[4] { 1, 2, 3, 4 };
            Console.WriteLine("array access");
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[numbers.Length -1]);

        }
    }
}
