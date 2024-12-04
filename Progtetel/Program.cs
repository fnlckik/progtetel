using System;

namespace Progtetel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 7, 2, -4, 5, 12, 1 };

            //Párosok kiválogatása - 1
            int[] parosak = new int[100];
            int db = 0;
            int i;
            for (i = 0; i < x.Length; i++)
            {
                if (x[i] % 2 == 0)
                {
                    parosak[db] = x[i];
                    db++;
                }
            }
            for (i = 0; i < db; i++)
            {
                Console.Write(parosak[i] + " ");
            }
            Console.WriteLine();

            //Maximum kiválasztás - 2
        }
    }
}
