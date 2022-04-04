using System;

namespace kt._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna ympyrän säde");
            int radius = Convert.ToInt32(Console.ReadLine());

            double pi = Math.PI;

            Console.WriteLine("Ympyrän pinta ala on "+ Math.Round((pi*radius*radius),2)+" pinta-ala yksikköä");
            //Pyöristettynä kahteen desimaaliin
        }
    }
}
