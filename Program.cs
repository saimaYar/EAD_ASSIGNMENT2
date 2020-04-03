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
            obj.save("saima 2", DateTime.Now);
            obj.update(2, "new user", DateTime.Now);
            obj.delete(2);
            obj.ReadAndPrint();



            System.Console.ReadKey();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
