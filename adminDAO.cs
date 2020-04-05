using PMS.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.DAL
{
    class adminDAO
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
                    dto.password = reader.GetString(reader.GetOrdinal("password"));

                    if (dto != null)
                    {
                        dt.Add(dto);
                    }

                }
                return dt;

            }
        }
        public static int save(userDTO dto)
        {

            string sqlQuery = "";
            if (dto.id > 0)
            {
                sqlQuery = string.Format(@"update dbo.userTable SET userId='{0}',userName='{1}',password='{3}'
WHERE userID{2}", dto.id, dto.name, dto.password);
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
            string sqlQuery = string.Format("Update dbo.userTable WHERE userId={0}", pid);
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
