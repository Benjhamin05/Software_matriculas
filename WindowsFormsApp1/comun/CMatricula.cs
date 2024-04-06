using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comun
{
    public class CMatricula
    {
        public int idMatricula { get; set; }
        public int idEstudiante { get; set; }
        public string nivel { get; set; }
        public decimal monto_m { get; set; }
        public DateTime fecha_m { get; set; }

        public override string ToString()
        {
            return string.Format("Matricula (idMatricula={0} idEstudiante={1}, nivel={2}, monto_m={3}, fecha_m={4})",
                                  idMatricula, idEstudiante, nivel, monto_m, fecha_m);
        }
    }
}
