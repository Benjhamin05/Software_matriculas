//using comun;
using Agenda.be;
using BLL;
using DAL;
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
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dalPensi = new dalPension();
            var perComun = dalPensi.seleccionarPension((int)txtidp.Value);
            if (perComun != null)
            {
                txtide.Value = perComun.id_estudiante;
                txtNpension.Value = perComun.n_pension;
                txtMonto.Value = perComun.monto;
                txtFecha.Text = perComun.fecha_p.ToString();
            }
            else
            {
                MessageBox.Show("NO hay registro de pensión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtide.Text == string.Empty)
                MessageBox.Show("No puedes registrar sin el id del estudiante", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                var perComun = new BEPencion();
                var dalPensi = new dalPension();
                perComun.id_pensiones = (int)txtidp.Value;
                perComun.id_estudiante = (int)txtide.Value;
                perComun.n_pension = (int)txtNpension.Value;
                perComun.monto = txtMonto.Value;
                perComun.fecha_p = DateTime.Parse(txtFecha.Text);

                //MessageBox.Show(perComun.ToString());
                //dalPensi.insertarPension(perComun);
                if (!dalPensi.insertarPension(perComun))
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
            if ((int)txtidp.Value == 3)
                MessageBox.Show("No se puede modificar a este estudiante", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                var perComun = new BEPencion();
                var dalPensi = new dalPension();
                perComun.id_pensiones = (int)txtidp.Value;
                perComun.id_estudiante = (int)txtide.Value;
                perComun.n_pension = (int)txtNpension.Value;
                perComun.monto = (decimal)txtMonto.Value;
                perComun.fecha_p = DateTime.Parse(txtFecha.Text);

                //MessageBox.Show(perComun.ToString());
                //dalPensi.actualizarPension(perComun);
                if (!dalPensi.actualizarPension(perComun))
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
            if ((int)txtidp.Value == 1)
                MessageBox.Show("No se puede eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                var dalPensi = new dalPension();
                dalPensi.eliminarPension((int)txtidp.Value);
                MessageBox.Show("Estudiante eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Poner para que se limpie los campos
            }
        }
    }
}
