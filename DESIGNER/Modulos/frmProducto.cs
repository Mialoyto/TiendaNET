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
namespace DESIGNER.Modulos
{
    public partial class frmProducto : Form
    {

        Producto producto = new Producto();
        Categoria categoria = new Categoria();
        Subcategoria subcategoria = new Subcategoria();
        Marca marca = new Marca();
        EProducto entProducto = new EProducto();

        DataView dv;

        // BANDERAS => VARIABLE LOGICA QUE CONTROLA ESTADOS
        bool categoriasListas = false;
        
        
        public frmProducto()
        {
            InitializeComponent();
        }

        private void actualizarMarcas()
        {
            cboMarcas.DataSource = marca.Listar();
            cboMarcas.DisplayMember = "marca";
            cboMarcas.ValueMember = "idmarca";
            cboMarcas.Refresh();
            cboMarcas.Text = String.Empty;
        }

        private void actualizarCategorias()
        {
            cboCategorias.DataSource = categoria.Listar();
            cboCategorias.DisplayMember = "categoria";
            cboCategorias.ValueMember = "idcategoria";
            cboCategorias.Refresh();
            cboCategorias.Text = String.Empty;
        }
        private void actualizarDatos()
        {
            gridProductos.DataSource = producto.Listar();
            gridProductos.Refresh();
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            actualizarMarcas();
            actualizarDatos();
            actualizarCategorias();

            categoriasListas = true;
        }

        private void cboCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (categoriasListas)
            {
                int idcategoria = Convert.ToInt32(cboCategorias.SelectedValue.ToString());
                //INVOCAR AL METODO QUE CARGA A LA SUBCATEGORIA
                cboSubcategoria.DataSource = subcategoria.listar(idcategoria);
                cboSubcategoria.DisplayMember = "subcategoria";
                cboSubcategoria.ValueMember = "idsubcategoria";
                cboSubcategoria.Refresh();
                cboSubcategoria.Text = "";
            }


        }

        private void reiniciarInterfaz()
        {
            cboMarcas.Text = "";
            cboCategorias.Text = "";
            cboSubcategoria.Text = "";
            txtGarantia.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
        }

        private void actualizarProducto()
        {
            gridProductos.DataSource = producto.Listar();
            gridProductos.Refresh();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(Aviso.Preguntar("¿Desea guardar este producto?") == DialogResult.Yes)
            {
                entProducto.descripcion = txtDescripcion.Text;
                entProducto.idmarca = Convert.ToInt32(cboMarcas.SelectedValue.ToString());
                entProducto.idsubcartegoria = Convert.ToInt32(cboSubcategoria.SelectedValue.ToString());
                entProducto.garantia = Convert.ToInt32(txtGarantia.Text);
                entProducto.precio = Convert.ToDouble(txtPrecio.Text);
                entProducto.stock = Convert.ToInt32(txtStock.Text);

                if(producto.Registrar(entProducto)>0)
                {
                    reiniciarInterfaz();
                    actualizarProducto();
                }
                else
                {
                    Aviso.Advertir("No hemos podido terminar el registro");
                }
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            // 1. crear una inatncia del reporte ( CrystalReport)
            Reportes.rptProductos reporte = new Reportes.rptProductos();

            // 2. asignar los datos al objeto reporte ( creado en el paso 1)
            reporte.SetDataSource(producto.Listar());
            reporte.Refresh();

            //3. instanciar el formulario donde s emostrara los reportes
            Reportes.frmVisorReportes formulario = new Reportes.frmVisorReportes();

            //4. pasamos el reporte al visor
            formulario.visor.ReportSource = reporte;
            formulario.visor.Refresh();
            
            // mostrar en el formulario contenido reporte
            formulario.ShowDialog();
        }

        private void cboSubcategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ExportarDatos(string extension)
        {
            SaveFileDialog sd = new SaveFileDialog();
            
            sd.Title = "Reportes de productos";
            sd.Filter = $"Archivos en formato {extension.ToUpper()}*.{extension.ToLower()}";

            if(sd.ShowDialog() == DialogResult)
            {
                // COMPLETAR EN CASAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
            }





        }

        private void btnExportarPDF_Click(object sender, EventArgs e)
        {

        }

        private void btnExportarXLS_Click(object sender, EventArgs e)
        {

        }
    }
}
