using System.Security.Claims;

namespace Consturctor
{
    internal class Program
    {
       public int i;
       public int j;
      public int k;

        //    public Program(int i=10, int j=30, int k=30)
        //    {
        //        this.i = i;
        //        this.j=j; 
        //        this.k = k;        
        //    }

        //    private int p1;
        //    public int P1
        //    {
        //        set
        //        {
        //            if (value>100)
        //            {
        //                p1 = value;
        //            }
        //            else
        //            {
        //                Console.WriteLine("Invalid");
        //            }
        //        }
        //        get {

        //            return p1;
        //        }
        //    }
        //    Program()
        //    {
        //        this.p1 = P1;//variabke dont for 
        //        this.p1 = P1;//set for P1;
        //    }]

       public Program(int i, int j)
    {
            this.i= i;//variabke dont for 
            this.j = j;//set for P1;
            this.k = k;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        Program O = new Program();
            O.i = 10;
            O.j = 20;
            O.k = 30;

            //construction calling 
            Program p1 = new Program(10, 20, 30);
            //Program p1= new Program() { i=20, j=30 };
          //  Program p2 = new Program { i = 20, j = 30 };

        }
    }
}
