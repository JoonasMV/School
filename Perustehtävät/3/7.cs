using System;

namespace th7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kuinka monta tähteä tulostetaan");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("*");
            }

        }
    }
}
