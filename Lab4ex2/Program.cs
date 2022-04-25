using System;
using System.Collections;
using System.IO;
namespace Lab4ex2
{
    class Program
    {
        public static ArrayList ReadFromFile(string path)
        {
            ArrayList list = new ArrayList();
            string line;
            StreamReader reader = File.OpenText(path);

            while ((line = reader.ReadLine()) != null)
            {
                string[] s = line.Split(new string[]
                {
                    "Прiзвище: ", ", Номер групи: ", ", Оцiнка з математики: ", ", Оцiнка з ТСПП: ", ", Оцiнка з ООП: "
                }, 5, StringSplitOptions.RemoveEmptyEntries);
                list.Add(new Student(s[0], int.Parse(s[1]), int.Parse(s[2]), int.Parse(s[3]), int.Parse(s[4])));
            }
            reader.Close();
            return list;
        }

        //метод для редагування запису

        public static Student Edit(Student student)
        {
            Console.WriteLine("\nЯке поле ви хочете редагувати?\n\n" +
                                               "Прiвище - 1\n" +
                                               "Номер групи - 2\n" +
                                               "Оцiнку з математики - 3\n" +
                                               "Оцiнку з ТСПП - 4\n" +
                                               "Оцiнку з ООП - 5\n" +
                                               "Вийти - 6");
            Console.Write("\nВаш вибiр: ");
            int localNum = int.Parse(Console.ReadLine());
            Console.Write("\n");
            Console.Write("Введiть нове значення: ");
            switch (localNum)
            {
                case 1:
                    student.Surname = Console.ReadLine(); break;
                case 2:
                    int groupchange = int.Parse(Console.ReadLine());
                    if (groupchange < 1 || groupchange > 500)
                    {
                        Console.Write("\nНомер групи не може бути бiльшим за 500 i меншим за 0 \n"); break;
                    }
                    else
                    {
                        student.Group = groupchange; break;
                    }
                case 3:
                    int mathchange = int.Parse(Console.ReadLine());
                    if (mathchange < 0 || mathchange > 5)
                    {
                        Console.Write("\nОцiнка не може бути бiльша за 5 i менша за 0\n"); break;
                    }
                    else
                    {
                        student.Math = mathchange; break;
                    }
                case 4:
                    int tcppchange = int.Parse(Console.ReadLine());
                    if (tcppchange < 0 || tcppchange > 5)
                    {
                        Console.Write("\nОцiнка не може бути бiльша за 5 i менша за 0\n"); break;
                    }
                    else
                    {
                        student.TCPP = tcppchange; break;
                    }
                case 5:
                    int oopchange = int.Parse(Console.ReadLine());
                    if (oopchange < 0 || oopchange > 5)
                    {
                        Console.Write("\nОцiнка не може бути бiльша за 5 i менша за 0\n"); break;
                    }
                    else
                    {
                        student.OOP = oopchange; break;
                    }
                case 6: break;
            }
            return student;
        }
        public static void Write(string path, ArrayList students)
        {
            StreamWriter streamWriter;
            streamWriter = File.CreateText(path);
            foreach (Student n in students)
            {
                streamWriter.WriteLine(n);
            }
            streamWriter.Close();
        }

        static void Main(string[] args)
        {
          
            string path = "E:\\database.txt";
        

            ArrayList students = new ArrayList(new Student[] { });
            while (true)
            {
                
                Console.WriteLine("\n\tМеню\n\n" +
                                  "Додати запис - 1\n" +
                                  "Редагувати запис - 2\n" +
                                  "Видалити запис - 3\n" +
                                  "Вивести усi записи - 4\n" +
                                  "Пошук за номером групи - 5\n" +
                                  "Вийти - 6");
                try
                {
                    bool breakFlag = false;
                    int a;
                    Console.Write("\nВаш вибiр: ");
                    int choice = int.Parse(Console.ReadLine());
                    Console.Write("\n");
                    switch (choice)
                    {
                        //код для додавання запису

                        case 1:
                            Console.Write("Прiзвище: ");
                            string surname = Console.ReadLine();
                            Console.Write("Номер групи: ");
                            int group = int.Parse(Console.ReadLine());
                            if (group < 1 || group > 500)
                            {
                                Console.Write("\nНомер групи не може бути бiльшим за 500 i меншим за 0 \n"); break;
                            }
                            Console.Write("Оцiнка з математики: ");
                            int math = int.Parse(Console.ReadLine());
                            if (math < 0 || math > 5)
                            {
                                Console.Write("\nОцiнка не може бути бiльша за 5 i менша за 0\n"); break;
                            }
                            Console.Write("Оцiнка з ТСПП: ");
                            int tcpp = int.Parse(Console.ReadLine());
                            if (tcpp < 0 || tcpp > 5)
                            {
                                Console.Write("\nОцiнка не може бути бiльша за 5 i менша за 0\n"); break;
                            }
                            Console.Write("Оцiнка з ООП: ");
                            int oop = int.Parse(Console.ReadLine());
                            if (oop < 0 || oop > 5)
                            {
                                Console.Write("\nОцiнка не може бути бiльша за 5 i менша за 0\n"); break;
                            }
                            students = ReadFromFile(path);
                            Student student = new Student(surname, group, math, tcpp, oop);
                            students.Add(student);
                            Write(path, students);
                            break;

                        //код для вибору запису для редагування 

                        case 2:
                           students = ReadFromFile(path);
                            Console.WriteLine("Який запис хочете редагувати?\n");
                            a = 1;
                            students.Sort();
                            for (int i = 0; i < students.Count; i++)
                            {
                                a++;
                                Student n = (Student)students[i];
                                Console.WriteLine($"{i + 1} - Прiзвище: {n.Surname}, Номер групи: {n.Group}, Оцiнка з математики: {n.Math}, Оцiнка з ТСПП: {n.TCPP}, Оцiнка з ООП: {n.OOP}");
                            }
                            Console.WriteLine($"{a} - Вийти");
                            Console.Write("\nВаш вибiр: ");
                            int editChoice = int.Parse(Console.ReadLine());
                            if (editChoice == a)
                                break;
                            students[editChoice - 1] = Edit((Student)students[editChoice - 1]);
                            Write(path, students);
                            break;

                        //код для видалення запису

                        case 3:
                            Console.WriteLine("Виберiть запис який хочете видалити\n");
                            a = 1;
                            students = ReadFromFile(path);
                            students.Sort();
                            for (int i = 0; i < students.Count; i++)
                            {
                                a++;
                                Student n = (Student)students[i];
                                Console.WriteLine($"{i + 1} - Прiзвище: {n.Surname}, Номер групи: {n.Group}, Оцiнка з математики: {n.Math}, Оцiнка з ТСПП: {n.TCPP}, Оцiнка з ООП: {n.OOP}");

                            }
                            Console.WriteLine($"{a} - Вийти");
                            Console.Write("\nВаш вибiр: ");
                            int deleteChoice = int.Parse(Console.ReadLine());
                            Console.Write("\n");
                            if (deleteChoice == a)
                                break;
                            students.Remove(students[deleteChoice - 1]);
                            Write(path, students);
                            break;

                        //код виведення усіх записів

                        case 4:
                            students = ReadFromFile(path);
                            students.Sort();
                            foreach (Student n in students)
                            {
                                Console.WriteLine($"Прiзвище: {n.Surname}, Номер групи: {n.Group}, Оцiнка з математики: {n.Math}, Оцiнка з ТСПП: {n.TCPP}, Оцiнка з ООП: {n.OOP}");
                            }
                            Console.WriteLine("\n");
                            break;

                        //код для знаходження за номером групи

                        case 5:
                            int count = 0;
                            students = ReadFromFile(path);
                            Console.Write("Введiть номер групи: ");
                            int groupnum = int.Parse(Console.ReadLine());
                                Console.Write("\n");
                                
                            foreach (Student n in students)
                            {
                                if (n.Group.Equals(groupnum))
                                {
                                    Console.WriteLine(n);
                                    count++;
                                    
                                }
                               
                            }
                            if (count == 0)
                            {
                                    Console.Write("Данi про студента з таким номером групи немає \n");
                                  
                                }
                            
                            break;
                        case 6:
                            breakFlag = true;
                            break;
                        default:
                            continue;
                    }
                    if (breakFlag)
                        break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nВводити можна тiльки числа!\n");
                }
            }
        }
    }
}