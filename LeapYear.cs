using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    internal class LeapYear
    {
        public static void CheckLeapYear()
        {
            Console.WriteLine("Enter the year to check leap year");
            int year =Convert.ToInt32(Console.ReadLine());

            while(year < 1000)
            {
                Console.WriteLine(" enter valid 4 digit number ");
                year = Convert.ToInt32(Console.ReadLine());
            }

            if (year % 4 == 0)
            {
                Console.WriteLine("The year is a Leap year");
            }
            else
            {
                Console.WriteLine("The year is not a Leap year");
            }
        }

        
          

    }
}
