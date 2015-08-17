using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //printer numbers from 1 - 100
            for (int i = 1; i <= 100; i++)
            {
                //If Divisable by 3 and 5 print Fizz Buzz
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine("Fizz Buzz");
                }//IF Divisable by 3 print Fizz
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }//If Divisable by 5 print Buzz
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                } //Printer number if not diviable by 3 or 5
                else Console.WriteLine(i);
                
            }
            /*
            for (int i = 1; i <= 100; i++)
            {

                string results = "";
                //IF Divisable by 3 print Fizz
                if (i % 3 == 0) results = "Fizz ";
                //If Divisable by 5 print Buzz
                if (i % 5 == 0) results = results + "Buzz";
                //If Divisable by 3 and 5 print Fizz Buzz
                //Printer number if not diviable by 3 or 5
                if (results.Length == 0) results = i.ToString();

                Console.WriteLine(results);
            }*/
        }
    }
}
