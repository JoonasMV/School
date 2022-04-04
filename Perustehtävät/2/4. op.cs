using System;

namespace poke
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Montako opintopistettä sait tänä vuonna?");
            int op = Convert.ToInt32(Console.ReadLine());

            if (op < 45)
            {
                Console.WriteLine("Mee töihin t. Kela");
                Console.WriteLine("Aina saa hävetä t. Ope"); 
            }
            else if (op < 55) 
            {
                Console.WriteLine("En etykkää tästä t. Ope");
            }
            else
            {
                Console.WriteLine("Jatka samaan malliin!");
            }
        }
    }
}
