using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGIN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-R6FPDTP\\SQLEXPRESS; database=DBlogin; integrated security=true");
            conexion.Open();

            string cadena = "select name from table_usuarios where usuarios= " + "'" + textUsuario.Text + "'" + " and contraseña = " + "'" + textContraseña.Text + "'";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registros = comando.ExecuteReader();
            {
                if ( registros.Read() )
                {
                    MessageBox.Show("Login Exitoso");
                }
                else
                {
                    MessageBox.Show("Datos Incorrectos");
                }
            }
        }
    }
}
