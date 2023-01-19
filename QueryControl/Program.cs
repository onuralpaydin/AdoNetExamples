using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
           SqlConnection con = new SqlConnection(@"Server =ANK3-YZLMORT-08\SQLEXPRESS;Database =Northwind; User Id =sa; Password =sa;");
            con.Open();
            //Console.WriteLine("Lütfen eklemek istediğiniz Adı yazınız");
            //string ad = Console.ReadLine();
            //Console.WriteLine("Lütfen eklemek istediğiniz Adı yazınız");
            //string soyad = Console.ReadLine();
            //SqlCommand cmd = new SqlCommand("select * from Employees where EmployeeID=6", con);
            //SqlCommand cmd = new SqlCommand("INSERT INTO Employees (FirstName,LastName) VALUES ('Abdülkerim','Car')" , con);
            //SqlCommand cmd1 = new SqlCommand("INSERT INTO Employees (FirstName,LastName) VALUES (@ad,@soyad)", con);
            //cmd1.Parameters.AddWithValue("@ad",ad);
            //cmd1.Parameters.AddWithValue("@soyad",soyad);
            //cmd1.Parameters.Add("ad", SqlDbType.NVarChar).Value = ad;
            //cmd1.Parameters.Add("soyad",SqlDbType.NVarChar).Value = soyad;
            //cmd1.ExecuteNonQuery();
            SqlCommand cmd = new SqlCommand("select CategoryName,ProductName from Products p join Categories c on p.CategoryID=c.CategoryID", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(dr[0]+" "+ dr[1]);
            }
            Console.ReadKey();
        }
    }
}
