using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5BasicCoreProblems
{
    public class HarmonicNumber
    {
        public static void Harmonic_num()
        {
            double harmonicSum=0;
            Console.WriteLine("enter the n^th number");
            int num=Convert.ToInt32(Console.ReadLine());

            for (double i = 1; i <= num; i++)
            {
               Console.WriteLine("1/{0}",i);
                harmonicSum += (1/i);
            }
            Console.WriteLine("total harmonic sum : " + harmonicSum);
        }
        
    }
}
