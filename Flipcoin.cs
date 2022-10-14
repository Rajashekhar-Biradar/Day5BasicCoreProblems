using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    internal class Flipcoin
    {
       

        public static void CheckPerOfFlipcoin()
        {
            Console.WriteLine("enter the number of times to flip coin");
            int n = Convert.ToInt32(Console.ReadLine());
            int Tail=0;
            int Head=0;
            
            for (int i = 0; i < n; i++)
            {
                Random random = new Random();
                double check = random.NextDouble();
               
                if (check < 0.5)
                {
                    Console.WriteLine("Tails");
                    Tail++;
                }
                else
                {
                    Console.WriteLine("Heads");
                    Head++;
                } 

            }
            Console.WriteLine("number of head counts"+ Head);
            Console.WriteLine("number of tails counts"+ Tail);
            //double a = (Head/n)*100;
            //double b = Tail/n*100;
            double a = (Head*100)/n;
            double b = (Tail*100)/n;
            Console.WriteLine("Percentage Of Head is : " + a);
            Console.WriteLine("Percentage Of Tail is : " + b);


        }
           
    }
        
}
