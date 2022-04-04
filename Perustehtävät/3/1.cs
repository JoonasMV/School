using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolmella jaolliset luvut 1-1000 välillä");
            int i = 0;

            while (i<1000)
            {
                if ((i % 3) == 0)
                {
                    Console.WriteLine(i);
                }

                i++;
            }


        }
    }
}
