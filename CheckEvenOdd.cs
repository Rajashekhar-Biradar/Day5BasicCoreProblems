using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5BasicCoreProblems
{
    public class CheckEvenOdd
    {
        public static void CheckTheNum()
        {
            Console.WriteLine("enter the number");
            int num=Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("this is even number");
            }
            else
            {
                Console.WriteLine("this is odd number");
            }
        }
    }
}
