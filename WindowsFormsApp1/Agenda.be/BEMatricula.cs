using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.be
{
    public class BEMatricula
    {
        public int idMatricula { get; set; }
        public int idEstudiante { get; set; }
        public string nivel { get; set; }
        public decimal monto_m { get; set; }
        public DateTime fecha_m { get; set; }
    }
}
