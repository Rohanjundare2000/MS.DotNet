namespace COnstructorNObjectInitialization
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Object Initialization
            Class1 cs = new Class1(1,"ROHAN");
            Program2 ps = new Program2();
            Program2 ps2 = new Program2(10,20,30);
            Program2 ps3 = new Program2() {i=10,j=20,k=30};
            Program2 ps4 = new Program2 { i = 10, j = 20, k = 30 };
            Console.WriteLine(cs.Id);
        }
    }

    public class Program2
    {
       public int i;
        public int j;
        public int k;
        public Program2()
        {

        }

        public Program2(int i, int j, int k)
        {
            this.i = i;
            this.j = j;
            this.k = k;
        }                           
    }
    public class Class1
    {
        int id;
        string name;

        public Class1()
        {
        }
        public Class1(int i=10, string name= "Rohan")
        {
            this.id = id;
            this.name = name;
        }

        public int Id
        {
            get
            {
                return id;
            }
        }

    }
}

