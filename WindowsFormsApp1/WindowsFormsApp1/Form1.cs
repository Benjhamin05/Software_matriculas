using Agenda.be;
using Agenda.bll;
using BLL;
//using comun;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private blAgenda agenda;
        public Form1()
        {
            InitializeComponent();
            agenda = new blAgenda();
        }

        private void Limpiar()
        {
            txtDNI.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtTelefono.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var per = agenda.seleccionarEstudiante((int)txtID.Value);
            if (per != null)
            {
                txtDNI.Text = per.dni;
                txtNombres.Text = per.nombres;
                txtApellidos.Text = per.apellidos;
                txtTelefono.Text = per.telefono;
                ListMatricula.DataSource = per.matriculas;
                ListPension.DataSource = per.pensiones;
            }
            else
            {
                MessageBox.Show("No se encontró ningún estudiante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // logica de negocio
            if (txtTelefono.Text == string.Empty)
                MessageBox.Show("No puedes registrar sin número telefónico", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else {
                var per = new BEEstudiantes();
                per.id = (int)txtID.Value;
                per.dni = txtDNI.Text;
                per.nombres = txtNombres.Text;
                per.apellidos = txtApellidos.Text;
                per.telefono = txtTelefono.Text;
                per.matriculas = new List<BEMatricula>();

                if (!agenda.insertarEstudiante(per))
                    MessageBox.Show("No se pudo registrar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Registrado Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    ListMatricula.DataSource = agenda.seleccionarEstudiantes();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // logica de negocio
            if ((int)txtID.Value == 3)
                MessageBox.Show("No se puede modificar a este estudiante", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else {
                var per = new BEEstudiantes();
                per.id = (int)txtID.Value;
                per.dni = txtDNI.Text;
                per.nombres = txtNombres.Text;
                per.apellidos = txtApellidos.Text;
                per.telefono = txtTelefono.Text;

                if (!agenda.actualizarEstudiante(per))
                    MessageBox.Show("No se pudo actualizar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Actualizado Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    ListMatricula.DataSource = agenda.seleccionarEstudiantes();
                }
            }
        }


















        private void button4_Click(object sender, EventArgs e)
        {
            //logica de negocio
            var resultado = agenda.eliminarEstudiante((int)txtID.Value);
            if (!resultado)
                MessageBox.Show("No se puede eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else { 
                //var dalEstu = new dalEstudiantes();
                //agenda.eliminarEstudiante((int)txtID.Value);
                MessageBox.Show("Estudiante eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Limpiar();

                ListMatricula.DataSource = agenda.seleccionarEstudiantes();
                //Poner para que se limpie los campos
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 formulario = new Form2();
            formulario.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 formulario = new Form3();
            formulario.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }
    }
}
