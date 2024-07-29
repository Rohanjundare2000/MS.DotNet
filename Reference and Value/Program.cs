namespace Reference_and_Value
{
    internal class Program
    {

        //// Ans = 300 , 300
        //static void Main()
        //{
        //    Class1 o1 = new Class1();
        //    Class1 o2 = new Class1();
        //    o1.i = 100;
        //    o2.i = 200;
        //    o1 = o2;// reference type: In te reference type if u change the value of the first then it
        //            // it is affect on the second cause here o1 = o2; is refer to the to second 
        //            // it work as like the pointer where o1 id refer to the o2
        //    o2.i = 300;
        //    Console.WriteLine(o1.i);//300
        //    Console.WriteLine(o2.i);//300
        //}


        //// 200 ,300
        //static void Main2()
        //{
        //    int o1, o2;
        //    o1 = 100;
        //    o2 = 200;
        //    o1 = o2;// value type: over here the o2 value is assign to the o1 
        //    o2 = 300;
        //    Console.WriteLine(o1);//200
        //    Console.WriteLine(o2);//300
        //    Console.ReadLine();
        //}



        static void Main()
        {
            string o1, o2;
            o1 = "100";
            o2 = "200";
            o1 = o2;// string id the reference type of object in the hence ans is 300, 300 althought 
                    // you know that the string is the immutable class so that it can not be change hence the ans will
                    // be act as the value type ans is 200,300
            o2 = "300";
            Console.WriteLine(o1);
            Console.WriteLine(o2);
            Console.ReadLine();
        }

    }
    public class Class1
    {
        public int i;
    }
}

