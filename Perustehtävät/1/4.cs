using System;

namespace kt._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna nelikulmion kannan pituus");
            int kanta = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Anna nelikulmion korkeus");
            int korkeus = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nelikulmion pinta ala on "+ (kanta*korkeus)+" pinta-ala yksikköä");
        }
    }
}
