using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaCrud.Clases
{
    internal class CConexion
    {
        SqlConnection Conex = new SqlConnection();
        static string servidor = "localhost";
        static string bd = "colegioDB";
        static string usuario = "Registro";
        static string contrasenia = "Pacientes";
        static string puerto = "1433";

        string Cadenaconexion = "Data Source="+ servidor + ","+ puerto+";"+"user id="+usuario+";"+"password="+contrasenia+";"+"Initial Catalog="+bd+";"+"Persist Security info=true";
        public SqlConnection establecerconexion()
        {
            try
            {
                Conex.ConnectionString = Cadenaconexion;
                Conex.Open();
               // MessageBox.Show("Se conecto correctamente");

            }
            catch (SqlException x)
            {

                MessageBox.Show("No se pudo conectar a la base de datos, error: "+ x.ToString());
            }

            return Conex;

        }
        public void cerrarConexion()
        {
         Conex.Close();
        }
    }

}
