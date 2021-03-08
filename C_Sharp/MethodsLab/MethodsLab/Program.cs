using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] years = new int[] { 1900, 1994, 2000, 2004, 2017 };

            //example code
            foreach(int year in years)
            {
                bool yearIsEven = IsEven(year);
                if(yearIsEven)
                    Console.WriteLine(year + " is an even year.");
                else
                    Console.WriteLine(year + " is an odd year.");
            }


            //mini lab assignment
            //write a method to determine which of these numbers are leap years
            //It should be called "IsLeapYear", return a boolean, and take an int parameter
            //hint: use the IsEven method below to help

            //to determine a leap year is as follows:
            //All years divisible by 4 are leap years,
            //EXCEPT for those that are also divisible by 100.
            //However, if the year is divisible by 400, then it's a leap year again!
            
            //example program output:
            //1900 is not  leap year
            //1994 is a leap year
            //2000 is a leap year
            //2017 is not a leap year
            //...
            //...


            foreach(int year in years)
            {

                Console.WriteLine();
            }


        }

        public static bool IsEven(int year)
        {
            return year % 2 == 0;
        }
    }
}
