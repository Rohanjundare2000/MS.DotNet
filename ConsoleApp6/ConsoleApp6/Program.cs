using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//AsyncCodeWithDelegates_FrameworkOnly
namespace AsyncCodeWithDelegates1
{
    internal class Program
    {
        static void Main09876()
        {
            Console.WriteLine("before");
            Action oDel = Display;
            oDel.BeginInvoke(null, null);  //async call// Aysnc Operation(Entry Parameter,CallBack,Object)
            Console.WriteLine("after");
            Console.ReadLine();
        }
        static void Display()
        {
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("display called");
        }
    }
}


namespace AsyncCodeWithDelegates2
{
    internal class Program
    {
        static void Main1()
        {
            Console.WriteLine("before");
            Action<string> oDel = Display;
            oDel.BeginInvoke("passed value", null, null);  //async call
            Console.WriteLine("after");
            Console.ReadLine();
        }
        static void Display(string s)
        {
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("display called " + s);
        }
    }
}


namespace AsyncCodeWithDelegates3
{
    internal class Program
    {
        static void Main5()
        {
            Console.WriteLine("Before");
            Func<string, string> oDel = Display;
            oDel.BeginInvoke("Passed Value", MyCallbackFunction, null);
            Console.WriteLine("After");
            Console.ReadLine();
        }
        static string Display(string s)
        {
            System.Threading.Thread.Sleep(456789);
            Console.WriteLine("dygwevefd" + s);
            return s.ToUpper();
        }
        static void MyCallbackFunction(IAsyncResult ar)
        {
            Console.WriteLine("callback func called");
        }
    }
}


namespace AsyncCodeWithDelegates4
{
    internal class Program
    {
        static void Main4()
        {
            Console.WriteLine("before");
            Func<string, string> oDel = Display;
            //oDel.BeginInvoke("passed value", new AsyncCallback(MyCallbackFunction), null);  //async call
            IAsyncResult result = oDel.BeginInvoke("passed value", delegate (IAsyncResult ar)
            {
                Console.WriteLine("callback func called");
                string retval = oDel.EndInvoke(ar);
                Console.WriteLine(retval);
            }, null);  //async call
            Console.WriteLine("after");       
            Console.ReadLine();
        }
        static void Maink()
        {
            Console.WriteLine("Before");
            Func<string, string> oDel = Display;
            oDel.BeginInvoke("Pass value", delegate(IAsyncResult ar)
            {
                Console.WriteLine("callback func called");
                string retval = oDel.EndInvoke(ar);
                Console.WriteLine(retval);
            }, null);
            Console.WriteLine("After");
            Console.ReadLine();
        }
        static string Display(string s)
        {
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("display called " + s);
            return s.ToUpper();
        }
    }
}


namespace AsyncCodeWithDelegates5
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("before");
            Func<string, string> oDel = Display;
            // oDel.BeginInvoke("passed value", MyCallbackFunction, "any data");  //async call
            oDel.BeginInvoke("passed value", MyCallbackFunction, oDel);  //async call
            Console.WriteLine("after");
            Console.ReadLine();
        }
        static string Display(string s)
        {
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("display called " + s);
            return s.ToUpper();
        }
        static void MyCallbackFunction(IAsyncResult ar)
        {
            Console.WriteLine("callback func called");
            // string lastparam = ar.AsyncState.ToString();
            Func<string, string> oDel = (Func<string, string>)ar.AsyncState;
            string retval = oDel.EndInvoke(ar);
            Console.WriteLine(retval);
        }
    }
}