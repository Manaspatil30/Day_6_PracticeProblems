using System;
using System.Collections.Generic;
using System.Text;

namespace Day6_Logical_Problems
{
    class PerfectNumber
    {
        public static void GetPerfectNum()
        {
            int number;
            int sum = 0;
            int n;

            Console.WriteLine("Enter the number :");
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
                Console.WriteLine("The entered number is a perfect number");
            }
            else
            {
                Console.WriteLine("The entered number is not a perfect number");
            }
        }
    }
}
