using System;

namespace kt._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mika on nimesi?");
            string name = Console.ReadLine();

            Console.WriteLine("Kuinka vanha olet?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Mika on äitisi nimi?");
            string momName = Console.ReadLine();

            Console.WriteLine("Kuinka vanha hän on?");
            int momAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(name +" on "+ (momAge-age)+"v. nuorempi kuin äitinsä "+ momName);        

        }
    }
}
