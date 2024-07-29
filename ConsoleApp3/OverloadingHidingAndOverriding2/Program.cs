using System.Collections;

namespace OverloadingHidingAndOverriding2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // BaseClass b= new BaseClass();
            //b.Display1(); // call directly, non virtual, early bound, depends on which object it points to // base display1
            // b.Display2();  //base display2//  non virtual/early bound, depends on reference
            //b.Display3(); //base display3  //virtual, late bound, depends on which object it points to

            // BaseClass b= new BaseClass();
            //b.Display1(); // call directly, non virtual, early bound, depends on which object it points to // base display1
            // b.Display2();  //base display2//  non virtual/early bound, depends on reference
            //b.Display3(); //base display3  //virtual, late bound, depends on which object it points to


            // SubDerivedClass b= new SubDerivedClass();
            //b.Display1(); // call directly, non virtual, early bound, depends on which object it points to // base display1
            // b.Display2();  //base display2//  non virtual/early bound, depends on reference
            //b.Display3(); //base display3  //virtual, late bound, depends on which object it points to


            // SubSubDerivedClass b= new SubSubDerivedClass();
            //b.Display1(); // call directly, non virtual, early bound, depends on which object it points to // base display1
            // b.Display2();  //base display2//  non virtual/early bound, depends on reference
            //b.Display3(); //base display3  //virtual, late bound, depends on which object it points to
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
        public virtual void Display3()    //virtual : // virtual function can be override 
                                                      // it give the flexibilty to the method 
                                                      // across this sealed is reduced the flexibity
                                                      // In Dotnot all function is not virtual as like java 
                                                      // virtual function are the late bound hence its work with the inheritance
                                                      // runtime binding and runtime polymorphism
        {
            Console.WriteLine("base display3");
        }
    }
    public class DerivedClass : BaseClass   // sealed class is restrict the functionality of the inheritance
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
        public sealed override void Display3()  //overriding  // only virtual method can be override
                                                // sealed keyword is only used with the override
                                                // sealed keyword is restrict the override functionality
                                                // over here u called the SubSubDerivedClass display method but u will u will get the subdrived method call
                                               
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
