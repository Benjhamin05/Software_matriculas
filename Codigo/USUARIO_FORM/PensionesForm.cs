using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace USUARIO_FORM
{
    public partial class PensionesForm : Form
    {
        // La cadena de conexión debe declararse dentro de la clase Datos
        private static string connectionString = "Data Source=DESKTOP-6MJR8T3\\SQLEXPRESS;Initial Catalog=BD_MATRICULA;User ID=ro;Password=12345;";

        public PensionesForm()
        {
            InitializeComponent();
            // Llama al método CargarDatos() en el constructor o en el evento Load del formulario
            CargarDatos();
        }

        private void Inicio_Click(object sender, EventArgs e)
        {
            // Cierra la ventana actual
            this.Close();
            INICIOFORM inicioForm = new INICIOFORM();
            inicioForm.Show();
        }

        private void CargarDatos()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Consulta SQL para seleccionar todos los datos de la tabla "Pensiones"
                string query = "SELECT * FROM Pensiones";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Vincular los datos al DataGridView
                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Puedes agregar lógica adicional aquí si es necesario
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Puedes agregar lógica adicional aquí si es necesario
        }

        private void PensionesForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bD_MATRICULADataSet.PENSIONES' Puede moverla o quitarla según sea necesario.
            this.pENSIONESTableAdapter.Fill(this.bD_MATRICULADataSet.PENSIONES);

        }
    }
}
