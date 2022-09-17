using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace SignUp_SignIn.Models
{
    public class UserRepository
    {
        public static List<User> Users = new List< User > ();
       // public object db1 =new UserContext();
        public static void Add(User u)
        {
            //string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            //SqlConnection con = new SqlConnection(connString);
            var db = new UserContext();
            //con.Open();
            ////making select query for selecting required customers
            //string query = $"Insert into Admin (UserName,Pass) Values (@a,@b)";
            ////making sql paramters
            //SqlCommand cmd1 = new SqlCommand(query, con);
            //SqlParameter p1 = new SqlParameter("a", u.Username);
            //SqlParameter p2 = new SqlParameter("b", u.Password);

            ////adding parameters to cmd
            //cmd1.Parameters.Add(p1);
            //cmd1.Parameters.Add(p2);
            ////executing query
            //cmd1.ExecuteNonQuery();

            //con.Close();
            //Users.Add(u);
            db.Users.Add(u);
            db.SaveChanges();
        }
        public static bool Get(User u)
        {
            //string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            var db = new UserContext();
            //SqlConnection con = new SqlConnection(connString);
            //User u1=new User();
            //con.Open();
            ////making select query for selecting required customers
            //string query = $"Select * from Admin where Username=@a and Pass=@b";
            ////making sql paramters
            //SqlCommand cmd1 = new SqlCommand(query, con);
            //SqlParameter p1 = new SqlParameter("a", u.Username);
            //SqlParameter p2 = new SqlParameter("b", u.Password);
            //cmd1.Parameters.Add(p1);
            //cmd1.Parameters.Add(p2);
            //SqlDataReader dr = cmd1.ExecuteReader();
            //if (dr.HasRows)
            //{
            //   // while (dr.Read())
            //    {
            //        //u1.Username = dr[0].ToString();
            //        //u1.Password = dr[1].ToString();
            //        //Users.Add(u1);
            //    }
            //    return true;
            //}
            //else
            //    return false;
            // LinqToSQLDataContext db = new LinqToSQLDataContext(connectString);

            var users = db.Users.Any(x => x.Username.Equals(u.Username) && x.Password.Equals(u.Password));
            if (users)
                return true;
            else
                return false;
            //con.Close();
           
        }
       
    }
}
