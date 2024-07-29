using System;
using System.Collections.Generic;

namespace Compare
{
    public class Emp : IComparer<Emp>
    {
        public int EmpNo { get; set; }
        public string Name { get; set; }
        public decimal Basic { get; set; }
        public short DeptNo { get; set; }

        public int Compare(Emp? x, Emp? y)
        {
            if (x == null || y == null)
                throw new ArgumentException("Parameters cannot be null");

            if (x.Basic > y.Basic)
                return 1;
            else if (x.Basic < y.Basic)
                return -1;
            else
                return 0;
        }

        public override string ToString()
        {
            return $"EmpNo={EmpNo}, Name={Name}, Basic={Basic}, DeptNo={DeptNo}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Emp[] arr = new Emp[5]; // Define array size based on the number of unique elements
            arr[2] = new Emp { EmpNo = 2, Name = "Harsh", Basic = 22335, DeptNo = 20 };
            arr[3] = new Emp { EmpNo = 3, Name = "Ravi", Basic = 32335, DeptNo = 30 };
            arr[4] = new Emp { EmpNo = 4, Name = "Kiran", Basic = 42335, DeptNo = 40 };
            arr[0] = new Emp { EmpNo = 5, Name = "Ananya", Basic = 12335, DeptNo = 10 };
            arr[1] = new Emp { EmpNo = 1, Name = "Vikram", Basic = 22335, DeptNo = 20 };
            

            Array.Sort(arr, new Emp());

            foreach (Emp emp in arr)
            {
                if (emp != null)
                {
                    Console.WriteLine(emp);
                }
            }
        }
    }
}
// IComparer<Employee1>    =   Compare(Employee1? x, Employee1? y)
// It comes with the class of the IComparer which Consist of one method that is the Compare which
// compare the two object.


// IComparable<Employee2>  =   CompareTo(Employee2? other)
// It Comes with the class of the IComparable which consist of the one method  that is CompareTo
// which compare the single object with the other remaining object.