using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BOL;
using ENTITIES;
using DESIGNER.Tools;


namespace DESIGNER
{
    public partial class frmEmpresa : Form
    {
        Empresa empresa = new Empresa();

        EEmpresa entEmpresa = new EEmpresa();

        DataView dv;
        
        public frmEmpresa()
        {
            InitializeComponent();
        }

        private void frmEmpresa_Load(object sender, EventArgs e)
        {
            actualizarEmpresa();
        }

        private void btnGuardarEmp_Click(object sender, EventArgs e)
        {
            if(Aviso.Preguntar("¿Esta seguro de guardar esta empresa?") == DialogResult.Yes)
            {
                entEmpresa.razonsocial = txtRazonSocial.Text;
                entEmpresa.ruc = txtRuc.Text;
                entEmpresa.direccion = txtDireccion.Text;
                entEmpresa.telefono = txtTelefono.Text;
                entEmpresa.email = txtEmailEmpresa.Text;
                entEmpresa.website = txtWeb.Text;

                //empresa.RegistrarEmp(entEmpresa);
                //System.Windows.Forms.MessageBox.Show(num.ToString());

                if (empresa.RegistrarEmp(entEmpresa) > 0)
                {
                    reiniciarInterfaz();
                    actualizarEmpresa();
                    Aviso.Informar("Nueva empresa registrada");
                }
                else
                {
                    Aviso.Advertir("No se puedo completar el registro");
                }
            }
        }

        private void actualizarEmpresa()
        {
            dv = new DataView(empresa.Listar());

            gridEmpresa.DataSource = dv;
            gridEmpresa.Refresh();

            gridEmpresa.Columns[0].Visible = false;

            gridEmpresa.Columns[1].Width = 200;
            gridEmpresa.Columns[2].Width = 200;
            gridEmpresa.Columns[3].Width = 200;
            gridEmpresa.Columns[4].Width = 200;
            gridEmpresa.Columns[5].Width = 200;
            gridEmpresa.Columns[6].Width = 200;
        }

        private void reiniciarInterfaz()
        {
            txtRazonSocial.Clear();
            txtRuc.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEmailEmpresa.Clear();
            txtWeb.Clear();

            txtRazonSocial.Focus();
        }
    }

    
}
