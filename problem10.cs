using System;
using System.Collections.Generic;
using System.Text;

namespace day_5_problems
{
    class problem10
    {
        public static void leapYear()
        {
            int year;
            Console.WriteLine("enter in the yyyy format : ");
            year = int.Parse(Console.ReadLine());
            string yearstg = year.ToString();
            int resultA;
            int resultB;int resultC;
            int A = Math.DivRem(year, 4, out resultA);
            int B = Math.DivRem(year, 100, out resultB);
            int C = Math.DivRem(year, 400, out resultC);

            if (resultB==0&&resultC==0)
            {
                Console.WriteLine(+year+ "is leapYear");

            }
            else if (resultA==0)

            {
                Console.WriteLine(+year + "is leapYear");

            }
        
        else
	{
             Console.WriteLine(+year+ "is not leapYear");
	}
    }
}
}
