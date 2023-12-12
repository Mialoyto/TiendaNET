using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//  INCLUIR LA LIBRERIAS
using CryptSharp;
using BOL;
using DESIGNER.Tools;  // TRAEMOS NUESTRAS PROPIAS HERRAMIENTAS

namespace DESIGNER
{
    public partial class frmLogin : Form
    {
        //INSTANCIA DE LA CLASE
        Usuario usuario = new Usuario();
        DataTable dtRpta = new DataTable();

        // CONSTRUCTOR
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Login()
        {
            // TRIM QUITA LOS ESPACIOS
            if (txtEmail.Text.Trim() == String.Empty)
            {
                errorLogin.SetError(txtEmail, "Por favor ingrese su email");
                txtEmail.Focus();
            }
            else
            {
                errorLogin.Clear();
                txtClaveAcceso.Focus();

                // LOS DATOS FUERON INGRESADO, VALIDAMOS EL USUARIO


                dtRpta = usuario.iniciarSesion(txtEmail.Text.ToLower());
                // COMPROBAR SI EL USUAURIO EXISTE
                if (dtRpta.Rows.Count > 0)
                {
                    string claveEncriptada = dtRpta.Rows[0][4].ToString();
                    // MessageBox.Show(claveEncriptada);
                    string apellidos = dtRpta.Rows[0][1].ToString();
                    string nombres = dtRpta.Rows[0][2].ToString();




                    if (Crypter.CheckPassword(txtClaveAcceso.Text, claveEncriptada))
                    {
                        //MessageBox.Show("Bienvenido","TiendaNET", MessageBoxButtons.OK,   MessageBoxIcon.Information);

                        // TOOLS DE DESIGNER / USAMOS NUESTRAS HERRAMIENTAS
                        Aviso.Informar($"Bienvenido {apellidos} {nombres}");

                        frmMain formMain = new frmMain();
                        // abre el formulario principal
                        formMain.Show();

                        // login se oculta
                        this.Hide();
                        
                    }
                    else
                    {
                        // MessageBox.Show("Error en la contraseña");
                        Aviso.Advertir("Error en la contraseña");
                    }

                }
                else
                {
                    //MessageBox.Show("El usuario no existe");
                    Aviso.Advertir("El usuario no existe");
                }
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //txtClaveAcceso.Text = Crypter.Blowfish.Crypt("SENATI123");
            //return;
            Login();
        }



        private void txtClaveAcceso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Login();
            }
        }
    }
}
