using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgammingProblems
{
    public class PerfectNumber
    {
        public void PerfectNum()
        {
            int number, sum = 0, n;
            Console.Write("enter the Number : \n");
            number = Convert.ToInt32(Console.ReadLine());
            n = number;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == n)
            {

                Console.WriteLine("\n Entered number is a perfect number ");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\n Entered number is not a perfect number");
                Console.ReadLine();
            }
        }
    }
}