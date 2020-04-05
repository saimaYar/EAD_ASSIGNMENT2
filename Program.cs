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
            userDTO dto = new userDTO();
            dto.id = 1;
            dto.name = "saima";
            dto.login = "saima";
           dto.password = "123";
            dto.gender = 'F';
            dto.adress = "lahore";
            dto.age = 20;
            dto.nic = "123";
            dto.dob = DateTime.Now.AddYears(-33);
            var id=obj.save2(dto);
           

            List<userDTO> list = obj.GetAllUser();
            foreach(var dt in list)
            {
                Console.WriteLine("id is:{0}", dt.id);
                Console.WriteLine("name is:{0}", dt.name);
                Console.WriteLine("password is:{0}", dt.password);
                Console.WriteLine("login is:{0}", dt.login);
                Console.WriteLine("adress is:{0}", dt.adress);
                Console.WriteLine("age is:{0}", dt.age);
                Console.WriteLine("gender is:{0}", dt.gender);
                Console.WriteLine("nic is:{0}", dt.nic);
                Console.WriteLine("dob is:{0}", dt.dob.ToShortDateString());
                
                
            }



            System.Console.ReadKey();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
