using Capa_Entidad;
using Capa_de_Negocio;

namespace Presentacion

{
   public partial class F_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Principal));
            this.lbl_usuarios = new System.Windows.Forms.Label();
            this.lbl_Roles = new System.Windows.Forms.Label();
            this.lbl_Proveedores = new System.Windows.Forms.Label();
            this.lbl_MatPrimas = new System.Windows.Forms.Label();
            this.lbl_productos = new System.Windows.Forms.Label();
            this.lbl_Pedidos = new System.Windows.Forms.Label();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.lbl_Legajo = new System.Windows.Forms.Label();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.btn_CerrarLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Locales = new System.Windows.Forms.Label();
            this.linkLbl_ConoceApp = new System.Windows.Forms.LinkLabel();
            this.Fabrizzi_logoRoles = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Fabrizzi_logoRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_usuarios
            // 
            this.lbl_usuarios.AutoSize = true;
            this.lbl_usuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuarios.ForeColor = System.Drawing.Color.White;
            this.lbl_usuarios.Location = new System.Drawing.Point(16, 81);
            this.lbl_usuarios.Name = "lbl_usuarios";
            this.lbl_usuarios.Size = new System.Drawing.Size(116, 29);
            this.lbl_usuarios.TabIndex = 2;
            this.lbl_usuarios.Text = "Usuarios";
            this.lbl_usuarios.Click += new System.EventHandler(this.lbl_usuarios_Click);
            // 
            // lbl_Roles
            // 
            this.lbl_Roles.AutoSize = true;
            this.lbl_Roles.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Roles.ForeColor = System.Drawing.Color.White;
            this.lbl_Roles.Location = new System.Drawing.Point(16, 35);
            this.lbl_Roles.Name = "lbl_Roles";
            this.lbl_Roles.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Roles.Size = new System.Drawing.Size(81, 29);
            this.lbl_Roles.TabIndex = 3;
            this.lbl_Roles.Text = "Roles";
            this.lbl_Roles.Click += new System.EventHandler(this.lbl_Roles_Click);
            // 
            // lbl_Proveedores
            // 
            this.lbl_Proveedores.AutoSize = true;
            this.lbl_Proveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Proveedores.ForeColor = System.Drawing.Color.White;
            this.lbl_Proveedores.Location = new System.Drawing.Point(16, 337);
            this.lbl_Proveedores.Name = "lbl_Proveedores";
            this.lbl_Proveedores.Size = new System.Drawing.Size(163, 29);
            this.lbl_Proveedores.TabIndex = 4;
            this.lbl_Proveedores.Text = "Proveedores";
            this.lbl_Proveedores.Click += new System.EventHandler(this.lbl_Proveedores_Click);
            // 
            // lbl_MatPrimas
            // 
            this.lbl_MatPrimas.AutoSize = true;
            this.lbl_MatPrimas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MatPrimas.ForeColor = System.Drawing.Color.White;
            this.lbl_MatPrimas.Location = new System.Drawing.Point(16, 193);
            this.lbl_MatPrimas.Name = "lbl_MatPrimas";
            this.lbl_MatPrimas.Size = new System.Drawing.Size(201, 29);
            this.lbl_MatPrimas.TabIndex = 5;
            this.lbl_MatPrimas.Text = "Materias Primas";
            this.lbl_MatPrimas.Click += new System.EventHandler(this.lbl_MatPrimas_Click);
            // 
            // lbl_productos
            // 
            this.lbl_productos.AutoSize = true;
            this.lbl_productos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productos.ForeColor = System.Drawing.Color.White;
            this.lbl_productos.Location = new System.Drawing.Point(16, 291);
            this.lbl_productos.Name = "lbl_productos";
            this.lbl_productos.Size = new System.Drawing.Size(131, 29);
            this.lbl_productos.TabIndex = 6;
            this.lbl_productos.Text = "Productos";
            // 
            // lbl_Pedidos
            // 
            this.lbl_Pedidos.AutoSize = true;
            this.lbl_Pedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pedidos.ForeColor = System.Drawing.Color.White;
            this.lbl_Pedidos.Location = new System.Drawing.Point(16, 243);
            this.lbl_Pedidos.Name = "lbl_Pedidos";
            this.lbl_Pedidos.Size = new System.Drawing.Size(110, 29);
            this.lbl_Pedidos.TabIndex = 7;
            this.lbl_Pedidos.Text = "Pedidos";
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Usuario.ForeColor = System.Drawing.Color.White;
            this.lbl_Usuario.Location = new System.Drawing.Point(703, 26);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(51, 16);
            this.lbl_Usuario.TabIndex = 8;
            this.lbl_Usuario.Text = "label1";
            // 
            // lbl_Legajo
            // 
            this.lbl_Legajo.AutoSize = true;
            this.lbl_Legajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Legajo.ForeColor = System.Drawing.Color.White;
            this.lbl_Legajo.Location = new System.Drawing.Point(703, 47);
            this.lbl_Legajo.Name = "lbl_Legajo";
            this.lbl_Legajo.Size = new System.Drawing.Size(41, 15);
            this.lbl_Legajo.TabIndex = 9;
            this.lbl_Legajo.Text = "label1";
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fecha.ForeColor = System.Drawing.Color.White;
            this.lbl_Fecha.Location = new System.Drawing.Point(703, 71);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(41, 15);
            this.lbl_Fecha.TabIndex = 10;
            this.lbl_Fecha.Text = "label2";
            // 
            // btn_CerrarLogin
            // 
            this.btn_CerrarLogin.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_CerrarLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CerrarLogin.ForeColor = System.Drawing.Color.White;
            this.btn_CerrarLogin.Location = new System.Drawing.Point(21, 404);
            this.btn_CerrarLogin.Name = "btn_CerrarLogin";
            this.btn_CerrarLogin.Size = new System.Drawing.Size(140, 39);
            this.btn_CerrarLogin.TabIndex = 23;
            this.btn_CerrarLogin.Text = "Salir";
            this.btn_CerrarLogin.UseVisualStyleBackColor = false;
            this.btn_CerrarLogin.Click += new System.EventHandler(this.btn_CerrarLogin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.lbl_Locales);
            this.panel1.Controls.Add(this.lbl_usuarios);
            this.panel1.Controls.Add(this.btn_CerrarLogin);
            this.panel1.Controls.Add(this.lbl_Roles);
            this.panel1.Controls.Add(this.lbl_Proveedores);
            this.panel1.Controls.Add(this.lbl_MatPrimas);
            this.panel1.Controls.Add(this.lbl_productos);
            this.panel1.Controls.Add(this.lbl_Pedidos);
            this.panel1.Location = new System.Drawing.Point(12, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 467);
            this.panel1.TabIndex = 24;
            // 
            // lbl_Locales
            // 
            this.lbl_Locales.AutoSize = true;
            this.lbl_Locales.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Locales.ForeColor = System.Drawing.Color.White;
            this.lbl_Locales.Location = new System.Drawing.Point(16, 143);
            this.lbl_Locales.Name = "lbl_Locales";
            this.lbl_Locales.Size = new System.Drawing.Size(104, 29);
            this.lbl_Locales.TabIndex = 24;
            this.lbl_Locales.Text = "Locales";
            this.lbl_Locales.Click += new System.EventHandler(this.lbl_Locales_Click);
            // 
            // linkLbl_ConoceApp
            // 
            this.linkLbl_ConoceApp.AutoSize = true;
            this.linkLbl_ConoceApp.LinkColor = System.Drawing.Color.SeaGreen;
            this.linkLbl_ConoceApp.Location = new System.Drawing.Point(680, 471);
            this.linkLbl_ConoceApp.Name = "linkLbl_ConoceApp";
            this.linkLbl_ConoceApp.Size = new System.Drawing.Size(143, 13);
            this.linkLbl_ConoceApp.TabIndex = 25;
            this.linkLbl_ConoceApp.TabStop = true;
            this.linkLbl_ConoceApp.Text = "Conoce más de la aplicación";
            // 
            // Fabrizzi_logoRoles
            // 
            this.Fabrizzi_logoRoles.BackColor = System.Drawing.Color.Transparent;
            this.Fabrizzi_logoRoles.Image = ((System.Drawing.Image)(resources.GetObject("Fabrizzi_logoRoles.Image")));
            this.Fabrizzi_logoRoles.Location = new System.Drawing.Point(310, 169);
            this.Fabrizzi_logoRoles.Name = "Fabrizzi_logoRoles";
            this.Fabrizzi_logoRoles.Size = new System.Drawing.Size(360, 140);
            this.Fabrizzi_logoRoles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Fabrizzi_logoRoles.TabIndex = 65;
            this.Fabrizzi_logoRoles.TabStop = false;
            // 
            // F_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(860, 531);
            this.Controls.Add(this.Fabrizzi_logoRoles);
            this.Controls.Add(this.linkLbl_ConoceApp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_Fecha);
            this.Controls.Add(this.lbl_Legajo);
            this.Controls.Add(this.lbl_Usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.F_Principal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Fabrizzi_logoRoles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_usuarios;
        private System.Windows.Forms.Label lbl_Proveedores;
        private System.Windows.Forms.Label lbl_MatPrimas;
        private System.Windows.Forms.Label lbl_productos;
        private System.Windows.Forms.Label lbl_Pedidos;
        public System.Windows.Forms.Label lbl_Legajo;
        public System.Windows.Forms.Label lbl_Fecha;
        public System.Windows.Forms.Label lbl_Usuario;
        
        private System.Windows.Forms.Button btn_CerrarLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLbl_ConoceApp;
        public System.Windows.Forms.Label lbl_Roles;
        public System.Windows.Forms.PictureBox Fabrizzi_logoRoles;
        private System.Windows.Forms.Label lbl_Locales;
    }
}