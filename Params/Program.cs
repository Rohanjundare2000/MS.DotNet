using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;

namespace Params
{
    internal class Program
    {
//It is used as a parameter which can take the variable number
//of arguments.
//•It is useful when programmer don’t have any prior knowledge about
//the number of parameters to be used.
//•Only one params keyword is allowed and no additional params will be
//allowed in function declaration after a params keyword.
//• The length of params will be zero if no arguments will be passed.
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 2, 3));
            Console.WriteLine(Add(1, 2, 3, 4, 5, 6, 7));
            Console.WriteLine(Add(1, 2, 3, 4, 5, 6, 7,8,9));
        }   
        static int Add(params int[] arr)
        {
            int sum = 0;
            foreach (int item in arr)
            {
                sum += item;
            }
            return sum;
        }
    }
}