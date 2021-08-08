using System;
using System.Collections.Generic;
using System.Text;

namespace day_5_problems
{
    class problem7
    {
        public static void harmonicNumber()
        {
            int n, i;
                double sum = 0;
            Console.WriteLine("enter value of n :");
            n = int.Parse(Console.ReadLine());
            for ( i = 1; i <= n; i++)
            {
                Console.WriteLine("1/{0}+ ", i);
                sum += 1 / (float)i;


            }
            Console.WriteLine("sum of series upto {0}terms :{1}", n, sum);
        }
    }
}
