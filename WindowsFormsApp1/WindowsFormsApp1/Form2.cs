﻿//using comun;
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
    public partial class Form2 : Form
    {
        private blAgenda agenda;
        public Form2()
        {
            InitializeComponent();
            agenda = new blAgenda();
        }

        private void Limpiar()
        {
            txtIdMatri.Text = "";
            txtIdAlumno.Text = "";
            txtNivel.Text = "";
            txtMonto.Text = "";
            txtFecha.Text = "";
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void Seleccionar_m_Click(object sender, EventArgs e)
        {
            var perComun = agenda.seleccionarMatricula((int)txtIdMatri.Value);
            if (perComun != null)
            {
                txtIdAlumno.Value = perComun.idEstudiante;
                txtNivel.Text = perComun.nivel;
                txtMonto.Value = perComun.monto_m;
                txtFecha.Text = perComun.fecha_m.ToString();
            }
            else
            {
                MessageBox.Show("No se encontró dicha matrícula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Registrar_m_Click(object sender, EventArgs e)
        {
            // logica de negocio
            if (txtIdAlumno.Text == string.Empty)
                MessageBox.Show("No puedes matricular sin registrar el id del alumno", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                var perComun = new BEMatricula();
                perComun.idMatricula = (int)txtIdMatri.Value;
                perComun.idEstudiante = (int)txtIdAlumno.Value;
                perComun.nivel = txtNivel.Text;
                perComun.monto_m = (decimal)txtMonto.Value;
                perComun.fecha_m = DateTime.Parse(txtFecha.Text);

                if (!agenda.insertarMatricula(perComun))
                    MessageBox.Show("No se pudo registrar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Registrado Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
            }
        }

        private void Eliminar_m_Click(object sender, EventArgs e)
        {
            //logica de negocio
            var resultado = agenda.eliminarMatricula((int)txtIdMatri.Value);
            if (!resultado)
                MessageBox.Show("No se puede eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                MessageBox.Show("Matrícula eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
        }

        private void Actualizar_m_Click(object sender, EventArgs e)
        {
            // logica de negocio
            if ((int)txtIdMatri.Value == 3)
                MessageBox.Show("No se puede modificar esta matrícula", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                var perComun = new BEMatricula();
                perComun.idMatricula = (int)txtIdMatri.Value;
                perComun.idEstudiante = (int)txtIdAlumno.Value;
                perComun.nivel = txtNivel.Text;
                perComun.monto_m = (decimal)txtMonto.Value;
                perComun.fecha_m = DateTime.Parse(txtFecha.Text);

                if (!agenda.actualizarMatricula(perComun))
                    MessageBox.Show("No se pudo actualizar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Actualizado Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
            }
        }

        private void txtFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 formulario = new Form3();
            formulario.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
