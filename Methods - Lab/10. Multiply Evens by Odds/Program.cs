using System;

namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Sumdigits(n);
        }
        static void Sumdigits(int number) 
        {
            int LastDigit = 0;
            int EvenSum = 0;
            int OddSum = 0;
            while (number != 0)
            {
                LastDigit = number % 10;
                number = number / 10;
                if (LastDigit % 2 == 0)
                {
                    EvenSum += LastDigit;
                }
                else
                {
                    OddSum += LastDigit;
                }
            }
            Console.WriteLine(EvenSum * OddSum);
        }
    }
}
