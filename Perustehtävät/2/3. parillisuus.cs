using System;

namespace poke
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tarkista luvun parillisuus: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if ((number % 2) == 0)
            {
                Console.WriteLine(number+ " on parillinen");
            }
            else
            {
                Console.WriteLine(number+ " ei ole parillinen");
            }
        }
    }
}
