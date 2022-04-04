using System;

namespace poke
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = {1,2,3};

            Console.WriteLine("Anna kolme numeroa: ");
            for (int i = 0; i < 3; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            if (num[0] > num[1] && num[0] > num[2])
            {
                Console.WriteLine(num[0]);
            }
            else if (num[1] > num[2])
            {
                Console.WriteLine(num[1]);
            }
            else Console.WriteLine(num[2]);
        }
    }
}
