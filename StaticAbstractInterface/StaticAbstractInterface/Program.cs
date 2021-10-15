using System;

namespace StaticAbstractInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Static

            //Student.Count = 10;
            //Console.WriteLine(Student.Count);
            //Student.Print();

            //Student s1 = new Student();
            //s1.Name = "";
            //s1.Surname = "";
            //s1.ShowInfo();
            //s1.Count = 0;

            //Math

            //Student.Count = 10;
            //Student.Count = 20;
            //Student.Count = 30;
            //Student.Count = 40;
            //Student.Count = 50;
            //Student.Count = 60;
            //Student.Count = 70;

            //Student s2 = new Student();
            //Console.WriteLine(s2.Id);
            //Student s3 = new Student();
            //Console.WriteLine(s3.Id);
            //Student s4 = new Student();
            //Console.WriteLine(s4.Id);
            //Student s5 = new Student();
            //Student s6 = new Student();

            //Helper h1 = new Helper();
            //Helper.Print(ConsoleColor.Red, "Hello P320!");
            //Helper.Print(ConsoleColor.Blue, "Bye P320!");

            #endregion

            #region Abstract
            //Instance almaq olmur

            //Animal a1 = new Animal();
            //Fish f1 = new Fish();
            //Shark s1 = new Shark();
            //s1.Eat();
            //s1.Swim();
            //s1.Print();
            //Print(s1);

            //Eagle e1 = new Eagle();
            //e1.Eat();
            //e1.Print();
            //Print(e1);

            #endregion

            #region Interface

            Car c1 = new Car();
            Person p1 = new Person();
            Print(c1);
            Print(p1);

            #endregion
        }

        //static void Print(Car c1)
        //{
        //    Console.ForegroundColor = ConsoleColor.Red;
        //    c1.Move();
        //    Console.ResetColor();
        //}

        //static void Print(Person p1)
        //{
        //    Console.ForegroundColor = ConsoleColor.Red;
        //    p1.Move();
        //    Console.ResetColor();
        //}

        //static void Print(Animal a1)
        //{
        //    Console.ForegroundColor = ConsoleColor.Red;
        //    a1.Eat();
        //    Console.ResetColor();
        //}

        //static void Print(Shark s1)
        //{
        //    Console.ForegroundColor = ConsoleColor.Red;
        //    s1.Eat();
        //    Console.ResetColor();
        //}

        //static void Print(Eagle e1)
        //{
        //    Console.ForegroundColor = ConsoleColor.Red;
        //    e1.Eat();
        //    Console.ResetColor();
        //}

        static void Print(IMove obj)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            obj.Move();
            Console.ResetColor();
        }
    }

    #region Interface

    //C# 8.0 versiyaya kimi
    interface IMove
    {
        void Move();
    }

    interface ITest
    {
        void Test();

        public void Test2()
        {

        }
    }

    class Demo
    {

    }

    class Car : Demo, IMove, ITest
    {
        public void Move()
        {
            Console.WriteLine("Move as Car");
        }

        public void Test()
        {
            Console.WriteLine("Test");
        }
    }

    class Person : IMove
    {
        public void Move()
        {
            Console.WriteLine("Move as Person");
        }
    }

    #endregion


    //Student.cs olsun, Name, Surname, Age propertyleri olsun,
    //ancaq constructorda set olsun. 
    //Neche defe instance aldigimizi qaytaran Counter olsun,
    //hansiniki yalniz constructorda set ede bilek.
}
