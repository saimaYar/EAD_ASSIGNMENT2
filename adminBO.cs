using PMS.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
namespace PMS.BAL
{
    public class adminBO
    {
        public static List<adminDTO> GetAllUser()
        {
            return PMS.DAL.adminDao.GetAllUser();
        }
        public static int save(adminDTO dto)
        {
            return PMS.DAL.adminDao.save(dto);
        }
        
        public static int delete(int pid)
        {
            return PMS.DAL.adminDao.delete(pid);
        }
        public static adminDTO GetUserById(int pid)
        {
            return PMS.DAL.adminDao.GetUserById(pid);
        }

    }
}
