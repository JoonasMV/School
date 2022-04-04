using System;

namespace th5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Montako ystävää sinulla on?");
            int n = Convert.ToInt32(Console.ReadLine());

            string[] yst = new string[n];

            Console.WriteLine("Anna ystäviesi nimet:");

            for (int i = 0; i < n; i++)
            {
                yst[i] = Console.ReadLine();
            }

            Console.WriteLine("\nYstäviäsi ovat:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(yst[i]);
            }
        }
    }
}
