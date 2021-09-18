using System;
using System.Collections.Generic;
using System.Text;

namespace Day6_Logical_Problems
{
    class CouponNumbers
    {
        public static void getCouponNum()
        {
            Console.WriteLine("Enter the number of coupons to be generated");
            int n = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int num1;
            int coupon;
            
            for (int i =1; i<=n; i++)
            {
                num1 = random.Next(154, 3175);
                coupon = (1782 * num1) % 1000;
                Console.WriteLine("coupon {0}-[{1}]",i,coupon);

            }

        }
    }
}
