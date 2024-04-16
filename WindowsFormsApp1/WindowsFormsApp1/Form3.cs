//using comun;
using Agenda.be;
using Agenda.bll;
using BLL;
//using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        private blAgenda agenda;
        public Form3()
        {
            InitializeComponent();
            agenda = new blAgenda();
        }

        private void Limpiar()
        {
            txtidp.Text = "";
            txtide.Text = "";
            txtNpension.Text = "";
            txtMonto.Text = "";
            txtFecha.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var perComun = agenda.seleccionarPension((int)txtidp.Value);
            if (perComun != null)
            {
                txtide.Value = perComun.id_estudiante;
                txtNpension.Value = perComun.n_pension;
                txtMonto.Value = perComun.monto;
                txtFecha.Text = perComun.fecha_p.ToString();
            }
            else
            {
                MessageBox.Show("No hay registro de pensión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtide.Text == string.Empty)
                MessageBox.Show("No puedes registrar sin el id del estudiante", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                var perComun = new BEPencion();
                perComun.id_pensiones = (int)txtidp.Value;
                perComun.id_estudiante = (int)txtide.Value;
                perComun.n_pension = (int)txtNpension.Value;
                perComun.monto = txtMonto.Value;
                perComun.fecha_p = DateTime.Parse(txtFecha.Text);

                if (!agenda.insertarPension(perComun))
                    MessageBox.Show("No se pudo registrar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Registrado Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // logica de negocio
            if ((int)txtidp.Value == 3)
                MessageBox.Show("No se puede modificar a este estudiante", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                var perComun = new BEPencion();
                perComun.id_pensiones = (int)txtidp.Value;
                perComun.id_estudiante = (int)txtide.Value;
                perComun.n_pension = (int)txtNpension.Value;
                perComun.monto = (decimal)txtMonto.Value;
                perComun.fecha_p = DateTime.Parse(txtFecha.Text);

                if (!agenda.actualizarPension(perComun))
                    MessageBox.Show("No se pudo actualizar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Actualizado Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //logica de negocio
            var resultado = agenda.eliminarPension((int)txtidp.Value);
            if (!resultado)
                MessageBox.Show("No se puede eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                MessageBox.Show("Estudiante eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtMonto_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtNpension_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtide_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtidp_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
