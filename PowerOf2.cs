using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Day5BasicCoreProblems
{
    public class PowerOf2
    {
        public static void PowerOfTwo()
        {
            Console.WriteLine("enter a number");
            
                int num = Convert.ToInt32(Console.ReadLine());
                

            if (num > 31)
            {
                Console.WriteLine("enter valid number");
            }
            else
            {
                for (int i = 0; i <= num; i++)
                {
                    
                    Console.WriteLine("Power of two is : "+ Math.Pow(2,i));   
                }
                
            }
            

           
              
            
            
        }
    }
}
