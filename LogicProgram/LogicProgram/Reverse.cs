using System;

namespace LogicalProblems
{
    public class Reverse
    {
        public void Reversenum()
        {
            Console.WriteLine("Enter a Number: ");
            int Number = Convert.ToInt32(Console.ReadLine());
            int Reversed_Number = 0;

            String Digits = Convert.ToString(Number);

            for (int i = Digits.Length - 1; i >= 0; i--)
            {
                Reversed_Number += (Number % 10) * (int)Math.Pow(10, i);
                Number = Number % 10;

            }
            Console.WriteLine("The REVERSE Number is :  " + Reversed_Number);
        }
    }
}