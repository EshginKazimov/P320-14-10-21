using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAbstractInterface
{
    class Student
    {
        private static int _counter = 1;

        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public static int Count { get; set; } = 10;

        //Yalniz bir defe static membere muraciet edende ishe dushur
        //Parametrless olmalidir
        static Student()
        {
            //Console.WriteLine("Static constructor called");
            Count = 10;
        }

        public Student()
        {
            //Console.WriteLine("Non static constructor called");
            //_counter++;
            Id = _counter++;
        }

        public static void Print()
        {
            Count = 10;
            Console.WriteLine(Count);
            //Name 
        }

        public void ShowInfo()
        {
            Name = "";
            Surname = "";
            Count = 0;
        }
    }
}
