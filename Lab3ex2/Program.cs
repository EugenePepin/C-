using System;
using System.IO;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab3ex2
{

    class Program
    {
        //Метод для кількості слів
        public static int CountLetter (string text)
        {
            int wordcount = 0;
            string word = Regex.Match(text, @"^[^0-9]*").Value;
            for (int i = 0; i < word.Length; i++)
            {
                if (word.Substring(i, 1) != " ")
                {
                    wordcount++;
                }
            }
            return wordcount;
        }

        //Метод для віку + 10
        public static int Age (string text)
        {
            string outputnumber = "";
            foreach (char i in text)
            {
                if (char.IsDigit(i))
                {
                    outputnumber += i;
                }

            }
            int output = 0;
            output = Convert.ToInt32(outputnumber);
            output = output + 10;
            return output;
        }


        static async Task Main(string[] args)
        {
            while (true)
            {
                try
                {


                    // меню 

                    Console.Write(" Виберiть дiю: \n" +
                    " 1 - Визначити кiлькiсть лiтер у введеному словi, вивести своє прiзвище \n " +
                    "у зворотному порядку в стовпець та до вiку додати число 10 \n" +
                    " 2 - вийти з програми \n" +
                    "\n Ваша вiдповiдь: ");

                    int choose = int.Parse(Console.ReadLine());


                    if (choose == 1)
                    {


                        string Zavd2 = "E://Zavd2.txt";

                        using (StreamReader reader = new StreamReader(Zavd2))
                        {
                            

                            string text = await reader.ReadToEndAsync();
                            Console.WriteLine("\n Введений текст у файлi: " + text + "\n");

                            //Виведення кількості слів 

                            Console.WriteLine(" Кiлькiсть слiв у файлi: "+ CountLetter(text)+ "\n");


                            //Виведення реверсивного тексту в стовпець

                            string reverse = Regex.Match(text, @"^[^0-9]*").Value; ;
                            char[] sReverse = reverse.ToCharArray();
                            reverse.Substring(reverse.IndexOf(' '));
                            Array.Reverse(sReverse);
                            reverse = new string(sReverse);
                            Console.WriteLine(" Реверсивний текст в стовпець:");
                            foreach (var b in reverse.ToCharArray())
                            {
                                Console.WriteLine("  " + b.ToString());
                            }

                            //Виведення віку + 10

                            Console.WriteLine("\n Вiк + число 10 - " + Age(text) + "\n");

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
                }
                catch (FormatException)
                {
                    Console.WriteLine("\n Вводити можна лише числа \n");
                    continue;
                }
            }
        }
    }
}




    


