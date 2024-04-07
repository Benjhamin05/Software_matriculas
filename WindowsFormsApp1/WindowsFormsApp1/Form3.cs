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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dalPensi = new dalPension();
            var perComun = dalPensi.seleccionarPension((int)txtidp.Value);
            txtide.Value = perComun.id_estudiante;
            txtNpension.Value = perComun.n_pension;
            txtMonto.Value = perComun.monto;
            txtFecha.Text = perComun.fecha_p.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var perComun = new CPension();
            var dalPensi = new dalPension();
            perComun.id_pensiones = (int)txtidp.Value;
            perComun.id_estudiante = (int)txtide.Value;
            perComun.n_pension= (int)txtNpension.Value;
            perComun.monto = txtMonto.Value;
            perComun.fecha_p = DateTime.Parse(txtFecha.Text);

            MessageBox.Show(perComun.ToString());
            dalPensi.insertarPension(perComun);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var perComun = new CPension();
            var dalPensi = new dalPension();
            perComun.id_pensiones = (int)txtidp.Value;
            perComun.id_estudiante = (int)txtide.Value;
            perComun.n_pension = (int)txtNpension.Value;
            perComun.monto = (decimal)txtMonto.Value;
            perComun.fecha_p= DateTime.Parse(txtFecha.Text);

            MessageBox.Show(perComun.ToString());
            dalPensi.actualizarPension(perComun);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var dalPensi = new dalPension();
            dalPensi.eliminarPension((int)txtidp.Value);
        }
    }
}
