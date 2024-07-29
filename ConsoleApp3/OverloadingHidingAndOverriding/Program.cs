namespace OverloadingHidingAndOverriding
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //Base b = new Base(); //Parametereless Base Class constructo
          
            // Base b2 = new Base(10, 20); //Parameterized Base Class constructor

              //Derived derived = new Derived();// Parametereless Base Class constructor
                                             // Parametereless Derived Class constructor
           
            
            Derived derived1 = new Derived(10,20);   //Parametereless Base Class constructor
                                                    // Parameterized Derived Class constructor

        }
    }
    public class Base
    {
       public Base()
        {
            Console.WriteLine("Parametereless Base Class constructor");
        }

        public Base(int i,int j)
        {
            Console.WriteLine("Parameterized Base Class constructor");
        }

     }

    public class Derived:Base
    {
        public Derived()
        {
            Console.WriteLine("Parametereless Derived Class constructor");
        }

        public Derived(int i, int j)
        {
            Console.WriteLine("Parameterized Derived Class constructor");
        }
    }

}
