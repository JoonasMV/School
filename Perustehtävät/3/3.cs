using System;

namespace th3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna 10 kokonaisluku");

            double summa = 0;

            for (int i = 0; i < 10; i++)
            {
                summa += Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Lukujen summa: " + summa);
            Console.WriteLine("Lukujen keskiarvo: " + (summa / 10));

        }
    }
}
