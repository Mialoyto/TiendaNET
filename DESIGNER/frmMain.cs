using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DESIGNER
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
         // FINALIZA TODA LA APLICACION Y MODULOS-  ES UN EVENTO
        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
