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

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void Seleccionar_m_Click(object sender, EventArgs e)
        {
            var dalMatri = new dalMatricula();
            var perComun = dalMatri.seleccionarMatricula((int)txtIdMatri.Value);
            txtIdAlumno.Value = perComun.idEstudiante;
            txtNivel.Text = perComun.nivel;
            txtMonto.Value = perComun.monto_m;
            txtFecha.Text = perComun.fecha_m.ToString();
        }

        private void Registrar_m_Click(object sender, EventArgs e)
        {
            var perComun = new CMatricula();
            var dalMatri = new dalMatricula();
            perComun.idMatricula = (int)txtIdMatri.Value;
            perComun.idEstudiante = (int)txtIdMatri.Value;
            perComun.nivel = txtNivel.Text;
            perComun.monto_m = (decimal)txtMonto.Value;
            perComun.fecha_m = DateTime.Parse(txtFecha.Text);

            MessageBox.Show(perComun.ToString());
            dalMatri.registrarMatricula(perComun);
        }

        private void Eliminar_m_Click(object sender, EventArgs e)
        {
            var dalMatri = new dalMatricula();
            dalMatri.eliminarMatricula((int)txtIdMatri.Value);
        }

        private void Actualizar_m_Click(object sender, EventArgs e)
        {
            var perComun = new CMatricula();
            var dalEstu = new dalMatricula();
            perComun.idMatricula = (int)txtIdMatri.Value;
            perComun.idEstudiante = (int)txtIdMatri.Value;
            perComun.nivel = txtNivel.Text;
            perComun.monto_m = (decimal)txtMonto.Value;
            perComun.fecha_m = DateTime.Parse(txtFecha.Text);

            MessageBox.Show(perComun.ToString());
            dalEstu.actualizarMatricula(perComun);
        }

        private void txtFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 formulario = new Form3();
            formulario.ShowDialog();
        }
    }
}
