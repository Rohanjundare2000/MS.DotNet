namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 o = new Class1();
            o.i = 1;
            Console.WriteLine(o.i);
        }
    }

    public class Class1
    {
        //class level variable field 
        public int i;//initiallised to their default value.
    }

}
