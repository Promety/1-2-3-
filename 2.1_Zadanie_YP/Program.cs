    using System;

    namespace _2._1_Zadanie_YP
    {
        class Program
        {
            static void Main(string[] args)
            {
            int m;
            int k;
                Console.Write("Введите номер масти: ");
            while (!int.TryParse(Console.ReadLine(), out m) || m < 1 || m > 4)
                Console.WriteLine("Ошибка! Введите число от 1 до 4");
            
            Console.Write("Введите номер карты: ");
            while (!int.TryParse(Console.ReadLine(), out k) || k < 6 || k > 14)
                Console.WriteLine("Ошибка! Введите число от 6 до 14");
            
                switch (k)
                {
                    case 6: { Console.Write("Шестерка "); break; }
                    case 7: { Console.Write("Семерка "); break; }
                    case 8: { Console.Write("Восьмерка "); break; }
                    case 9: { Console.Write("Девятка "); break; }
                    case 10: { Console.Write("Десятка "); break; }
                    case 11: { Console.Write("Валет "); break; }
                    case 12: { Console.Write("Дама "); break; }
                    case 13: { Console.Write("Король "); break; }
                    case 14: { Console.Write("Туз "); break; }
                }
                switch (m)
                {
                    case 1: { Console.Write(" Пики"); break; }
                    case 2: { Console.WriteLine("Буби"); break; }
                    case 3: { Console.WriteLine("Черви"); break; }
                    case 4: { Console.WriteLine("Крести"); break; }
                }
                Console.ReadLine();
            }
        }
    }


