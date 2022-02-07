using System;

namespace Lab1ex2
{
    public class Program
    {
        static public int Example(int N)
        {
            int m = N/60;
            Console.WriteLine( " Кiлькiсть хвилин, що пройшли з початку доби -  " + m.ToString());

            return m;
        }

       
        static void Main(string[] args)
        {
            Console.Write(" Введiть кiлькiсть секунд, якi пройшли з початку доби: ");
            string S1 = Console.ReadLine();
            int N = int.Parse(S1);
            Example(N);
            Console.ReadLine();
        }
    }
}
