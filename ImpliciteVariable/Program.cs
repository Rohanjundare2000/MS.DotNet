/*namespace ImpliciteVariable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 100;
            var j = 100;
            // the value of the var can be Update
            // it only used uin local function 

            j =200;
           Console.WriteLine(j.GetType());

        }
    }
}*/

/*namespace Am
{
    internal class Program2
    {
        static void Main1(string[] args)
        {
            var obj = new { a = 1, b = "aaa", c = true };
            Console.WriteLine(obj.a);
            Console.WriteLine(obj.b);   
            Console.WriteLine(obj.c);
            Console.WriteLine(obj.GetType());
        }
        static void Main(string[] args)
        {
            var obj = new { a = 1, b = "aaa", c = true };
            var obj1 = new { a = 1, b = "aaa", c = true, IsRetired = false };
            Console.WriteLine(obj.a);
            Console.WriteLine(obj.b);
            Console.WriteLine(obj.c);
            Console.WriteLine(obj.GetType());
            Console.WriteLine(obj1.GetType());
        }
    }
}*//*
namespace PartialClass
{
     internal class Program
    {
        static void Main(string[] args)
        {
            Class1 cs = new Class1("ROhan", 100000);
            cs.Display();
        }
    }
    public partial class Class1
    {
       public  string Name;
        public int id;

        public Class1(string Name, int id)
        {
        this.Name = Name;
        this.id = id;
        }
    }
    public partial class Class1
    {
        public void Display()
        {
            Console.WriteLine(Name);
            Console.WriteLine(id);
        }
    }
}*/

/*namespace PartialMethods
{
    public class MainClass
    {
        public static void Main1()
        {
            Class3 cs =new Class3();
            cs.Validate();
        }


    }
    public partial class Class3
    {
        private bool isValid = true;

        partial void Validate();

        public bool Check()
        {
            Validate();
            return isValid;
        }
    }
    public partial class Class3
    {
      
       partial void Validate()
        {
            bool isValid = false;
        }

       
    }
}*/

namespace ExtensionMethods
{
    internal class Program
    {
        static void Main1()
        {
            int i = 100;

            i = i.Add(5);
            i.Display();//MyExtClass.Display(i);   
            i.ExtMethodForBaseClass();


            string s = "aaa";
            s.Show();
            s.ExtMethodForBaseClass();
        }
       /* static void Main2()
        {
            int i = 100;
            i = MyExtClass.Add(i, 5);
            MyExtClass.Display(i);

            string s = "aaa";
            MyExtClass.Show(s);
        }
        static void Main()
        {
            ClsMaths objClsMaths = new ClsMaths();
            Console.WriteLine(objClsMaths.Add(10, 5));
            Console.WriteLine(objClsMaths.Multiply(10, 5));
            Console.WriteLine(objClsMaths.Subtract(10, 5));

        }*/

    }
    //create a extension method
    //step 1 : create a static method in a static class
    public static class MyExtClass
    {
        public static int Add(this int i, int x)
        {
            return i + x;
        }
        //step 2 : the 1st parameter must be  the Type
        //for which you write an extension method,
        //preceded by the 'this' keyword
        public static void Display(this int i)
        {
            Console.WriteLine(i);
        }
        public static void Show(this string s)
        {
            Console.WriteLine(s);
        }
        //if you define an ext method for the base class,
        //it is also available for the derived class
        public static void ExtMethodForBaseClass(this object o)
        {
            Console.WriteLine(o);
        }
        //if you define an ext method for an interface
        //it is also available for the classes that implement that interface
        public static int Subtract(this IMathOperations objIMath, int a, int b)
        {
            return a - b;
        }
    }

    public interface IMathOperations
    {
        int Add(int a, int b);
        int Multiply(int a, int b);
    }

    public class ClsMaths : IMathOperations
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }

}