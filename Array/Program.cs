namespace Array
{
    //internal class Program
    //{
    //    static void Main1(string[] args)
    //    {
    //        int[] marks = new int[3];
    //        marks[0] = 1;
    //        marks[1] = 2;
    //        marks[2] = 3;

    //        Console.WriteLine(marks[0] + " " + marks[1]+" "+marks[2]);
    //    }
    //}
    //class Program2
    //{
    //    static void Main2(string[] args)
    //    {
    //        int[] marks = new int[3] { 33, 44, 55 };
    //        //marks[0] = 1;
    //        //marks[1] = 2;
    //        //marks[2] = 3;

    //        Console.WriteLine(marks[0] + " " + marks[1] + " " + marks[2]);
    //    }
    //}
    //class Program3
    //{
    //    static void Main6()
    //    {
    //        int[,] marks = new int[4, 2];
    //        marks[0, 0] = 11; marks[0, 1] = 22;
    //        marks[1, 0] = 2;      marks[1, 1] = 3;   
    //        marks[2,0] = 3;
    //        marks[3,0] = 4;

    //        for (int i = 0; i < 4; i++)
    //        {
    //            for (int j=0;j<marks.Length;j++)
    //            {
    //            }

    //        }
    //    }
    //}
    using System;

    class Program4
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[2][];
            arr[0] = new int[5] { 10, 20, 30, 40, 50 };
            arr[1] = new int[3] { 33, 44, 55 };

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine(); // Move to the next line after printing each sub-array
            }
        }
    }


}