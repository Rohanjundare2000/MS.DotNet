namespace Interface1
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            //CALL ON THE OBJECT
            Class1 class1 = new Class1();
            class1.update();
            class1.Insert();
            class1.delete(); 
            class1.Display(); // class of that method 

            //METHOD : 1 = Called on the interface 
            IDbFunctions f;
            f = class1;
            f.update(); 
            f.delete();
            f.Insert();
            //f.Display(); //error : It is NOT THE METHOD THE INTERFACE

            //METHOD : 2 = Called on the interface 
            ((IDbFunctions)class1).Insert();
            ((IDbFunctions)class1).delete();
            ((IDbFunctions)class1).update();
            //((IDbFunctions)class1).Display(); // error not possible;

            //Method : 3 // call on the interface
            (class1 as IDbFunctions).update();
            (class1 as IDbFunctions).delete();
            (class1 as IDbFunctions).Insert();

        }
    }

    public interface IDbFunctions
    {
        void Insert();
        void update();
        void delete();

    }

    public class Class1: IDbFunctions 
    {
        public void Display()
        {
            Console.WriteLine("Display from class1"); 
        }
        public void Insert() {Console.WriteLine("display Insert from class1");
        }
        public void update() { Console.WriteLine("display update from class1"); }
        public void delete() { Console.WriteLine("display delete from class1"); }    

    }
}


namespace interface2
{
    internal class Program()
    {
        static void Main()
        {
            Class3 c = new Class3();
            c.Insert();
            c.update();


            h h;
            h = c;
            h.delete();
            h.Insert();
            h.update();


            (c as h1).delete();
        }
    }

    public interface h
    {
        void Insert();
        void update();
        void delete();

    }

    public interface h1
    {
        void open();
        void close();
        void delete();

    }

    public class Class3 : h,h1
    {
        public void Insert()
        {
            Console.WriteLine("Insert");
        }
        public void update()
        {

            Console.WriteLine("update");
        }
       void h.delete()
        {

            Console.WriteLine("delete");
        }

        public void open()
        {

            Console.WriteLine("open");
        }
        public void close()
        {
            Console.WriteLine("close");

        }
        void h1.delete()
        {
            Console.WriteLine("delete");
        }
    }
}




namespace Interface3
{
    internal class Class4
    {
        static void Main()
        {
            Class1 c = new Class1();
            c.Insert();
            c.Delete();
            c.Update();
            c.Display();

            idfunction h;
            h = c;
            h.Insert();
            h.Update();
            h.Delete();

            // h.Display();//error
            Class2 c1 = new Class2();
            c1.Insert();
            c1.Delete();
            c1.Update();
            c1.Show();

            idfunction h1;
            h1 = c;
            h1.Insert();
            h1.Update();
            h1.Delete();



        }
    }

    interface idfunction
    {
        void Insert();
        void Update();
        void Delete();
    }
   
    public class Class1 : idfunction
    {
       public  void Insert()
        {
            Console.WriteLine("display from class1");
        }
       public  void Update()
        {
            Console.WriteLine("display from class1");
        }
       public  void Delete()
        {
            Console.WriteLine("display from class1");
        }
        public void Display()
        {
            Console.WriteLine("display from class1");
        }
    }

    public class Class2 : idfunction
    {
        public void Show()
        {
            Console.WriteLine("show from Class2");
        }
        public void Insert()
        {
            Console.WriteLine("display from Class2");
        }
        public void Update()
        {
            Console.WriteLine("display from Class2");
        }
        public void Delete()
        {
            Console.WriteLine("display from Class2");
        }
    }

}