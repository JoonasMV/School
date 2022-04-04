using System;

namespace poke
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kuinka vanha olet?");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18 && age <= 20)
            {
                Console.WriteLine("Onko papereitä kyllä/ei?");
                char answer = Console.ReadKey().KeyChar;

                if (answer == 'K' || answer == 'k')
                {
                    Console.WriteLine("\nTervetuloa ravintolaan!");
                }
                else
                {
                    Console.WriteLine("\nHyvä yritys!");
                }

            }
            else if (age > 20)
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
