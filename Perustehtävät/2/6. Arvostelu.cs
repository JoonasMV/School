using System;

namespace poke
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mitä sait ohjelmointikurssin arvosanaksi?");
            int grade = Convert.ToInt32(Console.ReadLine());

            while (grade >5 || grade <0)
            {
                Console.WriteLine("Mitä saitkaan arvosanaksi?");
                grade = Convert.ToInt32(Console.ReadLine());
            }
            
            if (grade >0 && grade<5)
            {
                switch (grade)
                {
                    case 0:
                        Console.WriteLine("hylätty");
                        break;
                    case 1:
                        Console.WriteLine("tyydyttävä");
                        break;

                    case 2:
                        Console.WriteLine("tyydyttävä");
                        break;

                    case 3:
                        Console.WriteLine("hyvä");
                        break;

                    case 4:
                        Console.WriteLine("hyvä");
                        break;

                    case 5:
                        Console.WriteLine("kiitettävä");
                        break;
                }
            }
        }
    }
}