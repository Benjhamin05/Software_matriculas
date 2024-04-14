using Agenda.be;
using BLL;
//using comun;
using DAL;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dalEstu = new dalEstudiantes();
            var per = dalEstu.seleccionarEstudiante((int)txtID.Value);
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
                var dalEstu = new dalEstudiantes();
                per.id = (int)txtID.Value;
                per.dni = txtDNI.Text;
                per.nombres = txtNombres.Text;
                per.apellidos = txtApellidos.Text;
                per.telefono = txtTelefono.Text;
                per.matriculas = new List<BEMatricula>();

                //MessageBox.Show(per.ToString());
                //dalEstu.insertarEstudiante(per);
                if (!dalEstu.insertarEstudiante(per))
                    MessageBox.Show("No se pudo registrar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Registrado Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Poner para que se limpie los campos
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
                var dalEstu = new dalEstudiantes();
                per.id = (int)txtID.Value;
                per.dni = txtDNI.Text;
                per.nombres = txtNombres.Text;
                per.apellidos = txtApellidos.Text;
                per.telefono = txtTelefono.Text;

                /*per.matriculas = new List<BEMatricula>();
                foreach (var item in (List<BEMatricula>())listBox1.DataSource)
                {
                    per.matriculas.Add(item);
                }*/

                //MessageBox.Show(per.ToString());
                //dalEstu.actualizarEstudiante(per);

                if (!dalEstu.actualizarEstudiante(per))
                    MessageBox.Show("No se pudo actualizar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Actualizado Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //poner para que se limien los campos
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //logica de negocio
            if ((int)txtID.Value == 1)
                MessageBox.Show("No se puede eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else { 
                var dalEstu = new dalEstudiantes();
                dalEstu.eliminarEstudiante((int)txtID.Value);
                MessageBox.Show("Estudiante eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListMatricula.DataSource = dalEstu.seleccionarEstudiantes();
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
    }
}
