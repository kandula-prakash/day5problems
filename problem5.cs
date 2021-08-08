using System;
using System.Collections.Generic;
using System.Text;

namespace day_5_problems
{
    class problem5
    {
        public static void fifthProblem()
        {
            char ch;
            Console.WriteLine("enter any character :");
            ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'a' || ch == 'é' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U') 
            {
                Console.WriteLine(ch + " is voewl. ");

            }
            else if ((ch >='a' && ch <='z' )||(ch >='A' && ch <='Z'))
            {
                Console.WriteLine(ch + "is Consonant.");

            }
            Console.ReadLine();
        }
    }
}
