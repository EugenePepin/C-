using System;

namespace Lab2ex1
{
    class Program
    {     
           static void Main(string[] args)
            {
                while (true)
                {
                    Console.Write("Виберiть дiю: \n" +
                    "1 - ввести номер, щоб вивести прiзвище та iм'я за списком \n" +
                    "2 - вийти з програми \n" +                 
                    "Ваша вiдповiдь: ");
                try
                {
                    int choose = int.Parse(Console.ReadLine());

                    if (choose == 1)
                    {

                        Console.Write("Введiть номер: ");
                        int number = int.Parse(Console.ReadLine());
                        switch (number)
                        {
                            case 1:
                                Console.Write("\nБелiч Олександр\n\n"); continue;
                            case 2:
                                Console.Write("\nГлинський Петро\n\n"); continue;
                            case 3:
                                Console.Write("\nГригоращук Олександр\n\n"); continue;
                            case 4:
                                Console.Write("\nIсопеску Михайло\n\n"); continue;
                            case 5:
                                Console.Write("\nКожокар Дiана\n\n"); continue;
                            case 6:
                                Console.Write("\nНяйко Андрiй\n\n"); continue;
                            case 7:
                                Console.Write("\nПепiн Євгенiй\n\n"); continue;
                            case 8:
                                Console.Write("\nСофронiй Михайло\n\n"); continue;
                            case 9:
                                Console.Write("\nТопало Василь\n\n"); continue;
                            default:
                                Console.Write("\nПрiзвища за таким номером у групi не iснує\n\n"); continue;

                        }


                    }
                    if (choose == 2)
                    {
                        break;
                    }
                    else if (choose != 1 || choose != 2)
                    {
                        continue;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nВводити можна лише числа \n");
                    continue;
                }
            }
            }
        }
    }
