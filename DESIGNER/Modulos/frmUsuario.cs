using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BOL;  //Logica
using ENTITIES; //Estrutura
using DESIGNER.Tools;  // Herramientas
using CryptSharp;


namespace DESIGNER.Modulos
{
    public partial class frmUsuario : Form
    {

        // objeto "usuario" contiene las funciones/logicas => Registrar, Listar; Eliminar
        Usuario usuario = new Usuario();

        //objeto "entUsuario" contiene los datos => apellidos, nombres, email, clave, etc.
        EUsuario entUsuario = new EUsuario();

        string nivelAcceso = "INV";

        // Reservado un espacio de memoria para el objeto
        DataView dv;
       
        public frmUsuario()
        {
            InitializeComponent();
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Aviso.Preguntar("¿Estas seguro de guardar?") == DialogResult.Yes)
            {
                //ENCRIPTAR LA CLAVE
                string claveEncriptada = Crypter.Blowfish.Crypt(txtClave.Text.Trim());


                entUsuario.apellidos = txtApellidos.Text;
                entUsuario.nombres = txtNombres.Text;
                entUsuario.email = txtEmail.Text;
                entUsuario.claveAcceso = claveEncriptada;

                entUsuario.nivelAcceso = nivelAcceso;

                if (usuario.Registrar(entUsuario) > 0)
                {
                    reiniciarInterfaz();
                    actualizarDatos(); // actualiza datagrid
                    Aviso.Informar("Nuevo usuario registrado");
                }
                else
                {
                    Aviso.Advertir("No hemos podido terminar el registro");
                }


            }
        }

        private void reiniciarInterfaz()
        {
            txtApellidos.Clear();
            txtNombres.Clear();
            txtEmail.Clear();
            txtClave.Clear();
            optInvitado.Checked = true;
            nivelAcceso = "INV";
            txtApellidos.Focus();
            

        }

        private void optAdministrador_CheckedChanged(object sender, EventArgs e)
        {
            nivelAcceso = "ADM";
        }

        private void optInvitado_CheckedChanged(object sender, EventArgs e)
        {
            nivelAcceso = "INV";
        }



        //
        private void actualizarDatos()
        {
            dv = new DataView(usuario.Listar());
            
            gridUsuario.DataSource = dv;
            gridUsuario.Refresh();

            gridUsuario.Columns[0].Visible = false; // id
            gridUsuario.Columns[4].Visible = false; // clave

            gridUsuario.Columns[1].Width = 200;
            gridUsuario.Columns[2].Width = 200;
            gridUsuario.Columns[3].Width = 270;
            gridUsuario.Columns[5].Width = 150;

            // filas cebreadas  alternado
            gridUsuario.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            actualizarDatos();
        }

        private void gridUsuario_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            gridUsuario.ClearSelection();
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            dv.RowFilter = "apellidos LIKE '%" + txtBuscar.Text + "%' OR nombres LIKE '%" + txtBuscar.Text + "%'";
        }
    }
}
