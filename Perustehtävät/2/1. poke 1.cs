using System;

namespace poke
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kuinka vanha olet?");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("Tervetuloa ravintolaan!");
            }
            else
            {
                Console.WriteLine("Mene kotiin kasvamaan!");
            }
        }
    }
}
