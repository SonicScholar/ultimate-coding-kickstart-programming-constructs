using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsLab
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string[] fruits = new string[] { "apple", "banana", "kiwi", "grapefruit", "orange", "pineapple" };

            try
            {
                bool contains;
                string fruit;

                //1. this works
                fruit = "grapefruit";
                contains = ContainsString(fruits, fruit);
                FormatAndPrintMessage(fruit, contains);

                //2. this works
                fruit = "BANANA";
                contains = ContainsString(fruits, fruit);
                FormatAndPrintMessage(fruit, contains);

                //3. This doesn't work.. fix it!
                //it should print. "The list did not contain the value: lime"
                fruit = "lime";
                contains = ContainsString(fruits, fruit);
                FormatAndPrintMessage(fruit, contains);

                //4. This doesn't work.. fix it!
                //it should print, "The list did not contain the value: (null)"
                fruit = null;
                contains = ContainsString(fruits, fruit);
                FormatAndPrintMessage(fruit, contains);

            }
            catch (Exception e)
            {
                Console.WriteLine("A bug needs to be fixed!\r\n" + e.StackTrace);
                throw;
            }

            Console.WriteLine("Congrats! The program finished without errors!");
            
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        //simple linear search algorithm. contains a bug. find and fix it!
        public static bool ContainsString(string[] array, string value)
        {
            for (int i = 0; i <= array.Length; i++)
            {
                if (array[i].ToLower().Equals(value.ToLower()))
                    return true;
            }
            return false;
        }

        public static void FormatAndPrintMessage(string value, bool contains)
        {
            string s = "The list did ";
            if (!contains)
                s += "not ";

            s += "contain the value: " + value;
            Console.WriteLine(s);
        }
    }
}
