using System;

namespace _2._1._1_Zadanie_YP
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                double x = 0;
                double y = 0;

                double r1 = 15;
                double r2 = 25;

                x = double.Parse(Console.ReadLine());
                try
                {
                    int result = Convert.ToInt16(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Это не число ");
                }

                y = double.Parse(Console.ReadLine());

                if (x * x + y * y == r1 * r1)
                {
                    Console.WriteLine("На границе");
                }
                else if (x * x + y * y < r1 * r1)
                {
                    Console.WriteLine("Внутри");
                }
                else if (x * x + y * y == r2 * r2)
                {
                    Console.WriteLine("На границе");
                }
                else if (x * x + y * y < r2 * r2)
                {
                    Console.WriteLine("Вне");
                }
                else Console.WriteLine("Внутри");
            }
        }

    }
}

