using System.ComponentModel.Design;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    
    class Employee
    {
        private int id;
        private string name;
        private double salary;
        private short deptNo;

        public string Name
        {
            set
            {
                if (value == null && value.Equals(" ")) 
                {
                    Console.WriteLine("Name is not allowed");
                }
                else
                {
                    name = value;
                }
            }
            get
            {
                return name;            
            }
        }

        public int Id
        {
            set
            {
                if (value > 0)
                {
                    id = value;
                }

            }
            get
            {
                return id;
            }

        }
       public double Salary
        {
            set
            {
                if(value >= 1000 && value<20000)
                {
                    salary = value;
                }
            }

            get
            {
                return salary;
            }
        }

        public short DeptNo
        {
            set
            {
                if (value > 0)
                    deptNo = value;
                else
                    Console.WriteLine("deptNo is less then 0");
            }
            get
            {
                return deptNo;

            }
        }

        //public double GetNetSalary()
        //{
           
        //}
    }






}21
