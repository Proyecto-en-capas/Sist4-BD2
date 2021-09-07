using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Capa_de_Datos;
using Capa_de_Negocio;
using Capa_Entidad;

namespace Presentacion
{
    public static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
