
namespace DESIGNER
{
    partial class frmEmpresa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.gridEmpresa = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtEmailEmpresa = new System.Windows.Forms.TextBox();
            this.txtWeb = new System.Windows.Forms.TextBox();
            this.txtRuc = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardarEmp = new System.Windows.Forms.Button();
            this.btnCancelarEmp = new System.Windows.Forms.Button();
            this.btnCerrarEmp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpresa)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.Location = new System.Drawing.Point(55, 47);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(154, 20);
            this.lblEmpresa.TabIndex = 0;
            this.lblEmpresa.Text = "Buscar empresa : ";
            // 
            // txtBuscador
            // 
            this.txtBuscador.Location = new System.Drawing.Point(204, 47);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(674, 20);
            this.txtBuscador.TabIndex = 1;
            // 
            // gridEmpresa
            // 
            this.gridEmpresa.AllowUserToAddRows = false;
            this.gridEmpresa.AllowUserToDeleteRows = false;
            this.gridEmpresa.AllowUserToResizeColumns = false;
            this.gridEmpresa.AllowUserToResizeRows = false;
            this.gridEmpresa.BackgroundColor = System.Drawing.Color.White;
            this.gridEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmpresa.Location = new System.Drawing.Point(51, 90);
            this.gridEmpresa.Name = "gridEmpresa";
            this.gridEmpresa.Size = new System.Drawing.Size(829, 341);
            this.gridEmpresa.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtEmailEmpresa);
            this.groupBox1.Controls.Add(this.txtWeb);
            this.groupBox1.Controls.Add(this.txtRuc);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.txtRazonSocial);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(53, 449);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 141);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(445, 25);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(249, 20);
            this.txtTelefono.TabIndex = 11;
            // 
            // txtEmailEmpresa
            // 
            this.txtEmailEmpresa.Location = new System.Drawing.Point(445, 61);
            this.txtEmailEmpresa.Name = "txtEmailEmpresa";
            this.txtEmailEmpresa.Size = new System.Drawing.Size(249, 20);
            this.txtEmailEmpresa.TabIndex = 10;
            // 
            // txtWeb
            // 
            this.txtWeb.Location = new System.Drawing.Point(445, 100);
            this.txtWeb.Name = "txtWeb";
            this.txtWeb.Size = new System.Drawing.Size(249, 20);
            this.txtWeb.TabIndex = 9;
            // 
            // txtRuc
            // 
            this.txtRuc.Location = new System.Drawing.Point(124, 61);
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.Size = new System.Drawing.Size(249, 20);
            this.txtRuc.TabIndex = 8;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(124, 100);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(249, 20);
            this.txtDireccion.TabIndex = 7;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(124, 25);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(249, 20);
            this.txtRazonSocial.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(383, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sitio web :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(383, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefono  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dirección  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ruc :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Razón social :";
            // 
            // btnGuardarEmp
            // 
            this.btnGuardarEmp.Location = new System.Drawing.Point(791, 464);
            this.btnGuardarEmp.Name = "btnGuardarEmp";
            this.btnGuardarEmp.Size = new System.Drawing.Size(89, 30);
            this.btnGuardarEmp.TabIndex = 4;
            this.btnGuardarEmp.Text = "Guardar";
            this.btnGuardarEmp.UseVisualStyleBackColor = true;
            this.btnGuardarEmp.Click += new System.EventHandler(this.btnGuardarEmp_Click);
            // 
            // btnCancelarEmp
            // 
            this.btnCancelarEmp.Location = new System.Drawing.Point(791, 504);
            this.btnCancelarEmp.Name = "btnCancelarEmp";
            this.btnCancelarEmp.Size = new System.Drawing.Size(89, 30);
            this.btnCancelarEmp.TabIndex = 5;
            this.btnCancelarEmp.Text = "Cancelar";
            this.btnCancelarEmp.UseVisualStyleBackColor = true;
            // 
            // btnCerrarEmp
            // 
            this.btnCerrarEmp.Location = new System.Drawing.Point(791, 549);
            this.btnCerrarEmp.Name = "btnCerrarEmp";
            this.btnCerrarEmp.Size = new System.Drawing.Size(89, 29);
            this.btnCerrarEmp.TabIndex = 6;
            this.btnCerrarEmp.Text = "Cerrar";
            this.btnCerrarEmp.UseVisualStyleBackColor = true;
            // 
            // frmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 632);
            this.Controls.Add(this.btnCerrarEmp);
            this.Controls.Add(this.btnCancelarEmp);
            this.Controls.Add(this.btnGuardarEmp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridEmpresa);
            this.Controls.Add(this.txtBuscador);
            this.Controls.Add(this.lblEmpresa);
            this.Name = "frmEmpresa";
            this.Text = "frmEmpresa";
            this.Load += new System.EventHandler(this.frmEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpresa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.DataGridView gridEmpresa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtEmailEmpresa;
        private System.Windows.Forms.TextBox txtWeb;
        private System.Windows.Forms.TextBox txtRuc;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGuardarEmp;
        private System.Windows.Forms.Button btnCancelarEmp;
        private System.Windows.Forms.Button btnCerrarEmp;
    }
}