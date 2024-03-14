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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var estuComun = new CEstudiantes();
            var dalEstu = new dalEstudiantes();

            estuComun.idEstudiante = (int)txtID.Value;
            estuComun.DNI = txtDNI.Text;
            estuComun.nombre = txtNom.Text;
            estuComun.apellidos = txtApel.Text;
            estuComun.codigo = txtCod.Text;
            estuComun.correo = txtGmail.Text;

            MessageBox.Show(estuComun.ToString());
            dalEstu.insertarEstudiante(estuComun);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var estuComun = new CEstudiantes();
            var dalEstu = new dalEstudiantes();
            estuComun.idEstudiante = (int)txtID.Value;
            estuComun.DNI = txtDNI.Text;
            estuComun.nombre = txtNom.Text;
            estuComun.apellidos = txtApel.Text;
            estuComun.codigo = txtCod.Text;
            estuComun.correo = txtGmail.Text;

            MessageBox.Show(estuComun.ToString());
            dalEstu.actualizarEstudiante(estuComun);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var dalEstu = new dalEstudiantes();
            dalEstu.eliminarEstudiante((int)txtID.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var dalEstu = new dalEstudiantes();
            var estuComun = dalEstu.seleccionarEstudiante((int)txtID.Value);
            txtDNI.Text = estuComun.DNI;
            txtNom.Text = estuComun.nombre;
            txtApel.Text = estuComun.apellidos;
            txtCod.Text = estuComun.codigo;
            txtGmail.Text = estuComun.correo;                        
        }
    }
}
