namespace virtual_and_override_keyword
{
    public class parent
    {
        public virtual  void show()
        {
            Console.WriteLine("Parent method");
        }
    }

    public class child : parent
    {
        public override void show()
        {
            Console.WriteLine("child method");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //child c = new child();
            //c.show();"child method"

            //parent p = new parent();
            //p.show(); "Parent method"

            parent p = new child();
            p.show();  // without overide and the virtual it given parent class 
                      //  with overide and virtual it gives the child class 
        }
    }
}
