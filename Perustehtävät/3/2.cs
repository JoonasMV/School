using System;

namespace th3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            int rnd = rng.Next(1, 101);

            int arvaus = -1;

            Console.WriteLine("Arvaa numero");

            while (rnd != arvaus)
            {
                arvaus = Convert.ToInt32(Console.ReadLine());

                if (arvaus < rnd)
                    Console.WriteLine("Arvasit liian vähän\n");
                else (arvaus > rnd)
                    Console.WriteLine("Arvasit liian paljon\n");
            }
            Console.WriteLine("\nOikein meni numero oli "+rnd);
            
        }
    }
}
