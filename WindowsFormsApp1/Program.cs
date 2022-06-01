using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            CustomConfig customconfig = new CustomConfig();

            //Config
            int versionProgramm = 2;
            int registeron = 1;

            //CheckConfig
            customconfig.checkVersion(versionProgramm);
            customconfig.checkdbregisteron(registeron);

            //Запуск приложения
            Application.Run(new LoginForm(registeron));
        }
    }
}
