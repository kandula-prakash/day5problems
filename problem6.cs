using System;
using System.Collections.Generic;
using System.Text;

namespace day_5_problems
{
    class problem6
    {
        public static void sixthproblem()
        {
            int number1;
            int number2;
            int number3;
            Console.WriteLine("enter the 1st number :");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the 2nd number :");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the 3rd number:");
            number3 = Convert.ToInt32(Console.ReadLine());
            if (number1 > number2)
            {
                if (number1 > number3)
                {
                    Console.WriteLine("the 1st number is the greatest among three.");

                }
                else
                {
                    Console.WriteLine("the 3rd number is the greatest among three.");
                }

            }
            else if (number2 > number3)
            {
                Console.WriteLine("the 2nd numberis the greatest among three.");

            }
            else
                Console.WriteLine("the 3rd number is the greatest among three");

        }
    }
}
