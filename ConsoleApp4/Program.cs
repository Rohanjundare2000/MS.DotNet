using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;

namespace GenericseCollection 
{
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        ArrayList obj = new ArrayList();
    //        obj.Add("Rohan");
    //        obj.Add(10);
    //        obj.Add(true);
    //        obj.Add(1.23);

    //        obj.Insert(0, "new");

    //        obj.Remove(10);
    //        obj.RemoveAt(1);


    //        foreach (Object obj2 in obj)
    //        {
    //            Console.WriteLine(obj2);
    //        }
    //        obj.Clear();
    //        Console.WriteLine("hey");
    //        foreach (Object obj2 in obj)
    //        {
    //            Console.WriteLine(obj2);
    //        }
    //        Console.WriteLine("hey");
    //    }
    //}


    //internal class Program
    //{
    //    static void Main(String args)
    //    {
    //        ArrayList obj = new ArrayList();
    //        obj.Add("Rohan");
    //        obj.Add(10);
    //        obj.Add(true);
    //        obj.Add(1.23);

    //        obj[0] = "changed value";
    //        foreach (var i in obj)
    //        {
    //            Console.WriteLine(i);
    //        }

    //    }
    //}

    //internal class Program
    //{
    //    static void Main()
    //    {
    //        ArrayList objArrayList = new ArrayList();
    //        Console.WriteLine($"Count is {objArrayList.Count}, Capacity is {objArrayList.Capacity}");

    //        objArrayList.Add(1);
    //        Console.WriteLine($"Count is {objArrayList.Count}, Capacity is {objArrayList.Capacity}");
    //        objArrayList.Add(2);
    //        Console.WriteLine($"Count is {objArrayList.Count}, Capacity is {objArrayList.Capacity}");
    //        objArrayList.Add(3);
    //        Console.WriteLine($"Count is {objArrayList.Count}, Capacity is {objArrayList.Capacity}");
    //        objArrayList.Add(4);
    //       Console.WriteLine($"Count is{objArrayList.Count}, Capacity is {objArrayList.Capacity}");
    //    }

    //}


    internal class Program
    {
        //static void Main()
        //{
        //    int? a = 100;
        //    Nullable<int> b = new Nullable<int>(100);
        //    decimal? v = 1.23M;
        //}

        //    static void Main()
        //    {
        //        Stack<int> i = new Stack<int>(10);
        //        i.Push(10);
        //        i.Push(20);
        //        i.Push(30);

        //        Console.WriteLine(i.Pop());
        //        Console.WriteLine(i.Pop());
        //        Console.WriteLine(i.Pop());

        //        Stack<string> j = new Stack<string>(10);
        //        j.Push("aa");
        //        j.Push("bb");
        //        j.Push("cc");

        //        Console.WriteLine(j.Pop());
        //        Console.WriteLine(j.Pop());
        //        Console.WriteLine(j.Pop());
        //    }
        //}

        //public class IntergerStack
        //{
        //    int[] arr;

        //    // Constructor
        //    public IntergerStack(int Size) 
        //    { 
        //        arr = new int[Size]; 
        //    }

        //    int Pos = -1;

        //    public void Push(int i)
        //    {
        //        if (Pos == (arr.Length - 1))
        //            throw new Exception("stack full");
        //        arr[++Pos] = i;
        //    }
        //    public int Pop()
        //    {
        //        if(Pos == -1)
        //            throw new Exception("Stack Empty");
        //        return arr[Pos--];
        //    }
        //}
    }
        //public class StringStack
        //{
        //    string[] arr;

        //    public StringStack(int Size)
        //    {
        //        arr = new string[Size];
        //    }

        //    int Pos = -1;

        //    public void Push(string i)
        //    {
        //        if (Pos == (arr.Length - 1))
        //        {
        //            throw new Exception("Stack is OverFlow");
        //        }
        //        arr[++Pos] = i;
        //    }

        //    public string Pop()
        //    {
        //        if (Pos == -1)
        //            throw new Exception("Stack is underFlow");
        //        return arr[--Pos];
        //    }
        //}

    internal class GenericStack<T>
    {
        T[] arr;

        public GenericStack(int size)
        {
            arr = new T[size];
        }

        int Pos = -1;

        public void Push(T i)
        {
            if (Pos == (arr.Length - 1))
                throw new Exception("Stack OverFlow");
            arr[Pos++] = i;
        }

        public T Pop()
        {
            if (Pos == -1)
                throw new Exception("Stack UnderFlow");
            return arr[Pos--];
        }
    }
}
