using System;

namespace LearningConsoleApp
{
    public class A
    {
        public virtual void m1()
        {
            Console.WriteLine("Method of Base CLass");
            Console.ReadLine();
        }
    }
    public class B:A
    {
        public override void m1()
        {
            Console.WriteLine("Method of Derived CLass");
            Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            b.m1();
        }
        
    }
}
