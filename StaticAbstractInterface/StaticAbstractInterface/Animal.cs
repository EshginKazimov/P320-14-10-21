using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAbstractInterface
{
    public abstract class Animal
    {
        protected Animal()
        {

        }

        public abstract void Eat();

        public virtual void Print()
        {
        }
    }

    public abstract class Fish : Animal
    {
        public abstract void Swim();
    }

    public abstract class Bird : Animal
    {
        //public override void Eat()
        //{
        //    Console.WriteLine("Eat As Bird");
        //}

        public abstract void Fly();
    }

    public class Shark : Fish
    {
        public override void Eat()
        {
            Console.WriteLine("Eat As Shark");
        }

        public override void Swim()
        {
            Console.WriteLine("Swim As Shark");
        }

        public override void Print()
        {
            Console.WriteLine("Shark");
        }
    }

    public class Eagle : Bird
    {
        public override void Eat()
        {
            Console.WriteLine("Eat As Eagle");
        }

        public override void Fly()
        {
            Console.WriteLine("Fly As Eagle");
        }

        public override void Print()
        {
            Console.WriteLine("Eagle");
        }
    }
}
