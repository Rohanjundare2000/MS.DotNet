/*namespace Delegates1
{
    //step 1 : create a delegate class having the same signature
    //as the function to call
    public delegate void Del1();

    //Object
    //Delegate
    //MulticastDelegate
    //Del1

    public delegate int DelAdd(int a, int b);
    internal class Program
    {
        static void Main1()
        {

            //step 2 : declare a delegate reference.
            //create a delegate object and pass function name as a parameter
            Del1 objDel = new Del1(Display);

            //step 3 : call the function via the delegate reference
            objDel();
        }
        static void Main2()
        {
            Del1 objDel = Display;
            objDel();

            objDel = Show;
            objDel();

        }
        static void Main3()
        {
            Del1 objDel = Display;
            objDel();

            Console.WriteLine();
            objDel += Show;
            objDel();

            Console.WriteLine();
            objDel += Display;
            objDel();

            Console.WriteLine();
            objDel -= Display;
            objDel();

            Console.WriteLine();
            objDel -= Show;
            objDel();

            //Console.WriteLine();
            //objDel -= Display;
            //objDel();


        }
        static void Main4()
        {
            DelAdd o1 = Add;
            Console.WriteLine(o1(10, 5));
        }

        //TO DO - try calling functions with return values as multi cast delegates
        static void Display()
        {
            Console.WriteLine("display");
        }
        static void Show()
        {
            Console.WriteLine("Show");
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static void Main5()
        {
            Del1 o1 = Class1.Display;
            o1();
            Class1 o2 = new Class1();
            o1 = o2.Show;
        }

        static void Main6()
        {
            Del1 objDel = (Del1)Delegate.Combine(new Del1(Display), new Del1(Show), new Del1(Display));
            objDel();

            Console.WriteLine();
            //objDel = (Del1)Delegate.Remove(objDel, new Del1(Display));
            objDel = (Del1)Delegate.RemoveAll(objDel, new Del1(Display));
            objDel();
        }

    }

    public class Class1
    {
        public static void Display()
        {
            Console.WriteLine("display");
        }
        public void Show()
        {
            Console.WriteLine("Show");
        }
    }
}


namespace Delegates2
{
    public delegate int DelAdd(int a, int b);

    internal class Program
    {
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Subtract(int a, int b)
        {
            return a - b;
        }
        static int Multiply(int a, int b)
        {
            return a * b;
        }
        static void Main()
        {
            Console.WriteLine(CallMathOperation(Add, 1, 2));
            Console.WriteLine(CallMathOperation(Subtract, 5, 3));
            Console.WriteLine(CallMathOperation(Multiply, 2, 3));
        }
        //pass function to be called as a parameter

        static int CallMathOperation(DelAdd objMathOperation, int a, int b)//objMathOperation=Multiply
        {
            return objMathOperation(a, b);
        }
    }


}*/




/*








namespace ExceptionHandling1
{
    internal class Program
    {
        static void Main1()
        {
            Class1 obj = new Class1();
            obj = null;
            int x = Convert.ToInt32(Console.ReadLine());
            obj.P1 = 100 / x;
            Console.WriteLine(obj.P1);
            Console.ReadLine();
        }
        static void Main0() //simple try block with catch
        {
            Class1 obj = new Class1();
            try
            {
                //
                //obj = null;
                int x = Convert.ToInt32(Console.ReadLine());
                obj.P1 = 100 / x;
                Console.WriteLine(obj.P1);
                Console.WriteLine("No Exceptions");
            }
            catch
            {
                Console.WriteLine("Exception occurred");
            }

        }
        static void Main6()//try with multiple catch blocks
        {
            Class1 obj = new Class1();
            try
            {
                obj = null;
                int x = Convert.ToInt32(Console.ReadLine());
                obj.P1 = 100 / x;
                Console.WriteLine(obj.P1);
                Console.WriteLine("No Exceptions");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("DBException occurred");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("NRException occurred");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("FormatException occurred");
            }
            Console.ReadLine();
        }
        static void Main3()// catching base class exceptions
        {
            Class1 obj = new Class1();
            try
            {
                obj = null;
                int x = Convert.ToInt32(Console.ReadLine());
                obj.P1 = 100 / x;
                Console.WriteLine(obj.P1);
                Console.WriteLine("No Exceptions");
            }

            //catch (SystemException ex)
            catch (FormatException ex)
            {
                Console.WriteLine("FormatException occurred");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("NRException occurred");
            }
            catch (DivideByZeroException ex)
            //catch (ArithmeticException ex) 
            //catch (SystemException ex) //base class exception has to caught after derived class exceptions
            {
                Console.WriteLine("DBException occurred");
            }
            catch (Exception ex) //catches all unhandled exceptions
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
        static void Main()// finally block
        {
            Class1 obj = new Class1();
            try
            {
                //obj = null;
                int x = Convert.ToInt32(Console.ReadLine());
                obj.P1 = 100 / x;
                Console.WriteLine(obj.P1);
                Console.WriteLine("No Exceptions");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("FormatException occurred");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("NRException occurred");
            }
            //catch (DivideByZeroException ex) 
            //catch (ArithmeticException ex) 
            catch (SystemException ex) //base class exception has to caught after derived class exceptions
            {
                Console.WriteLine("DBException occurred");
            }
            catch (Exception ex) //catches all unhandled exceptions
            {
                Console.WriteLine(ex.Message);
            }
            //finally runs when Exception does not occur, 
            //or Exception occurs and is handled or 
            //Exception occurs and is NOT handled 
            finally
            {
                Console.WriteLine("finally");

            }
            Console.WriteLine("after finally");
        }

        static void Main5()// nested try block
        {
            Class1 obj = new Class1();
            try
            {
                //obj = null;
                int x = Convert.ToInt32(Console.ReadLine());
                obj.P1 = 100 / x;
                Console.WriteLine(obj.P1);
                Console.WriteLine("No Exceptions");
            }

            catch (FormatException ex)
            {
                try
                {
                    Console.WriteLine("FormatException occurred. Enter only numbers");
                    int x = Convert.ToInt32(Console.ReadLine());
                    obj.P1 = 100 / x;
                    Console.WriteLine(obj.P1);
                }
                catch
                {
                    Console.WriteLine("nested try catch example");
                }
                finally
                {
                    Console.WriteLine("nested try finally example");
                }
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("NRException occurred");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("DBException occurred");
            }
            catch (Exception ex) //catches all unhandled exceptions
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("finally");

            }
            Console.ReadLine();
        }
    }

    public class Class1
    {
        private int p1;
        public int P1
        {
            get { return p1; }
            set
            {
                p1 = value;
            }
        }
    }
}
namespace ExceptionHandling2
{
    class Program
    {
        static void Main1()
        {
            Class1 obj = new Class1();
            try
            {
                int x = Convert.ToInt32(Console.ReadLine());
                obj.P1 = x;
                Console.WriteLine(obj.P1);
                Console.WriteLine("No Exceptions");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("FormatException occurred");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("NRException occurred");
            }
            catch (InvalidP1Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.ReadLine();
        }
    }

    public class InvalidP1Exception : Exception
    {
        public InvalidP1Exception(string message) : base(message)
        {

        }
    }


    public class Class1
    {
        private int p1;
        public int P1
        {
            get
            {
                return p1;
            }
            set
            {
                if (value < 100)
                    p1 = value;
                else
                {
                    //throw new Exception();
                    //throw new Exception("Invalid P1");

                    //throw new InvalidP1Exception();
                    throw new InvalidP1Exception("Invalid P1");
                }
            }
        }
    }



}
*/


/*
namespace InheritanceExamples
{
    internal class Program
    {
        static void Main1()
        {
            BaseClass o1 = new BaseClass();
            o1.a = 1;

            DerivedClass o2 = new DerivedClass();
            o2.b = 2;

        }
    }
    public class BaseClass //:Object
    {
        public int a;
    }
    public class DerivedClass : BaseClass
    {
        public int b;
    }
}

//access specifiers
namespace InheritanceExamples2

{
    //default access specifier is internal for members of a namespace
    class Program
    {
        static void Main1()
        {
            //BaseClass o = new BaseClass();
            //o.

            TestAccessSpecifiers.BaseClass o2 = new TestAccessSpecifiers.BaseClass();
            //o2.
        }
    }
    public class BaseClass
    {
        int i;  //default access specifier is private for members of a class

        //public - available everywhere
        //private - same class
        //protected - same class,  derived class
        //internal - same class, same assembly(same project)
        //protected internal - same class,  derived class, same assembly(same project)
        //private protected - same class,  derived class that is in the same assembly
        public int PUBLIC;
        private int PRIVATE;
        protected int PROTECTED;
        internal int INTERNAL;
        protected internal int PROTECTED_INTERNAL;
        private protected int PRIVATE_PROTECTED;
    }
    public class DerivedClass : TestAccessSpecifiers.BaseClass   //: BaseClass
    {
        void DoNothing()
        {
            //this.
        }
    }
}*/

//constructors in inheritance
namespace InheritanceExamples3
{
    class Program
    {
        static void Main()
        {
            //DerivedClass o = new DerivedClass();
            DerivedClass o2 = new DerivedClass(123, 456);
        }
    }
    public class BaseClass
    {
        public int i;
        public BaseClass()
        {
            Console.WriteLine("base class no param cons");
            i = 10;
        }
        public BaseClass(int i)
        {
            Console.WriteLine("base class int cons");
            this.i = i;
        }
    }
    public class DerivedClass : BaseClass
    {
        public int j;
        public DerivedClass()
        {
            Console.WriteLine("derived class no param cons");
            //i = 10; 
            j = 20;
        }
        public DerivedClass(int i, int j) : base(i)
        {
            Console.WriteLine("derived class int,int cons");
            //this.i = i;
            this.j = j;
        }
    }
}

namespace OverloadingHidingAndOverriding
{
    internal class Program
    {
        static void Main1()
        {
            DerivedClass o = new DerivedClass();
            o.Display1();
            o.Display1("a");

            o.Display2();

            o.Display3();
        }
        static void Main()
        {
            BaseClass o;
            o = new BaseClass();
            o.Display2();  //non virtual/early bound, depends on reference
            o.Display3();  //virtual, late bound, depends on which object it points to

            Console.WriteLine();
            o = new DerivedClass();
            o.Display2();  //non virtual/early bound, depends on reference
            o.Display3();  //virtual, late bound, depends on which object it points to

            Console.WriteLine();
            o = new SubDerivedClass();
            o.Display2();  //non virtual/early bound, depends on reference
            o.Display3();  //virtual, late bound, depends on which object it points to

            Console.WriteLine();
            o = new SubSubDerivedClass();
            o.Display2();  //non virtual/early bound, depends on reference
            o.Display3();  //virtual, late bound, depends on which object it points to

        }
    }
    public class BaseClass
    {
        public void Display1()
        {
            Console.WriteLine("base display1");
        }
        public void Display2()
        {
            Console.WriteLine("base display2");
        }
        public virtual void Display3()
        {
            Console.WriteLine("base display3");
        }
    }
    public class DerivedClass : BaseClass
    {
        public void Display1(string s)  //overloading
        {
            Console.WriteLine("derived display1" + s);
        }
        public new void Display2()  //hiding
        {
            Console.WriteLine("derived display2");
        }
        public override void Display3()  //overriding
        {
            Console.WriteLine("derived display3");
        }
    }
    public class SubDerivedClass : DerivedClass
    {
        public sealed override void Display3()  //overriding
        {
            Console.WriteLine("subderived display3");
        }
    }

    public class SubSubDerivedClass : SubDerivedClass
    {
        public void Display3()
        {
            Console.WriteLine("subsubderived display3");
        }
    }
}