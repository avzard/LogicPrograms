using System;
namespace LogicalProblems
{
    class perfect
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Choose a number to go to the respective problem \n ");
            Console.WriteLine("1 for Perfect Number");
            Console.WriteLine("2 for Prime Number");
            Console.WriteLine("3 for Reverse a Number");
            Console.WriteLine("4 for Fibonacci Serese");
            Console.WriteLine("5 for Generating a Coupon Number");
            Console.WriteLine("6 for Stop Watch");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Perfect perfect = new Perfect();
                    perfect.Perfectnum();
                    break;
                case 2:
                    Prime prime = new Prime();
                    prime.Primenum();
                    break;
                case 3:
                    Reverse reverse = new Reverse();
                    reverse.Reversenum();
                    break;
                case 4:
                    Fibonacci FIBO = new Fibonacci();
                    FIBO.FIBONACCI();
                    break;
                case 5:
                    CouponNUM coupon = new CouponNUM();
                    coupon.couponnumbers();
                    break;
                case 6:
                    Stopwatch WATCH = new Stopwatch();
                    WATCH.StopWatchtime();
                    break;

            }
        }
    }
}