using System;

namespace Lab4ex2
{
    public class Student : IComparable
    {

        private string surname;
        private int group;
        private int math;
        private int tcpp;
        private int oop;

        public override string ToString()
        {
            return $"Прiзвище: {surname}, Номер групи: {group}, Оцiнка з математики: {math}, Оцiнка з ТСПП: {tcpp}, Оцiнка з ООП: {oop}";
        }

        public int CompareTo(object? obj)
        {
            Student other = (Student)obj;
            return Surname.CompareTo(other.Surname);
        }


         public Student()
        {
        }

        public Student(string surname, int group,  int math, int tcpp, int oop)
        {
            Surname = surname;
            Group = group;
            Math = math;
            TCPP = tcpp;
            OOP = oop;
        }

        public string Surname
        {
            get => surname;
            set => surname = value;
        }

        public int Group
    {
            get => group;
            set => group = value;
        }

        public int Math
        {
            get => math;
            set => math = value;
        }

        public int TCPP
    {
            get => tcpp;
            set => tcpp = value;
        }

        public int OOP
    {
            get => oop;
            set => oop = value;
        }
    }
}
