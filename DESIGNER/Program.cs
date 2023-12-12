using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DESIGNER
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmLogin());
            //Application.Run(new Modulos.frmUsuario());
            //Application.Run(new frmEmpresa());
            Application.Run(new Modulos.frmProducto());
            //Application.Run(new Reportes.frmVisorReportes());
        }
    }
}
