using System;

namespace Lab3ex1
{
    class Program
    {
        //метод для виведення малих літер
        public static string LettersToLower(string text)
        {
            int count = 0;
            for (int i = 0; i < text.Length; i++) {
                if (char.IsUpper(text[i]))
                {
                    count++;
                }
        }
            if (count != 0)
            {
                string newtext = text.ToLower();
                return "\n Ваш текст, в якому великi лiтери замiненi на вiдповiднi малi: " + newtext + "\n";


                    }
            else {
                return "\n В тектi немає великих лiтер\n";
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                try
                {


                    // меню 

                    Console.Write(" Виберiть дiю: \n" +
                    " 1 - ввести текстовий рядок \n" +
                    " 2- вийти з програми \n" +
                    "\n Ваша вiдповiдь: ");

                    int choose = int.Parse(Console.ReadLine());


                    if (choose == 1)
                    {
                        int letcount = 0;
                        Console.Write(" Введiть текстовий рядок: ");
                        string text = Console.ReadLine();

                        //виведення замінених літер

                        Console.WriteLine(LettersToLower(text));

                        //конструкція для визначення парних літер 

                        string[] words = text.Split(new[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (string word in words)
                        {
                            if (word.Length % 2 == 0)
                            {
                                letcount++;
                            }
                        }
                        if (letcount == 0)
                        {
                            Console.WriteLine("\n В текстi немає парних лiтер");
                        }
                        else
                        {
                            Console.WriteLine(" Слова, що мають парну кiлькiсть лiтер: ");
                            foreach (string word in words)
                            {
                                if (word.Length % 2 == 0)
                                {
                                    Console.Write(" " + word + " ");
                                }

                            }
                        }
                        Console.Write("\n\n");
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
                catch (Exception)
                {
                    Console.WriteLine("\n Вводити можна лише числа \n");
                    continue;
                }
            }
        }




    }

}
