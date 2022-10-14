using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5BasicCoreProblems
{
    internal class Swap
    {
        public static void SwapTwoNo()
        {
            //without using third variable using * and /
            Console.WriteLine("enter the numbers");
            int a = Convert.ToInt32(Console.ReadLine());    
            int b = Convert.ToInt32(Console.ReadLine());
            
            

            Console.WriteLine("Before swap a= " + a + " b= " + b);
            a = a * b;       
            b = a / b;      
            a = a / b;     
            Console.WriteLine("After swap a= " + a + " b= " + b);

            //without using third variable + nad -
            Console.WriteLine("enter the numbers");
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before swap c= " + c + " d= " + d);
            c = c + d;       
            d = c - d;       
            c = c - d;
            Console.WriteLine("After swap c= " + c + " d= " + d);

            //Using third variable
            Console.WriteLine("enter the numbers");
            int e = Convert.ToInt32(Console.ReadLine());
            int f = Convert.ToInt32(Console.ReadLine());
            int temp = 0;


            Console.WriteLine("Before swap e= " + e + " f= " + f);

            temp = e;
            e = f;
            f = temp;

            Console.WriteLine("After swap e= " + e + " f= " + f);


        }
    }
}
