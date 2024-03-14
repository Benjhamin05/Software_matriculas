using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comun
{
    public class CEstudiantes
    {
        public int idEstudiante { get; set; }
        public string DNI { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string codigo { get; set; }
        public string correo { get; set; }

        public override string ToString()
        {
            return string.Format("¿Desea registrar al estudiante?", 
                                idEstudiante, DNI, nombre, apellidos, codigo, correo);
        }
    }
}
