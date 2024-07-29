using System;

namespace Assignment3
{
    public interface IDbFunctions
    {
        void Insert();
        void Update();
        void Delete();
    }

    public abstract class Employee : IDbFunctions
    {
        private static int empCounter = 0;
        private string name;
        private readonly int empNo;
        private short deptNo;

        public Employee(string name=null, short deptNo=0)
        {
            this.Name = name;
            this.DeptNo = deptNo;
            this.empNo = ++empCounter;
        }

        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be blank");
                }
                name = value;
            }
        }

        public int EmpNo => empNo;

        public short DeptNo
        {
            get => deptNo;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Department Number must be greater than 0");
                }
                deptNo = value;
            }
        }

        public abstract decimal Basic { get; set; }

        public abstract decimal CalcNetSalary();

        public void Insert()
        {
            Console.WriteLine("Inserting employee record into database...");
        }

        public void Update()
        {
            Console.WriteLine("Updating employee record in database...");
        }

        public void Delete()
        {
            Console.WriteLine("Deleting employee record from database...");
        }
    }

    public class Manager : Employee
    {
        private string designation;
        private decimal basic;

        public Manager(string name, short deptNo, string designation) : base(name, deptNo)
        {
            this.Designation = designation;
        }

        public Manager(string name, string designation) : this(name, 1, designation) { }

        public Manager(string name) : this(name, 1, "Manager") { }

        public string Designation
        {
            get => designation;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Designation cannot be blank");
                }
                designation = value;
            }
        }

        public override decimal Basic
        {
            get => basic;
            set
            {
                if (value < 2000 || value > 80000)
                {
                    throw new ArgumentException("Basic salary for Manager must be between 2000 and 80000");
                }
                basic = value;
            }
        }

        public override decimal CalcNetSalary()
        {
            return Basic - (Basic * 0.1m);
        }
    }

    public class GeneralManager : Manager
    {
        private string perks;
        private decimal basic;

        public GeneralManager(string name, short deptNo, string designation, string perks) : base(name, deptNo, designation)
        {
            this.Perks = perks;
        }

        public GeneralManager(string name, string designation, string perks) : this(name, 1, designation, perks) { }

        public GeneralManager(string name, string designation) : this(name, 1, designation, "Standard Perks") { }

        public string Perks
        {
            get => perks;
            set => perks = value;
        }

        public override decimal Basic
        {
            get => basic;
            set
            {
                if (value < 3000 || value > 90000)
                {
                    throw new ArgumentException("Basic salary for General Manager must be between 3000 and 90000");
                }
                basic = value;
            }
        }

        public override decimal CalcNetSalary()
        {
            return Basic - (Basic * 0.1m) + 1000; 
        }
    }

    public class CEO : Employee
    {
        private decimal basic;

        public CEO(string name, short deptNo) : base(name, deptNo) { }

        public CEO(string name) : this(name, 1) { }

        public override decimal Basic
        {
            get => basic;
            set
            {
                if (value < 5000 || value > 100000)
                {
                    throw new ArgumentException("Basic salary for CEO must be between 5000 and 100000");
                }
                basic = value;
            }
        }

        public override sealed decimal CalcNetSalary()
        {
                return Basic - (Basic * 0.1m) + 2000; 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee o1 = new Manager("Amol", 10, "Manager");
            Employee o2 = new GeneralManager("Vijay", 20, "General Manager", "Car, House");
            Employee o3 = new CEO("John");

            Console.WriteLine(o1.EmpNo);
            Console.WriteLine(o2.EmpNo);
            Console.WriteLine(o3.EmpNo);

            Console.WriteLine(o1.CalcNetSalary());
            Console.WriteLine(o2.CalcNetSalary());
            Console.WriteLine(o3.CalcNetSalary());

            o1.Insert();
            o2.Update();
            o3.Delete();
        }
    }
}
