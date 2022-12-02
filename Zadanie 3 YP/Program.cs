using System;

namespace Zadanie_3_YP
{
    class Program
    {


        public static void Main(string[] args)
        {
            Console.Write("Введите курс доллара: ");
            double rate = double.Parse(Console.ReadLine());
            Console.WriteLine("\nfor\n");
            for (int i = 5; i <= 120; i += 5)
                Console.WriteLine("{0} долларов - {1} рублей", i, i * rate);
            Console.WriteLine("\nwhile\n");
            int j = 5;
            while (j <= 120)
            {
                Console.WriteLine("{0} долларов - {1} рублей", j, j * rate);
                j += 5;
            }
            Console.WriteLine("\ndo while\n");
            int k = 0;
            do
            {
                k += 5;
                Console.WriteLine("{0} долларов - {1} рублей", k, k * rate);
            }
            while (k < 120);

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
