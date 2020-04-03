using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PRACTICE_EAD
{
    class DAL
    {
        public void ReadAndPrint()
        {
            string connString = @"Data Source =SAIMA\SQLEXPRESS2012; Initial Catalog = loginDB; Integrated Security = True; Persist Security Info = True; ";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string sqlQuery = "select * from dbo.userInfo";
                SqlCommand command = new SqlCommand(sqlQuery, conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read() == true)
                {
                    Int32 ID = reader.GetInt32(0);
                    string name = (string)reader.GetValue(1);
                    Int32 login = (Int32)reader.GetValue(2);
                    Int32 password = (Int32)reader.GetValue(3);
                    char gender = (char)reader.GetValue(4);
                    Int32 adress = (Int32)reader.GetValue(5);
                    int nic = (int)reader.GetValue(6);
                    DateTime dob = (DateTime)reader.GetValue(7);
                    // Int32 cricket = (Int32)reader.GetValue(8);
                    //Int32 tennis = (Int32)reader.GetValue(9);
                    // string img = (string)reader.GetValue(10);
                    Int32 email = (Int32)reader.GetValue(11);
                    Int32 age = (Int32)reader.GetValue(12);
                    Console.WriteLine("name is:{0}", reader.GetString(0));
                    Console.WriteLine("id is:{0}", reader.GetSqlValue(1));
                    Console.WriteLine("nic is:{0}", reader.GetString(2));
                    Console.WriteLine("dob is:{0}", reader.GetDateTime(3));
                    Console.WriteLine("userImage is:{0}", reader.GetString(4));

                }
            }

        }
        public void save(string pName , DateTime pDOB)
        {
            String connString = @"Data Source =SAIMA\SQLEXPRESS2012; Initial Catalog = loginDB; Integrated Security = True; Persist Security Info = True; ";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string sqlQuery = string.Format(@"INSERT INTO dbo.userInfo(userName , dob)
VALUES('{0}','{1}')", pName, pDOB);
                SqlCommand command = new SqlCommand(sqlQuery, conn);
               // int recAff = command.ExecuteNonQuery();
                //Console.WriteLine("records effected{0}", recAff);



            }


        }
        public void update(int pStudentId, string pName, DateTime pDOB)
        {
            String connString = @"Data Source =SAIMA\SQLEXPRESS2012; Initial Catalog = loginDB; Integrated Security = True; Persist Security Info = True; ";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string sqlQuery = string.Format(@"update dbo.userInfo SET userName='{0}',dob='{1}' WHERE userID{2}", pName, pDOB, pStudentId);

                SqlCommand command = new SqlCommand(sqlQuery, conn);
                int recaff = command.ExecuteNonQuery();
                Console.WriteLine("records effected{0}", recaff);

            }
        }
        public void delete(int pStudentID)
        {
            String connString = @"Data Source =SAIMA\SQLEXPRESS2012; Initial Catalog = loginDB; Integrated Security = True; Persist Security Info = True; ";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string sqlQuery = string.Format(@"delet from dbo.userInfo SET  WHERE userID{0}" , pStudentID);

                SqlCommand command = new SqlCommand(sqlQuery, conn);
                int recaff = command.ExecuteNonQuery();
                Console.WriteLine("records effected{0}", recaff);

            }

        }

    }
  
}
