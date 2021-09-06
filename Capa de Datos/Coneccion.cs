using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Capa_Entidad;
//prueba 2
//using System.Windows.Forms;

namespace Capa_de_Datos
{
    public  class Coneccion
    {
        private SqlConnection sCon = new SqlConnection();

        // private string con = "Data Source=ERIKA\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=DB_Fabrizzi";
        private string con = "Data Source=DESKTOP-ITATI\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=DB_Fabrizzi";

        /*  SSPI son las siglas de Security Support Provider Interface. ... 
         * Aparte de SSPI, también puede utilizar "true". La seguridad integrada realmente garantiza 
         * que se esté conectando con SQL Server mediante la autenticación de Windows, 
         * no la autenticación de SQL; que requiere que se proporcione nombre de usuario y contraseña con la cadena de conexión
          */


        public SqlConnection conectar()
        {
            try
            {
                sCon = new SqlConnection(con);
                if (sCon.State.Equals(ConnectionState.Open))
                {
                    sCon.Close();
                }
                else
                {
                    sCon.Open();
                }
            }
            catch (Exception ex)
            {
              //  MessageBox.Show(ex.Message);

            }

            return sCon;

        }

        //public Boolean cerrar()
        //{
        //    sCon = new SqlConnection(con);

        //    try
        //    {
        //        if (sCon.State.Equals(ConnectionState.Open))
        //        {
        //            sCon.Close();
        //        }
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        return false;
        //    }
        //}

    //hoyjuegaargentina
    }
}
