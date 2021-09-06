using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fabrizzi_TP_Integrador
{
    public partial class F_Principal : Form
    {
        public String nombre;

        public F_Principal()
        {
            InitializeComponent();

        }

        private void lbl_Roles_Click(object sender, EventArgs e)
        {
            RolesListado rolList = new RolesListado();
            rolList.Show();
            
           
        }

        private void lbl_usuarios_Click(object sender, EventArgs e)
        {
            UsuariosListado usuList = new UsuariosListado();
            usuList.Show();
        }

        private void btn_CerrarLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void F_Principal_Load(object sender, EventArgs e)
        {

        }

        private void lbl_Proveedores_Click(object sender, EventArgs e)
        {
            ProveedoresListado provList = new ProveedoresListado();
            provList.Show();
        }

        private void lbl_Locales_Click(object sender, EventArgs e)
        {
            LocalesListado Loc = new LocalesListado();
            Loc.Show();
        }

        private void lbl_MatPrimas_Click(object sender, EventArgs e)
        {
            MateriasPrimasListado MatPrim = new MateriasPrimasListado();
            MatPrim.Show();
        }
    }
} //prueba de carga en github

