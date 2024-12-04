using System;

namespace Progtetel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 7, 2, -4, 5, 12, 1 };

            //Párosok kiválogatása - 1

            //Maximum kiválasztás - 2

            int maxe = 0;
            for (int i = 1; i < x.Length; i++)
            {
                if (x[i] > maxe)
                {
                    maxe = x[i];
                }
            }
            Console.WriteLine($"A tömb maximuma {maxe}");
        }
    }
}
