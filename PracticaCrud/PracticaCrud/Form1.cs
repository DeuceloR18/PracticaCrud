using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaCrud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Clases.CAlumnos objetAlumnos = new Clases.CAlumnos();
            objetAlumnos.mostrarAlumnos(dgvAlumnos);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Clases.CAlumnos objetAlumnos = new Clases.CAlumnos();
            objetAlumnos.GuardarAlumnos(txtDNI, txtNombres, txtApellidos, txtEdad);
            objetAlumnos.mostrarAlumnos(dgvAlumnos);

        }

        private void dgvAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Clases.CAlumnos objetAlumnos = new Clases.CAlumnos();
            objetAlumnos.SeleccionarAlumnos(dgvAlumnos, txtID, txtDNI, txtNombres, txtApellidos, txtEdad);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Clases.CAlumnos objetAlumnos = new Clases.CAlumnos();
            objetAlumnos.ModificarAlumnos(txtID, txtDNI, txtNombres, txtApellidos, txtEdad);
            objetAlumnos.mostrarAlumnos(dgvAlumnos);

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Clases.CAlumnos objetAlumnos = new Clases.CAlumnos();
            objetAlumnos.EliminarAlumnos(txtID);
            objetAlumnos.mostrarAlumnos(dgvAlumnos);


        }
    }
}


