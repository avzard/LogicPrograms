using System;
namespace LogicalProblems
{
    public class Perfect
    {
        public bool Factors(int Number, int Potential_Factor)
        {
            if (Number % Potential_Factor == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        internal void Perfectnum()
        {
            int Check = 0;
            Console.WriteLine("Enter the Number you want to Check:  ");
            int Number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < Number / 2; i++)
            {
                if (Factors(Number, i))
                {
                    Check += i;
                }
            }
            if (Check == Number)
            {
                Console.WriteLine(Number + "is a Perfect number ");
            }
            else
            {
                Console.WriteLine(Number + "is not a Perfect number ");
            }
        }
    }
}