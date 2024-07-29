namespace Camparable
{
    public class Emp: IComparable<Emp>
    {
        public int EmpId { set; get; }
        public string Name { set; get; }
        public int DeptNo { set; get; }
        public decimal Basic { set; get; }

        public int CompareTo(Emp? other)
        {
            if (this.Basic > other.Basic)
                return 1;
            else if (this.Basic < other.Basic)
                return -1;
            else
                return 0;
        }
        public override string ToString()
        {
            return $"EmpId={EmpId}, Name={Name}, Basic={Basic}, DeptNo={DeptNo}";

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Emp[] arr = new Emp[10];// user defined will not take any repeatation
            arr[0] = new Emp { EmpId = 5, Name = "Ananya", Basic = 12335, DeptNo = 10 };
            arr[1] = new Emp { EmpId = 1, Name = "Vikram", Basic = 22335, DeptNo = 20 };
            arr[2] = new Emp { EmpId = 2, Name = "Harsh", Basic = 22335, DeptNo = 20 };
            arr[1] = new Emp { EmpId = 1, Name = "Vikram", Basic = 22335, DeptNo = 20 };
            arr[2] = new Emp { EmpId = 2, Name = "Harsh", Basic = 22335, DeptNo = 20 }; ;
            Array.Sort<Emp>(arr);  //IComparable
            foreach (Emp emp in arr)
            {
                Console.WriteLine(emp);
            }
        }
    }
}
////public int CompareTo(Employee2? other)
////{
////    //return string.Compare(this.Name, other.Name);
////    if (this.Basic > other.Basic)
////        return 1;
////    else if (this.Basic < other.Basic)
////        return -1;
////    else
////        return 0;
////}
