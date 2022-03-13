using System;

namespace Lab2ex3
{
    public class Program
    {

        //визначення номеру мінімального елементу

        public static int MinNumMas(int[] mas)
        {
            int min = mas[0];
            int index = 0;
            for (int i = 0; i < mas.Length; i++)

                if (min > mas[i])
                {
                  
                    min = mas[i];

                    index = i;
                    
                }
            
                return index + 1;
            
        }

        //добуток елементів масиву розташованих до першого нульового елемента

        public static int PlurToZero(int[] mas)
        {
            int plur = 1;
            int indexZero = 0,count=0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] == 0)
                {
                    indexZero = i;
                    count++;
                }

            }
            for (int i = 0; i <indexZero; i++)
            {
                plur *= mas[i];
            }

            if (indexZero == 0)
            {
                Console.WriteLine(" В масивi немає нульових елементiв, або нульовий елемент перший в масивi\n");
                return -2;
            }
            if(count >= mas.Length)
            {
                Console.WriteLine(" В масивi присутнi лише нулi\n");
                return -1;
            }
            else
            {
                return plur;
            }

        }

      

        //основна програма
        static void Main(string[] args)
        {
            while (true)
            {


                // меню 

                Console.Write(" Виберiть дiю: \n" +
                " 1 - ввести одновимiрний масив n цiлих чисел \n" +
                " 2 - заповнити масив n цiлих чисел значеннями за допомогою генератора псевдовипадкових чисел з вiдрiзка [-100; 100] \n" +
                " 3- вийти з програми \n" +
                "\n Ваша вiдповiдь: ");
                try
                {
                    int choose = int.Parse(Console.ReadLine());

                    //введення масиву з клавіатури 

                    if (choose == 1)
                    {
                        Console.Write("\n Введiть довжину масиву n: ");
                        int n = int.Parse(Console.ReadLine());
                        Console.Write("\n");

                        if (n <= 0)
                        {
                            Console.WriteLine(" Довжина масиву не може бути меншою за 1");
                            continue;
                        }

                        int[] mas = new int[n];
                        for (int i = 0; i < n; i++)
                        {
                            Console.Write(" Введiть " + (i + 1) + " елемент масиву: ");
                            mas[i] = int.Parse(Console.ReadLine());

                        }

                        //виведення масиву та результати 

                        Console.Write("\n Введений масив : {");
                        for (int i = 0; i < n; i++)
                        {
                            Console.Write(" " + mas[i]);
                        }
                        Console.Write(" }\n\n\n");

                        
                        Console.WriteLine(" Номер мiнiмального елементу масива : " + MinNumMas(mas) + "\n");
                       
                        int plur = PlurToZero(mas);
                        if (plur != -2 && plur !=-1)
                        {
                            Console.Write(" Добуток елементiв масиву, розташованих до першого нульового елемента - " + PlurToZero(mas) + "\n\n");
                        }


                    }

                    //введення масиву за допомогою генератора псевдовипадкових чисел

                    if (choose == 2)
                    {
                        Console.Write("\n Введiть довжину масиву n: ");
                        int n = int.Parse(Console.ReadLine());
                        Console.Write("\n");

                        if (n <= 0)
                        {
                            Console.WriteLine(" Довжина не може бути меншою за 1");
                            continue;
                        }
                        int[] mas = new int[n];
                        Random rand = new Random();
                        for (int i = 0; i < mas.Length; i++)
                            mas[i] = rand.Next(-100, 100);

                        //виведення масиву та результати 

                        Console.Write("\n Введений масив : {");
                        for (int i = 0; i < n; i++)
                        {
                            Console.Write(" " + mas[i]);
                        }
                        Console.Write(" }\n\n\n");

                        
                        Console.WriteLine(" Номер мiнiмального елементу масива : " + MinNumMas(mas) + "\n");
                       
                        int plur = PlurToZero(mas);
                        if (plur != -2)
                        {
                            Console.Write(" Добуток елементiв масиву, розташованих до першого нульового елемента - " + PlurToZero(mas) + "\n\n");
                        }


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