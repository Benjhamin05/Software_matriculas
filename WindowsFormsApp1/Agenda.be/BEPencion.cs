using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.be
{
    public class BEPencion
    {
        public int id_pensiones { get; set; }
        public int id_estudiante { get; set; }
        public int n_pension { get; set; }
        public decimal monto { get; set; }
        public DateTime fecha_p { get; set; }
    }
}
