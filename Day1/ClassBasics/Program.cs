//using System;

namespace ClassBasics
{
    internal class Program
    {
        static void Main1(string[] args)
        {

            Console.WriteLine("Hello, World!");
            System.Console.WriteLine("Hello world");
        }

        static void Main(string[] args)
        {

            Class1 o = new Class1();
            o.Display();
            o.Display("hello");

            //Console.WriteLine(o.Add(10,20));

            //named parameter
            Console.WriteLine(o.Add(a: 10));
            Console.WriteLine(o.Add(b: 10));
            Console.WriteLine(o.Add(c:10));
        }
    }

    public class Class1
    {
        public void Display()
        {
            Console.WriteLine("Display");
        }
        public void Display(string s)
        {
            Console.WriteLine("Display");
        
        }
        /*
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Add(int a, int b, int c)
        {
            return a + b+c;
        }*/

        //public int Add(int a=0,int b=0,int c = 0)
        //{
        //    return a + b + c;
        //}

        //ok
        //public int Add(int a , int b, int c = 0)
        //{
        //    return a + b + c;
        //}

        //error
        //public int Add(int a=0 , int b, int c )
        //{
        //    return a + b + c;
        //}


        public void DoSomething1()
        {
            int i = 1;
            DoSomething2();// can only call from outer function 

            //local function
            void DoSomething2()
            {
                //local function can access local variable 
               //declred i the outer function 
                Console.WriteLine(i);
            }
        }

      

        public int Add(int a=0 , int b=0, int c=0 )
        {
            return a + b + c;
        }

    }
}
namespace payroll
{
    public class empolyee { }
    public class Deparment { }
}

namespace mynamespace
{
    namespace n1
    {
        public class class2 { }
    }
    public class class1 { }
}