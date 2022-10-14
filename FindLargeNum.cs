using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5BasicCoreProblems
{
    internal class FindLargeNum
    {
        public static void CheckLargestNum()
        {
            Console.WriteLine("Enter the three numbers");

            int num1= Convert.ToInt32(Console.ReadLine());
            int num2= Convert.ToInt32(Console.ReadLine());
            int num3= Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine(" {0} : number is greatest among three",num1);
            }else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine(" {0} : number is greatest among three",num2);
            }
            else
            {
                Console.WriteLine(" {0} : number is greatest among three",num3);
            }


        }
    }
}
