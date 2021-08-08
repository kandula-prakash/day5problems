using System;
using System.Collections.Generic;
using System.Text;

namespace day_5_problems
{
    class problem9
    {
        public static void powerOf2()
        {
            int i;
            Console.WriteLine("enter the number");
            i = int.Parse(Console.ReadLine());
            if (0 < i)
            {
                Console.WriteLine("value of i should be 0 <= i<31 ");

            }
            else if (i<31)
            {
                int n = 0;
                while (n <=i)
                {
                    n++;
                    double table = Math.Pow(2, n);
                    Console.WriteLine("2^i= " +table);

                }

            }
        
        else
	{
             Console.WriteLine("value of n should be 0 <= i<31 ");
	}
    }
}
}
