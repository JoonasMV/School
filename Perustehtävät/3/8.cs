using System;

namespace TuntiTH
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna kanta");
            int ka = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Anna korkeus");
            int ko = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < ko; i++)
            {
                for (int j = 0; j < ka; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}
