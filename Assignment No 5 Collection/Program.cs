

/*namespace Assignment_No_5_Collection
{
    public class Employee
    {
        public int EmpId;
        public string Name;
        public int Salary;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> myList = new List<Employee>();
            Program p = new Program();
            int choice;

            do
            {
                Console.WriteLine("Enter the Choice:");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Display Employees");
                Console.WriteLine("3. Display Employee with Highest Salary");
                Console.WriteLine("0. Exit");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Employee emp = p.AcceptRecord();
                        myList.Add(emp);
                        break;

                    case 2:
                        p.DisplayRecord(myList);
                        break;

                    case 3:
                        p.DisplayHighestSalary(myList);
                        break;

                    case 0:
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter 0, 1, 2, or 3.");
                        break;
                }
            } while (choice != 0);
        }

        void DisplayRecord(List<Employee> myList)
        {
            myList.ForEach(e =>
            {
                Console.WriteLine($"Employee ID: {e.EmpId}");
                Console.WriteLine($"Name: {e.Name}");
                Console.WriteLine($"Salary: {e.Salary}");
                Console.WriteLine(); // For a blank line between records
            });
        }

        void DisplayHighestSalary(List<Employee> myList)
        {
            if (myList.Count == 0)
            {
                Console.WriteLine("No employees in the list.");
                return;
            }

            Employee highestSalaryEmployee = myList[0];

            foreach (Employee e in myList)
            {
                if (e.Salary > highestSalaryEmployee.Salary)
                {
                    highestSalaryEmployee = e;
                }
            }

            Console.WriteLine("Employee with the highest salary:");
            Console.WriteLine($"Employee ID: {highestSalaryEmployee.EmpId}");
            Console.WriteLine($"Name: {highestSalaryEmployee.Name}");
            Console.WriteLine($"Salary: {highestSalaryEmployee.Salary}");
            Console.WriteLine(); // For a blank line after the record
        }

        Employee AcceptRecord()
        {
            Employee emp = new Employee();

            Console.WriteLine("Enter the EmpId: ");
            emp.EmpId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Name: ");
            emp.Name = Console.ReadLine();

            Console.WriteLine("Enter the Salary: ");
            emp.Salary = int.Parse(Console.ReadLine());

            return emp;
        }
    }
}*/


/*using System.ComponentModel.DataAnnotations;

namespace Assignment_No_5_Collection
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public int Basic { get; set; }

        public override string ToString()
        {
            return $"EmpId={EmpId}, Name={Name}, Basic={Basic}";
        }
    }
    internal class Program
    {
        static void Main()
            {
                Employee[] emp = new Employee[10];
                emp[0] = new Employee { EmpId = 101, Name = "Rohan", Basic = 1000000 };
                 emp[1] = new Employee { EmpId = 102, Name = "rj", Basic = 1000000 };

                List<Employee> e1 = new List<Employee>(emp);

                Program.Display(e1);
            }

        static void Display(List<Employee> e1)
            {
                foreach (var item in e1)
                {
                    Console.WriteLine(item);
                }
            }
    }
}*/
using System.ComponentModel.DataAnnotations;

namespace Assignment_No_5_Collection
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public int Basic { get; set; }

        public override string ToString()
        {
            return $"EmpId={EmpId}, Name={Name}, Basic={Basic}";
        }
    }
    internal class Program
    {
        static void Main()
        {
            List<Employee> e1 = new List<Employee>
            {
                 new Employee { EmpId = 101, Name = "Rohan", Basic = 1000000 },
            new Employee { EmpId = 102, Name = "rj", Basic = 1000000 }
            };
            Employee[] emp = e1.ToArray();

            Program.Display(emp);
        }

        static void Display(Employee[] emp )
        {
            foreach (var item in emp)
            {
                Console.WriteLine(item);
            }
        }
    }
}



