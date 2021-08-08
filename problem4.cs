using System;
using System.Collections.Generic;
using System.Text;

namespace day_5_problems
{
    class problem4
    {
        public static void fourthproblem()
        {
            int i;
            Console.WriteLine("enter a number :");
            i = int.Parse(Console.ReadLine());
            if (i % 2 ==0)
            {
                Console.WriteLine("entered number is even number");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("entered number is odd number");
                Console.ReadLine();
            }
        }
    }
}
