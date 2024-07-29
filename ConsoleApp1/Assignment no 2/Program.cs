using System.ComponentModel.DataAnnotations;
using static Assignment_no_2.Program;

namespace Assignment_no_2
{

    class Program
    {
        static void Main(string[] args)
        {
            Employee o1 = new Employee();
            Employee o2 = new Employee();
            Employee o3 = new Employee();

            Console.WriteLine(o1.EmpNo);
            Console.WriteLine(o2.EmpNo);
            Console.WriteLine(o3.EmpNo);

            Console.WriteLine(o3.EmpNo);
            Console.WriteLine(o2.EmpNo);
            Console.WriteLine(o1.EmpNo);
        }
    }
        public class Employee
        {
            private static int empNoCounter = 0;
            private readonly int empNo;
            private string name;
            private decimal basic;
            private short deptNo;

            public Employee(String name = null, int empNo = 0, decimal basic = 0, short deptNo = 0)
            {
            empNoCounter++;
                this.empNo = empNoCounter;
                this.name = name;
                this.basic = basic;
                this.deptNo = deptNo;
            
            }
            public string Name
            {
                set
                {
                    if (string.IsNullOrEmpty(name))
                        throw new ArgumentException("Name cannot be blank");
                    name = value;
                }
                get
                {
                    return name;
                }
            }
            public int EmpNo
            {
                get { return empNo; }
            }
            public decimal Basic
            {
                set
                {
                    if (basic > 100000 || basic < 10000)
                        throw new ArgumentException("Basic salary must be between 1000 and 100000");
                    basic = value;
                }
                get
                {
                    return basic;
                }
            }
            public short DeptNo
            {
                set
                {
                    if (deptNo > 0)
                        throw new ArgumentException("dept is greter than 1");
                    deptNo = value;
                }
                get
                {
                    return deptNo;
                }
            }


            public decimal GetNetSalary()
            {
                // Example formula for net salary: Basic - (Basic * 0.1) for taxes
                return basic - (basic * 0.1m);
            }

        }
    
}
