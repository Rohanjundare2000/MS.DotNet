namespace New_keyword_and_hiding
{
   
        public class parent
        {
            public void show()
            {
                Console.WriteLine("Parent method");
            }
        }

        public class child : parent
        {
            public new void show()
            {
                Console.WriteLine("child method");
            }
        }


        internal class Program
        {
            static void Main(string[] args)
            {
                //child c = new child();
                //c.show();//"child method"

                //parent p = new parent();
                //p.show(); "Parent method"

                parent p = new child();
                p.show();  // without overide and the virtual it given parent class 
                           //  with overide and virtual it gives the child class 
            }
        }

}
