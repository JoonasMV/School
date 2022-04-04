using System;

namespace th4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Monenko luvun summa ja keskiarvo?");
            int n = Convert.ToInt32(Console.ReadLine());

            double summa = 0;

            for (int i = 0; i < n; i++)
            {
                summa += Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("\nLukujen summa: " + summa);
            Console.WriteLine("Lukujen keskiarvo: " + (summa / n));

        }
    }
}
