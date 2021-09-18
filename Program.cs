using System;

namespace Day6_Logical_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            Fibonacci_Series.GetFibonacci();
            PerfectNumber.GetPerfectNum();
            PrimeNumber.getPrimeNumber();
            Reverse.getReverse();
            CouponNumbers.getCouponNum();
            Console.ReadKey();
            watch.Stop();
            var time = watch.ElapsedMilliseconds;
            Console.WriteLine("Time taken to execute all the codes is {0} milli-seconds", time);
        }
    }
}
