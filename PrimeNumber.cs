using System;
using System.Collections.Generic;
using System.Text;

namespace Day6_Logical_Problems
{
    class PrimeNumber
    {
        public static void getPrimeNumber()
        {
            Console.WriteLine("Enter the number to check Prime");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            int b = 0;

            a = n / 2;

            for(int i = 2; i <= a; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("It is not a prime number");
                    b = 1;
                }
            }

            if (b == 0)
            {
                Console.WriteLine("It is a prime number");
            }

        }
    }
}
