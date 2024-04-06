using comun;
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
            var perComun = dalEstu.seleccionarEstudiante((int)txtID.Value);
            txtDNI.Text = perComun.dni;
            txtNombres.Text = perComun.nombres;
            txtApellidos.Text = perComun.apellidos;
            txtTelefono.Text = perComun.telefono;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var perComun = new CEstudiantes();
            var dalCli = new dalEstudiantes();
            perComun.id = (int)txtID.Value;
            perComun.dni = txtDNI.Text;
            perComun.nombres = txtNombres.Text;
            perComun.apellidos = txtApellidos.Text;
            perComun.telefono = txtTelefono.Text;

            MessageBox.Show(perComun.ToString());
            dalCli.insertarEstudiante(perComun);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var perComun = new CEstudiantes();
            var dalEstu = new dalEstudiantes();
            perComun.id = (int)txtID.Value;
            perComun.dni = txtDNI.Text;
            perComun.nombres = txtNombres.Text;
            perComun.apellidos = txtApellidos.Text;
            perComun.telefono = txtTelefono.Text;

            MessageBox.Show(perComun.ToString());
            dalEstu.actualizarEstudiante(perComun);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var dalEstu = new dalEstudiantes();
            dalEstu.eliminarEstudiante((int)txtID.Value);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 formulario = new Form2();
            formulario.ShowDialog();
        }
    }
}
