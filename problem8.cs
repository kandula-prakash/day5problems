using System;
using System.Collections.Generic;
using System.Text;

namespace day_5_problems
{
    class problem8
    {
        public static void evenOrOdd()
        {
            int n, i;
            Console.WriteLine("enter the number :");
            n = Convert.ToInt32(Console.ReadLine());
            i = n % 2;


            if (i == 0)
            {
                Console.WriteLine("given number is even");

            }
            else
            {
                Console.WriteLine("given numer id odd");
            }
        }
    }
}

