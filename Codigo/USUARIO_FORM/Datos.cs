using System;
using System.Data;
using System.Data.SqlClient;

namespace USUARIO_FORM
{
    public class Datos
    {
        // La cadena de conexión debe declararse dentro de la clase Datos
        private static string cadenaConexion = "Data Source=DESKTOP-6MJR8T3\\SQLEXPRESS;Initial Catalog=BD_MATRICULA;User ID=ro;Password=12345;";

        public static DataTable ObtenerDatosPensiones()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();

                string consulta = "SELECT * FROM Pensiones";
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }
    }
}
