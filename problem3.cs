using System;
using System.Collections.Generic;
using System.Text;

namespace day_5_problems
{
    class problem3
    {
       public static void seventhproblem()
        {
            int value1;
            int value2;
            value1 = 10;
            value2 = 20;
            Console.WriteLine("values before swaping numbers");
            Console.WriteLine(value1.ToString());
            Console.WriteLine(value2.ToString());

            value1 = value1 + value2;
            value2 = value1 - value2;
            value1 = value1 - value2;

            Console.WriteLine("values after swaping numbers");
            Console.WriteLine(value1.ToString());
            Console.WriteLine(value2.ToString());
            Console.ReadLine();

        }
    }
}
