
using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
    class Program
    {
        public List<Teachers> teachers;

        public Program(List<Teachers> teachers)
        {
            this.teachers = teachers;
        }

        public object this[int index]
        {
            get { return teachers[index]; }
            set { teachers[index].id = (string)value; }
        }
        static void Main(string[] args)
        {
            NewMethod();

            MustSubject a = new MustSubject();

            Console.WriteLine("Hello World!");
        }

        private static void NewMethod()
        {
            Program b = new Program();
        }
    }
}
