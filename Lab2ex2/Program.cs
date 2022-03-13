using System;

namespace Lab2ex2
{
    class Program
    {
        static void Main(string[] args)
        {

            const int b = 3;
            const double a = -6.75, dx = 0.75;
            while (true)
            {
                double y = 0;

                // меню 

                Console.Write(" Виберiть дiю: \n" +
                " 1 - обчислити за допомогою while \n" +
                " 2 - обчислити за допомогою do-whilee \n" +
                " 3- вийти з програми \n" +
                " Ваша вiдповiдь: ");
                try
                {
                    int choose = int.Parse(Console.ReadLine());

                    //цикл while

                    if (choose == 1)
                    {
                        double x = a;
                        Console.Write("\n Результати обчислення функцiї y=4^x-12*x+e^x на промiжку [-6;3] з кроком 0.75\n\n");
                        Console.Write("\t  x\t\t\t\t    y=f(x)\n\n");
                        while (x < b)
                        {
                            x += dx;
                            y = Math.Pow(x, 4) - (12 * x) + Math.Exp(x);
                            Console.Write("\t{0}\t\t\t\t{1}\t\n\n", x, y);
                        }
                        Console.Write("\n Виконано циклом while\n\n");
                    }

                    //цикл do-while 

                    if (choose == 2)
                    {
                        double x = a;
                        Console.Write("\n Результати обчислення функцiї y=4^x-12*x+e^x на промiжку [-6;3] з кроком 0.75\n\n");
                        Console.Write("\t  x\t\t\t\t     y=f(x)\n\n");
                        do
                        {
                            x += dx;
                            y = Math.Pow(x, 4) - (12 * x) + Math.Exp(x);
                            Console.Write("\t{0}\t\t\t\t{1}\n\n", x, y);
                        } while (x < b);
                        Console.Write("\n Виконано циклом do-while\n\n");
                    }

                    if (choose == 3)
                    {
                        break;
                    }
                    else if (choose != 1 || choose != 2)
                    {
                        continue;
                    }
                }

                // перевірка на введення тексту

                catch (FormatException)
                {
                    Console.WriteLine("\n Вводити можна лише числа \n");
                    continue;
                }
            }
        }
    }
}