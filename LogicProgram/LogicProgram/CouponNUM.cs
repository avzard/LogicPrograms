using System;

namespace LogicalProblems
{
    internal class CouponNUM
    {
        public void couponnumbers()
        {
            Console.WriteLine("Enter a Number to genrate random numbers till N places ");
            Console.WriteLine("Let N be grater than 5 for 10000 digit Coupon ");
            /*List<int> Coupons = new List<int>();
            Coupons.Add(Convert.ToInt32(Console.ReadLine()));
            Coupons.Add(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine(Coupons.Count);*/

            int Number = Convert.ToInt32(Console.ReadLine());

            int x = 10;
            for (int i = 0; i < Number + 1; i++)
            {
                x = Number * x;

            }
            //Console.WriteLine(x);

            Random flip = new Random();
            int Hot = flip.Next(10000, x);
            Console.WriteLine(Hot);

        }
    }
}