﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.entities;
namespace PMS.DAL
{
    public class userDao
    {
        public static List<userDTO> GetAllUser()
        {
    
                string sqlQuery = "select * from dbo.userTable";
            using (DBHelper helper = new DBHelper)
            {
                var reader = helper.ExecuteReader(sqlQuery);
                List<userDTO> dt = new List<userDTO>();
                while (reader.Read() == true)
                {
                    userDTO dto = new userDTO();
                    dto.id = reader.GetInt32(reader.GetOrdinal("userId"));
                    dto.name = reader.GetString(reader.GetOrdinal("userName"));
                    dto.login = reader.GetString(reader.GetOrdinal("login"));
                    dto.password = reader.GetString(reader.GetOrdinal("password"));
                    dto.gender = Convert.ToChar(reader.GetString(reader.GetOrdinal("gender")));
                    dto.adress = reader.GetString(reader.GetOrdinal("adress"));
                    dto.age = reader.GetInt32(reader.GetOrdinal("age"));
                    dto.nic = reader.GetString(reader.GetOrdinal("nic"));
                    dto.dob = reader.GetDateTime(reader.GetOrdinal("dob"));
                    dto.cricket = reader.GetBoolean(reader.GetOrdinal("cricket"));
                    dto.baseBall = reader.GetBoolean(reader.GetOrdinal("baseBall"));
                    dto.tennis = reader.GetBoolean(reader.GetOrdinal("tennis"));
                    dto.image = reader.GetString(reader.GetOrdinal("personImg"));
                    dto.email = reader.GetString(reader.GetOrdinal("email"));
                    if (dto != null)
                    {
                        dt.Add(dto);
                    }

                }
                return dt;

            }
        }

        public int save2(userDTO dto)
        {
            String connString = @"Data Source =SAIMA\SQLEXPRESS2012; Initial Catalog = loginDB; Integrated Security = True; Persist Security Info = True; ";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string sqlQuery = " ";

                sqlQuery = string.Format(@"INSERT INTO dbo.userTable(userId,userName,login,password,gender,age,adress,nic,dob,cricket,baseBall,tennis,personImg,email)
                                                                   VALUES(@USERID,@NAME,@LOGIN,@PASSWORD,@GENDER,@AGE,@ADRESS,@NIC,@DOB,@CRICKET,@BASEBALL,@TENNIS,@IMAGE,@EMAIL);");
                sqlQuery = sqlQuery + "select Scope_Identity()";
                SqlCommand command = new SqlCommand(sqlQuery, conn);


                SqlParameter param = new SqlParameter();
                param.ParameterName = "USERID";
                param.SqlDbType = System.Data.SqlDbType.Int;
                param.Value = dto.id;
                command.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "USERNAME";
                param.SqlDbType = System.Data.SqlDbType.Variant;
                param.Value = dto.name;
                command.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "LOGIN";
                param.SqlDbType = System.Data.SqlDbType.VarChar;
                param.Value = dto.login;
                command.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "PASSWORD";
                param.SqlDbType = System.Data.SqlDbType.VarChar;
                param.Value = dto.password;
                command.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "GENDER";
                param.SqlDbType = System.Data.SqlDbType.Char;
                param.Value = dto.gender;
                command.Parameters.Add(param);


                param = new SqlParameter();
                param.ParameterName = "AGE";
                param.SqlDbType = System.Data.SqlDbType.Int;
                param.Value = dto.age;
                command.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "ADRESS";
                param.SqlDbType = System.Data.SqlDbType.VarChar;
                param.Value = dto.adress;
                command.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "NIC";
                param.SqlDbType = System.Data.SqlDbType.VarChar;
                param.Value = dto.nic;
                command.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "DOB";
                param.SqlDbType = System.Data.SqlDbType.DateTime;
                param.Value = dto.dob;
                command.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "CRICKET";
                param.SqlDbType = System.Data.SqlDbType.Bit;
                param.Value = dto.cricket;
                command.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "BASEBALL";
                param.SqlDbType = System.Data.SqlDbType.Bit;
                param.Value = dto.baseBall;
                command.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "TENNIS";
                param.SqlDbType = System.Data.SqlDbType.Bit;
                param.Value = dto.tennis;
                command.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "IMAGE";
                param.SqlDbType = System.Data.SqlDbType.VarChar;
                param.Value = dto.image;
                command.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "EMAIL";
                param.SqlDbType = System.Data.SqlDbType.VarChar;
                param.Value = dto.email;
                command.Parameters.Add(param);
                int userid = 0;
                var v = command.ExecuteScalar();
                userid = Convert.ToInt32(v);



                return userid;








            }
        }
        public static int save(userDTO dto)
        {

            string sqlQuery = "";
            if (dto.id > 0)
            {
                sqlQuery = string.Format(@"update dbo.userTable SET userId='{0}',userName='{1}',login='{2}',password='{3}',gender='{4}',adress='{5}',age='{6}',nic='{6}',dob='{7}',cricket='{8}',baseBall='{9}',personImg='{10}',email='{11}'
WHERE userID{2}", dto.id, dto.name, dto.login, dto.password, dto.gender, dto.adress, dto.age, dto.nic, dto.dob, dto.cricket, dto.baseBall, dto.tennis, dto.image, dto.email);
            }
            else
            {
                sqlQuery = string.Format(@"INSERT INTO dbo.userTable(userId,userName,adress,nic, dob,,personImg,email)
VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", dto.id, dto.name, dto.adress, dto.nic, dto.dob, dto.image, dto.email);
                sqlQuery = sqlQuery + "; Select Scope_Identity()";
            }
            using (DBHelper helper = new DBHelper())
            {
                return helper.ExecuteQuery(sqlQuery);
            }
        }
        public static userDTO GetUserById(int pid)
        {
            var query = string.Format("Select * from dbo.userTable WHERE userId={0}", pid);
            using (DBHelper helper = new DBHelper())
            {
                var reader = helper.ExecuteReader(query);
                userDTO dto = null;
                if (reader.Read())
                {
                    dto = fillDTO(reader);
                }
                return dto;
            }
        }
        public static int delete(int pid)
        {
            string sqlQuery = string.Format("Update dbo.userTable WHERE userId={0}" , pid);
            using (DBHelper helper = new DBHelper())
            {
                return helper.ExecuteQuery(sqlQuery);
            }
        }
        private static userDTO fillDTO(SqlDataReader reader)
        {
            var dto = new userDTO();
            dto.id = reader.GetInt32(0);
            dto.name = reader.GetString(1);
            dto.password = reader.GetString(2);
            dto.login = reader.GetString(3);
            dto.gender = reader.GetChar(4);
            dto.adress = reader.GetString(5);
            dto.age = reader.GetInt32(6);
            dto.image = reader.GetString(7);
            dto.cricket = reader.GetBoolean(8);
            dto.baseBall = reader.GetBoolean(9);
            dto.tennis = reader.GetBoolean(10);
            dto.email = reader.GetString(11);
            return dto;

        }
    }
}
