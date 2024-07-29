using System.Diagnostics;

namespace Function_Action_Predict
{
    //public delegate void Del1();
    internal class Program
    {
        static void Main(string[] args)
        {
            /*NON GenericType*/
            //Del1 d = new Del1(Display);
            //d();
            //Action a = new Action(Display);// 
            //a();

            /*NON GenericType*/
            /* Action<int, int> action = add;
             action(10, 20);*/
            /*Action<string> action = Display;
            action();*/
            /*   Action<int, int, string> action = Display;
               action(10,20,"rohan");*/

            Func<string> o = GetCurrentTime;
            Console.WriteLine(o());

            Func<int, int> o1 = GetDouble;
             Console.WriteLine(o1(2));

            Func<int, bool> o3 = IsEven;
            Console.WriteLine(o3(2));

            Predicate<int> o2 = IsEven;
            Console.WriteLine(o2(2));

        }
        static void add(int a, int b)
        {
            Console.WriteLine(a + b); 
        }

        static void Display()
        {
            Console.WriteLine("Display");
        }

        static void Display(int a, int b,string r)
        {
            Console.WriteLine(a + b + r);     
        }
        static string GetCurrentTime()
        {
            return DateTime.Now.ToLongTimeString();
        }
        static int GetDouble(int a)
        {
            return a * 2;
        }
        static int Add(int a, int b)
        {
            return a + b;
        }
        static bool IsEven(int i)
        {
            if (i % 2 == 0)
                return true;
            else
                return false;
        }
    }
}
//}
//namespace FuncActionPredicate
//{
//   
//    internal class Program
//    {
//        static void Main()
//        {
//            Func<string> o1 = GetCurrentTime;
//            Console.WriteLine(o1());
//            Func<int, int> o2 = GetDouble;
//            Console.WriteLine(o2(10));
//            Func<int, int, int> o3 = Add;
//            Console.WriteLine(o3(10, 20));
//            Func<int, bool> o4 = IsEven;
//            Console.WriteLine(o4(10));
//            Predicate<int> o5 = IsEven;
//            Console.WriteLine(o5(10));
//        }

//       
//    }
//}