using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
     
        static void Main(string[] args)
        {
            Console.Write("El número máximo es {0}", getMax());
            Console.ReadKey();
        }

       static double getMax()
        {
            int[] nums = { 1, 2, 5, 4, 0, 3,9 };
            Double max_num = Double.NegativeInfinity;

            foreach (var n in nums)
            {
                if (n > max_num)
                    max_num = n;
            }

            return max_num;
        }

    }

}









