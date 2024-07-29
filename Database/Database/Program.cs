using Microsoft.Data.SqlClient;

namespace DatabaseCode
{
    internal class Program
    {
        static void Main()
        {
           // Connect();
            //Insert1();
           Employee obj = new Employee { EmpNo = 7, Name = "Alfredlo", Basic = 999, DeptNo = 3 };
            //Insert2(obj);
            //InsertWithParameters(obj);
             InsertWithStoredProcedure(obj);
            //delete(1);
            //Update("revati",10,10,3
            UpdateWithStoredProcedure(obj)
        }
        static void delete(int empNo)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=JKJune2024;Integrated Security=True";
                cn.Open();
                SqlCommand cmdDelete = new SqlCommand();
                cmdDelete.Connection = cn;
                cmdDelete.CommandType = System.Data.CommandType.Text;
                cmdDelete.CommandText = "DELETE FROM Employees WHERE EmpNo = @EmpNo;";
                cmdDelete.Parameters.AddWithValue("@EmpNo", empNo);
                cmdDelete.ExecuteNonQuery();
                Console.WriteLine("wokay");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
            }

        }

        static void Update(string Name, decimal Basic, int DeptNo,int EmpNo)
        {
            SqlConnection cn= new SqlConnection();
            try
            {
                cn.ConnectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=JKJune2024;Integrated Security=True";
                cn.Open();
                SqlCommand cmdUpdate = new SqlCommand();
                cmdUpdate.Connection = cn;
                cmdUpdate.CommandType = System.Data.CommandType.Text;
                cmdUpdate.CommandText = "Update Employees set Name= @Name, Basic= @Basic, DeptNo = @DeptNo where EmpNo = @EmpNo ";
                cmdUpdate.Parameters.AddWithValue("@Name", Name);
                cmdUpdate.Parameters.AddWithValue("@Basic", Basic);
                cmdUpdate.Parameters.AddWithValue("@DeptNo", DeptNo);
                cmdUpdate.Parameters.AddWithValue("@EmpNo", EmpNo);
                cmdUpdate.ExecuteNonQuery();
                Console.WriteLine("wokay");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        static void Connect()
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=JKJune2024;Integrated Security=True";
                cn.Open();
                Console.WriteLine("success");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Not Connected");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        static void Insert1()
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=JKJune2024;Integrated Security=True";
                cn.Open();
                SqlCommand cmdInsert = new SqlCommand();
                cmdInsert.Connection = cn;
                cmdInsert.CommandType = System.Data.CommandType.Text;
                cmdInsert.CommandText = "insert into Employees values (3, 'Pradeep', 1200, 30)";
                cmdInsert.ExecuteNonQuery();
                Console.WriteLine("wokay");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        static void Insert2(Employee obj)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=JKJune2024;Integrated Security=True";
                cn.Open();
                SqlCommand cmdInsert = new SqlCommand();
                cmdInsert.Connection = cn;
                cmdInsert.CommandType = System.Data.CommandType.Text;
                cmdInsert.CommandText = $"insert into Employees values ({obj.EmpNo}, '{obj.Name}', {obj.Basic}, {obj.DeptNo})";
                Console.WriteLine(cmdInsert.CommandText);
                Console.ReadLine();
                cmdInsert.ExecuteNonQuery();
                Console.WriteLine("wokay");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
       
        static void InsertWithParameters(Employee obj)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=JKJune2024;Integrated Security=True";
                cn.Open();
                SqlCommand cmdInsert = new SqlCommand();
                cmdInsert.Connection = cn;
                cmdInsert.CommandType = System.Data.CommandType.Text;
                cmdInsert.CommandText = "insert into Employees values (@EmpNo, @Name, @Basic, @DeptNo)";

                cmdInsert.Parameters.AddWithValue("@EmpNo", obj.EmpNo);
                cmdInsert.Parameters.AddWithValue("@Name", obj.Name);
                cmdInsert.Parameters.AddWithValue("@Basic", obj.Basic);
                cmdInsert.Parameters.AddWithValue("@DeptNo", obj.DeptNo);

                cmdInsert.ExecuteNonQuery();
                Console.WriteLine("wokay");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        static void InsertWithStoredProcedure(Employee obj)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=JKJune2024;Integrated Security=True";
                cn.Open();
                SqlCommand cmdInsert = new SqlCommand();
                cmdInsert.Connection = cn;
                cmdInsert.CommandType = System.Data.CommandType.StoredProcedure;
                cmdInsert.CommandText = "InsertEmployee";

                cmdInsert.Parameters.AddWithValue("@EmpNo", obj.EmpNo);
                cmdInsert.Parameters.AddWithValue("@Name", obj.Name);
                cmdInsert.Parameters.AddWithValue("@Basic", obj.Basic);
                cmdInsert.Parameters.AddWithValue("@DeptNo", obj.DeptNo);

                cmdInsert.ExecuteNonQuery();
                Console.WriteLine("wokay");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        static List<Employee> GetAllEmployees()
        {
            List<Employee> list = new List<Employee>();
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=JKJune2024;Integrated Security=True";
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT EmpNo, Name, Basic, DeptNo FROM Employees";

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Employee obj = new Employee();
           catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
            }

            return list;
        }
        static void UpdateWithStoredProcedure(Employee obj)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=JKJune2024;Integrated Security=True";
                cn.Open();
                SqlCommand cmdUpdate = new SqlCommand();
                cmdUpdate.Connection = cn;
                cmdUpdate.CommandType = System.Data.CommandType.StoredProcedure;
                cmdUpdate.CommandText = "UpdateEmployee";

                cmdUpdate.Parameters.AddWithValue("@EmpNo", obj.EmpNo);
                cmdUpdate.Parameters.AddWithValue("@Name", obj.Name);
                cmdUpdate.Parameters.AddWithValue("@Basic", obj.Basic);
                cmdUpdate.Parameters.AddWithValue("@DeptNo", obj.DeptNo);

                cmdUpdate.ExecuteNonQuery();
                Console.WriteLine("Employee record updated successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

    }

    public class Employee
    {
        public int EmpNo { get; set; }
        public string Name { get; set; }
        public decimal Basic { get; set; }
        public int DeptNo { get; set; }
    }
}