using System;
using System.Collections.Generic;
using System.Text;

namespace Day6_Logical_Problems
{
    class Reverse
    {
        public static void getReverse()
        {
            Console.WriteLine("Enter the numer to reverse");

            int num;
            num = Convert.ToInt32(Console.ReadLine());
            int reverse = 0;
            int x;

            while (num != 0)
            {
                x = num % 10;
                reverse = reverse * 10 + x;
                num /= 10;
            }

            Console.WriteLine("The reversed number is :" + reverse);
        }
    }
}
