using System;

namespace th6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna 10 numeroa.");

            int[] luvut = new int[10];

            for (int i = 0; i < 10; i++)
            {
                luvut[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Numerosi käänteisessä järjestyksessä");

            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine(luvut[i]);            
            }

        }
    }
}
