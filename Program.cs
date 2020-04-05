using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PRACTICE_EAD
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DAL obj = new DAL();
            var dto = new PMS.entities.userDTO();
            dto.id = 1;
            dto.name = "saima";
            dto.login = "saima";
           dto.password = "123";
            dto.gender = 'F';
            dto.image = "pakistan.jpg";
            dto.adress = "lahore";
            dto.age = 20;
            dto.nic = "123";
            dto.dob = DateTime.Now.AddYears(-33);
            dto.email = "saima@gmail.com";
            // var id=obj.save2(dto);
            PMS.BAL.userBO.save(dto);
            var data=PMS.BAL.userBO.GetAllUser();
           var del= PMS.BAL.userBO.delete(1);
            var prod=PMS.BAL.userBO.GetUserById(1);
             System.Console.ReadKey();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
