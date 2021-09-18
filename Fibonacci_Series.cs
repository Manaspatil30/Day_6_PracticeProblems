using System;
using System.Collections.Generic;
using System.Text;

namespace Day6_Logical_Problems
{
    class Fibonacci_Series
    {
        public static void GetFibonacci()
        {
            Console.WriteLine("Enter the number untill which the fibonacci series is to be generated");
            int n;
            n = Convert.ToInt32(Console.ReadLine());

            int a = 0;
            int b = 1;
            int i = 2;

            while (i < n)
            {
                i = i + 1;
                int c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }
        }
    }
}
