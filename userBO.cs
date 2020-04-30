using PMS.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
namespace PMS.BAL
{
    public class userBO
    {
        public static List<userDTO> GetAllUser()
        {
            return PMS.DAL.userDao.GetAllUser();
        }
        public static int save(userDTO dto)
        {
            return PMS.DAL.userDao.save(dto);
        }
        
        public static int delete(int pid)
        {
            return PMS.DAL.userDao.delete(pid);
        }
        public static userDTO GetUserById(int pid)
        {
            return PMS.DAL.userDao.GetUserById(pid);
        }

    }
}
