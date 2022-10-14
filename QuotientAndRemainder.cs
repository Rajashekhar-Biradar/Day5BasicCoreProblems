using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5BasicCoreProblems
{
    public class Quotient_and_Remainder
    {
        public static void CheckQuotientAndRemainder()
        {
            Console.WriteLine("enter the dividend value");
            int dividend= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the divisor value");
            int divisor= Convert.ToInt32(Console.ReadLine());   

            double Quotient= (double)dividend/divisor;
            int Remainder= dividend%divisor;
            Console.WriteLine("Quotient :" + Quotient);
            Console.WriteLine("Remainder :" + Remainder);
        }
    }
}
