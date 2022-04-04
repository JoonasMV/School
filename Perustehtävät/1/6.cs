using System;

namespace kt._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Illallisen kalorit");
            int kcal = Convert.ToInt32(Console.ReadLine());

            double kj = kcal * 4.184;

            Console.WriteLine(kcal+ " kalorin illallinen on "+ kj+ " joulea");
        }
    }
}
