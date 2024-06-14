using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaCrud.Clases
{
    internal class CAlumnos
    {
        public void mostrarAlumnos(DataGridView tablaAlumnos)
        {
            CConexion objetConexion = new CConexion();
            try
            {
                tablaAlumnos.DataSource = null;
                SqlDataAdapter adapter = new SqlDataAdapter("select * from alumnos;", objetConexion.establecerconexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                tablaAlumnos.DataSource = dt;
                objetConexion.cerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se logro mostrar, error:" + e.ToString());
            }
        }
        //GUARDAR ALUMNOS 
        public void GuardarAlumnos(TextBox paranDNI, TextBox paranNombres, TextBox paranApellidos, TextBox paranEdad)
        {
            CConexion objetConexion = new CConexion();
            try
            {
                string Query = "insert into alumnos (dni,nombres,apellidos,edad)" +
                    "values( '" + paranDNI.Text + "','" + paranNombres.Text + "','" + paranApellidos.Text + "','" + paranEdad.Text + " ');";

                SqlCommand myComando = new SqlCommand(Query, objetConexion.establecerconexion());
                SqlDataReader myReader;
                myReader = myComando.ExecuteReader();
                while (myReader.Read())
                {
                }

                MessageBox.Show("Se guardo correctamente");

                objetConexion.cerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se logro guardar, error:" + e.ToString());
            }
        }
        public void SeleccionarAlumnos(DataGridView tablaAlumnos, TextBox paramCodigo, TextBox paranDNI, TextBox paranNombres, TextBox paranApellidos, TextBox paranEdad)
        {
            try
            {
                paramCodigo.Text = tablaAlumnos.CurrentRow.Cells[0].Value.ToString();
                paranDNI.Text = tablaAlumnos.CurrentRow.Cells[1].Value.ToString();
                paranNombres.Text = tablaAlumnos.CurrentRow.Cells[2].Value.ToString();
                paranApellidos.Text = tablaAlumnos.CurrentRow.Cells[3].Value.ToString();
                paranEdad.Text = tablaAlumnos.CurrentRow.Cells[4].Value.ToString();

            }

            catch (Exception e)
            {
                MessageBox.Show("No se logro selecciomnar los registros, error: " + e.ToString());
            }
        }

        //MODIFICAR ALUMNOS
        public void ModificarAlumnos(TextBox paranID, TextBox paranDNI, TextBox paranNombres, TextBox paranApellidos, TextBox paranEdad)
        {
            CConexion objetConexion = new CConexion();
            try
            {
                string Query = "UPDATE alumnos SET dni ='" +
                    paranDNI.Text + "', alumnos.nombres ='" + paranNombres.Text + "', alumnos.apellidos='" + paranApellidos.Text + "', alumnos.edad='" + paranEdad.Text + "'WHERE alumnos.Codigo='" + paranID.Text + "';";

                SqlCommand myComando = new SqlCommand(Query, objetConexion.establecerconexion());
                SqlDataReader myReader;
                myReader = myComando.ExecuteReader();
                while (myReader.Read())
                {
                }

                MessageBox.Show("Se modifico correctamente");

                objetConexion.cerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se logro modificar, error:" + e.ToString());
            }
        }
        public void EliminarAlumnos(TextBox paranID)
        {
            CConexion objetConexion = new CConexion();
            try
            {
                string Query = "DELETE FROM alumnos WHERE alumnos.codigo='"+paranID.Text+"';";

                SqlCommand myComando = new SqlCommand(Query, objetConexion.establecerconexion());
                SqlDataReader myReader;
                myReader = myComando.ExecuteReader();
                while (myReader.Read())
                {
                }

                MessageBox.Show("Se elimino correctamente");

                objetConexion.cerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se logro eliminar, error:" + e.ToString());
            }
        }


    }  
}