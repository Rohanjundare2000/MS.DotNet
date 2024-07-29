/*namespace LinQ_Query
{
    internal class Program
    {
        static List<Employee> lstEmp = new List<Employee>();
        static List<Department> lstDept = new List<Department>();
        public static void AddRecs()
        {
            lstDept.Add(new Department { DeptNo = 10, DeptName = "SALES" });
            lstDept.Add(new Department { DeptNo = 20, DeptName = "MKTG" });
            lstDept.Add(new Department { DeptNo = 30, DeptName = "IT" });
            lstDept.Add(new Department { DeptNo = 40, DeptName = "HR" });

            lstEmp.Add(new Employee { EmpNo = 1, Name = "Vikram", Basic = 10000, DeptNo = 10, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 2, Name = "Vishal", Basic = 11000, DeptNo = 10, Gender = "M" });

            lstEmp.Add(new Employee { EmpNo = 3, Name = "Abhijit", Basic = 12000, DeptNo = 20, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 4, Name = "Mona", Basic = 11000, DeptNo = 20, Gender = "F" });
            lstEmp.Add(new Employee { EmpNo = 5, Name = "Shweta", Basic = 12000, DeptNo = 20, Gender = "F" });

            lstEmp.Add(new Employee { EmpNo = 6, Name = "Sanjay", Basic = 11000, DeptNo = 30, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 7, Name = "Arpan", Basic = 10000, DeptNo = 30, Gender = "M" });

            lstEmp.Add(new Employee { EmpNo = 8, Name = "Shraddha", Basic = 11000, DeptNo = 40, Gender = "F" });
        }
        *//*static void Main()
        {
            AddRecs();
           *//* var emps = from emp in lstEmp select emp;
            foreach (var item in emps)
            {
                Console.WriteLine(item);
            }*/
/*// var returnvalue = from single_object in collection select something
var emps = from emp in lstEmp select emp;
//IEnumerable<Employee> emps = from emp in lstEmp select emp;
foreach (var item in emps)
{
    Console.WriteLine(item);
}*//*

var demps = from demp in lstDept select demp;
foreach(var item in demps)
{
    Console.WriteLine(item);
}

}*/
/*static void Main()
{
    AddRecs();
    //var emps = from emp in lstEmp select emp.Name;
    *//*var emps = from emp in lstEmp select emp.EmpNo;
    foreach (var item in emps)
    {
        Console.WriteLine(item);
    }*//*

    var emps1 = from emp in lstEmp select emp.Name;
    foreach(var item in emps1)
    {
        Console.WriteLine(item);
    }
}*/
/* static void Main()
 {  
     AddRecs();
     var emps = from emp in lstEmp select new { emp.Name, emp.EmpNo };
     //var emps = from emp in lstEmp select (emp.Name, emp.EmpNo);
     foreach (var item in emps)
     {
         Console.WriteLine(item.EmpNo);
         Console.WriteLine(item.Name);
     }

     var demp = from dmp in lstDept select new {dmp.DeptName,dmp.DeptNo};
     foreach(var item in demp)
     {
         Console.WriteLine(item.DeptName);
         Console.WriteLine(item.DeptNo);
     }
 }*/
/*static void Main()
{
    AddRecs();
    *//*var emps = from emp in lstEmp
               where emp.Basic > 10000
               select emp;
    var dmps = from dmp in lstDept
               where dmp.DeptNo > 20
               select dmp;*//*
    var emps = from emp in lstEmp
               where emp.Basic > 10000 && emp.Basic < 12000
               select emp;
    var dom = from demp in lstDept
               where demp.DeptNo>=20  && demp.DeptNo<=40
               select demp;
    //var emps = from emp in lstEmp
    //           where emp.Name.StartsWith("V")
    //           select emp;
    foreach (var emp in emps)
    {
        Console.WriteLine(emp);
    }

    foreach (var item in dom)
    {
        Console.WriteLine(item);
    }
    Console.ReadLine();
}*/
/*     static void Main()
     {
         AddRecs();


         var emps = from emp in lstEmp
                        //where emp.Basic > 10000
                    orderby emp.Name
                    select emp;
         var demps = from demp in lstDept
                     orderby demp.DeptNo descending
                     select demp;

         //var emps = from emp in lstEmp
         //           orderby emp.Name descending
         //           select emp;

         //var emps = from emp in lstEmp
         //           orderby emp.DeptNo ascending, emp.Name descending
         //           select emp;

         foreach (var demp in demps)
         {
             Console.WriteLine(demp);
         }

         foreach (var emp in emps)
         {
             Console.WriteLine(emp);
         }

         Console.ReadLine();

     }*//*
static void Main6()
{
    AddRecs();



    var emps = from emp in lstEmp
               join dept in lstDept
               on emp.DeptNo equals dept.DeptNo
               select emp;

    var emp2 = from emp in lstEmp
               join dept in lstDept
               on emp.DeptNo equals dept.DeptNo
               select emp;

    var emps1 = from emp in lstEmp
                join dept in lstDept
                on emp.DeptNo equals dept.DeptNo
                select dept;

    var emps2 = from emp in lstEmp
                join dept in lstDept
                on emp.DeptNo equals dept.DeptNo
                select new { emp, dept };

    var emps3 = from emp in lstEmp
                join dept in lstDept
                on emp.DeptNo equals dept.DeptNo
                select new { emp.Name, dept.DeptName };
    foreach (var item in emps2)
    {
        Console.WriteLine(item.emp.Name);
        Console.WriteLine(item.dept.DeptName);

    }
    foreach (var item in emps2)
    {
        Console.WriteLine(item.emp.Name);
        Console.WriteLine(item.dept.DeptName);
    }
    foreach (var item in emps3)
    {
        Console.WriteLine(item.Name);
        Console.WriteLine(item.DeptName);
    }
    Console.ReadLine();
}
}

public class Employee
{
    public int EmpNo { get; set; }
    public string Name { get; set; }
    public decimal Basic { get; set; }
    public int DeptNo { get; set; }
    public string Gender { get; set; }
    public override string ToString()
    {
        string s = Name + "," + EmpNo.ToString() + "," + Basic.ToString() + "," + DeptNo.ToString();
        return s;
    }
}
public class Department
{
    public int DeptNo { get; set; }
    public string DeptName { get; set; }
}

}
}*/

namespace LinqExample2
{
    internal class Program
    {
        static List<Employee> lstEmp = new List<Employee>();
        static List<Department> lstDept = new List<Department>();
        public static void AddRecs()
        {
            lstDept.Add(new Department { DeptNo = 10, DeptName = "SALES" });
            lstDept.Add(new Department { DeptNo = 20, DeptName = "MKTG" });
            lstDept.Add(new Department { DeptNo = 30, DeptName = "IT" });
            lstDept.Add(new Department { DeptNo = 40, DeptName = "HR" });

            lstEmp.Add(new Employee { EmpNo = 1, Name = "Vikram", Basic = 10000, DeptNo = 10, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 2, Name = "Vishal", Basic = 11000, DeptNo = 10, Gender = "M" });

            lstEmp.Add(new Employee { EmpNo = 3, Name = "Abhijit", Basic = 12000, DeptNo = 20, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 4, Name = "Mona", Basic = 11000, DeptNo = 20, Gender = "F" });
            lstEmp.Add(new Employee { EmpNo = 5, Name = "Shweta", Basic = 12000, DeptNo = 20, Gender = "F" });

            lstEmp.Add(new Employee { EmpNo = 6, Name = "Sanjay", Basic = 11000, DeptNo = 30, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 7, Name = "Arpan", Basic = 10000, DeptNo = 30, Gender = "M" });

            lstEmp.Add(new Employee { EmpNo = 8, Name = "Shraddha", Basic = 11000, DeptNo = 40, Gender = "F" });
        }

        static Employee GetAllEmployees(Employee obj)
        {
            return obj;
        }
        static void Main1()
        {
            AddRecs();
            var emps = lstEmp.Select(GetAllEmployees);
            var emps2 = lstEmp.Select(delegate (Employee obj)
            {
                return obj;
            });
            var empr = lstEmp.Select(obj => obj);
            var emps3 = lstEmp.Select(obj => obj);
            //var emps = from emp in lstEmp select emp;
            foreach (var item in empr)
            {
                Console.WriteLine(item);
            }
        }
        static string GetName(Employee obj)
        {
            return obj.Name;
        }
        static void Main()
        {
            AddRecs();
            //var emps = from emp in lstEmp select emp.Name;
            var emps = lstEmp.Select(GetName);
            var emps2 = lstEmp.Select(delegate (Employee obj)
            {
                return obj.Name;
            });
            var emps3 = lstEmp.Select(obj => obj.Name);

            foreach (var item in emps)
            {
                Console.WriteLine(item);
            }
        }
        static void Main3()
        {
            AddRecs();
            var emps = from emp in lstEmp select new { emp.Name, emp.EmpNo };
            var emps2 = lstEmp.Select(delegate (Employee obj)
            {
                return new { obj.Name, obj.EmpNo };
            });
            var emps3 = lstEmp.Select(obj => new { obj.Name, obj.EmpNo });

            foreach (var item in emps)
            {
                Console.WriteLine(item.EmpNo);
                Console.WriteLine(item.Name);
            }
        }

        static bool IsBasicGreaterThan10000(Employee obj)
        {
            return obj.Basic > 10000;
            //if (obj.Basic > 10000)
            //    return true;
            //else
            //    return false;
        }
        static void Main4()
        {
            AddRecs();
            var emps = from emp in lstEmp
                       where emp.Basic > 10000
                       select emp;

            var emps2 = lstEmp.Where(IsBasicGreaterThan10000);
            var emps3 = lstEmp.Where(delegate (Employee obj)
            {
                return obj.Basic > 10000;
            });
            var emps4 = lstEmp.Where(obj => obj.Basic > 10000);

            foreach (var emp in emps)
            {
                Console.WriteLine(emp);
            }

            Console.ReadLine();

        }
        static void Main4a()
        {
            AddRecs();

            //var emps1 = lstEmp.Where(obj => obj.Basic > 10000);
            //var emps2 = lstEmp.Where(obj => obj.Basic > 10000).Select(obj => obj);
            //var emps3 = lstEmp.Select(obj => obj).Where(obj => obj.Basic > 10000);


            //var emps2 = lstEmp.Where(obj => obj.Basic > 10000).Select(obj => obj.Name);
            //error     //var emps3 = lstEmp.Select(obj => obj.Name).Where(obj => obj.Basic > 10000);

            var emps2 = lstEmp.Where(obj => obj.Basic > 10000).Select(obj => obj.Basic);
            // var emps3 = lstEmp.Select(obj => obj.Basic).Where(obj => obj.Basic > 10000);
            //var emps3 = lstEmp.Select(obj => obj.Basic).Where(obj => obj > 10000);



            foreach (var emp in emps2)
            {
                Console.WriteLine(emp);
            }

            Console.ReadLine();

        }
        static void Main5()
        {
            AddRecs();


            var emps = from emp in lstEmp
                           //where emp.Basic > 10000
                       orderby emp.Name
                       select emp;

            var empsa = lstEmp.OrderBy(emp => emp.Name);

            //var emps = from emp in lstEmp
            //           orderby emp.Name descending
            //           select emp;
            var empsb = lstEmp.OrderByDescending(emp => emp.Name);

            //var emps = from emp in lstEmp
            //           orderby emp.DeptNo ascending, emp.Name descending
            //           select emp;
            //var empsc = lstEmp.OrderBy(emp => emp.DeptNo).OrderByDescending(emp => emp.Name); //WRONG
            var empsc = lstEmp.OrderBy(emp => emp.DeptNo).ThenByDescending(emp => emp.Name); //WRONG



            foreach (var emp in emps)
            {
                Console.WriteLine(emp);
            }
            Console.ReadLine();

        }
        static void Main6a()
        {
            AddRecs();



            var emps = from emp in lstEmp
                       join dept in lstDept
                             on emp.DeptNo equals dept.DeptNo
                       select emp;

            var emps1 = from emp in lstEmp
                        join dept in lstDept
                              on emp.DeptNo equals dept.DeptNo
                        select dept;

            var emps2 = from emp in lstEmp
                        join dept in lstDept
                              on emp.DeptNo equals dept.DeptNo
                        select new { emp, dept };

            var emps3 = from emp in lstEmp
                        join dept in lstDept
                              on emp.DeptNo equals dept.DeptNo
                        select new { emp.Name, dept.DeptName };
            foreach (var item in emps2)
            {
                Console.WriteLine(item.emp.Name);
                Console.WriteLine(item.dept.DeptName);

            }
            foreach (var item in emps2)
            {
                Console.WriteLine(item.emp.Name);
                Console.WriteLine(item.dept.DeptName);
            }
            foreach (var item in emps3)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.DeptName);
            }
            Console.ReadLine();
        }
        static void Main6()
        {
            AddRecs();

            //var emps = from emp in lstEmp
            //           join dept in lstDept
            //                 on emp.DeptNo equals dept.DeptNo
            //           select emp;

            //IEnumerable<TInner> ---> lstDept ---> IEnumerable<Department>

            //var emps = from  in 
            //           join  in 
            //                 on equals 
            //           select emp;
            var emps = lstEmp.Join(lstDept, emp => emp.DeptNo, dept => dept.DeptNo, (emp, dept) => emp);
            var emps2a = lstEmp.Join(lstDept, emp => emp.DeptNo, dept => dept.DeptNo, (emp, dept) => emp);
            var emps2b = lstEmp.Join(lstDept, emp => emp.DeptNo, dept => dept.DeptNo, (emp, dept) => dept);
            var emps2c = lstEmp.Join(lstDept, emp => emp.DeptNo, dept => dept.DeptNo, (emp, dept) => emp.DeptNo);
            var emps2d = lstEmp.Join(lstDept, emp => emp.DeptNo, dept => dept.DeptNo, (emp, dept) => dept.DeptNo);
            var emps2e = lstEmp.Join(lstDept, emp => emp.DeptNo, dept => dept.DeptNo, (emp, dept) => new { emp, dept });
            var emps2f = lstEmp.Join(lstDept, emp => emp.DeptNo, dept => dept.DeptNo, (emp, dept) => new { emp.Name, dept.DeptName });

            foreach (var item in emps2e)
            {
                Console.WriteLine(item.emp.Name);
                Console.WriteLine(item.dept.DeptName);

            }
            foreach (var item in emps2f)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.DeptName);
            }
        }
    }

    public class Employee
    {
        public int EmpNo { get; set; }
        public string Name { get; set; }
        public decimal Basic { get; set; }
        public int DeptNo { get; set; }
        public string Gender { get; set; }
        public override string ToString()
        {
            string s = Name + "," + EmpNo.ToString() + "," + Basic.ToString() + "," + DeptNo.ToString();
            return s;
        }
    }
    public class Department
    {
        public int DeptNo { get; set; }
        public string DeptName { get; set; }
    }

}