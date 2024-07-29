namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Class1 c = new Class1();
            c.Display();
            c.Display4(12,12);
            Console.WriteLine(c.Display4(12, 21, 43));

        }
    }
}

public class Class1
{
    public static void Prop3 { set; get; }
    public void Display()
    {
        Console.WriteLine("Hello work");

    }


    //public int Display2(int a, int b)
    //{
    //    return a + b;
    //}

    //public int Display3(int a, int b,int c)
    //{
    //    return a + b+c;
    //}

    public int Display4(int a=0, int b=0, int c=0)
    {
        return a + b + c;
    }

}




