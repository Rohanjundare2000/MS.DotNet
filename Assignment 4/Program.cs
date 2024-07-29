using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using System.Xml.Linq;

//1.CDAC has certain number of batches. each batch has certain number of students
//         accept number of batches. for each batch accept number of students.
//         create an array to store mark for each student (1 student has only 1 subject mark)
//        accept the marks.
//        display the marks.
namespace Assignment_4
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Enter the number of batches: ");
            int batch = int.Parse(Console.ReadLine());
            
            int Batch = 0;
            
                  
            Console.WriteLine($"Enter the number of students in batch {++Batch}: ");
            int Student = int.Parse(Console.ReadLine());

            int[] marks = new int[Student];

           
            for (int j = 0; j < batch; j++)
            {
                for (int i = 0; i <Student; i++)
                {
                    Console.WriteLine($"Enter the mark for student {i+1} in batch {j+1}:");
                    marks[i] = int.Parse(Console.ReadLine());
                }
            }

            for (int j = 0; j < batch; j++)
            {
                Console.WriteLine("Batch: " + j+1);

                for (int i = 0; i <Student; i++)
                {
                    Console.WriteLine($"Student {i + 1}: "+ marks[i]);

                }
            }

        }
    }

    //Enter the number of batches: 2
    //Enter the number of students in batch 1: 2
    //Enter the mark for student 1 in batch 1: 85
    //Enter the mark for student 2 in batch 1: 90
    //Enter the number of students in batch 2: 3
    //Enter the mark for student 1 in batch 2: 78
    //Enter the mark for student 2 in batch 2: 88
    //Enter the mark for student 3 in batch 2: 92

    //Displaying marks for each batch:
    //Batch 1:
    //Student 1: 85
    //Student 2: 90
    //Batch 2:
    //Student 1: 78
    //Student 2: 88
    //Student 3: 92
    
    public class Employee
    {
        public int EmpNo;
        public string Name;
        public int Salary;

    }
    internal class Program2
    {
        
        static void Main()
        {
            Console.WriteLine("Enter the number of employees: ");
            int NumEmp =int.Parse(Console.ReadLine());

            Employee[] employee = new Employee[NumEmp];

            for(int j =0; j <NumEmp; j++)
            {
                employee[j] = new Employee();

                Console.WriteLine($"Enter details for employee {j+1}:");
                Console.WriteLine($"Enter the EmpNo: ");
                employee[j].EmpNo = int.Parse(Console.ReadLine());

                Console.WriteLine($"Enter the Name: ");
                employee[j].Name = Console.ReadLine();

                Console.WriteLine($"Enter the Salary: ");
                employee[j].Salary = int.Parse(Console.ReadLine());

            }

            int high = employee[1].Salary;
            for (int j = 0; j < NumEmp; j++)
            {
                if(employee[j].Salary>high)
                {
                    Console.WriteLine("Employee with the highest salary:");
                    Console.WriteLine($"EmpNo:{employee[j].EmpNo}, Name:{employee[j].Name}, Salary:{employee[j].Salary}");
                }

            }
        }
    }



}
//Enter the number of employees: 3
//Enter details for employee 1:
//EmpNo: 101
//Name: Alice
//Salary: 50000
//Enter details for employee 2:
//EmpNo: 102
//Name: Bob
//Salary: 60000
//Enter details for employee 3:
//EmpNo: 103
//Name: Charlie
//Salary: 55000

//yaml
//Copy code
//Employee with the highest salary:
//EmpNo: 102, Name: Bob, Salary: 60000

//Enter EmpNo to search: 103

//Employee details:
//EmpNo: 103, Name: Charlie, Salary: 55000






