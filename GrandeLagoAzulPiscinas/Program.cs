using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrandeLagoAzulPiscinas
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            fMain mainForm = new fMain();
            mainForm.WindowState = FormWindowState.Maximized;
            Application.Run(mainForm);
            
            //Application.Run(new MDIParent1()); 
        }
    }
}
