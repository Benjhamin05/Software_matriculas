using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comun
{
    public class CPension
    {

        public int id_pensiones { get; set; }
        public int id_estudiante { get; set; }
        public int n_pension { get; set; }
        public decimal monto { get; set; }
        public DateTime fecha_p { get; set; }
        public decimal mora { get; set; }

        public override string ToString()
        {
            return string.Format("Pension (id_p={0} id_estudiante={1}, n_pension={2}, monto={3}, fecha_p={4},mora={5})",
                                  id_pensiones, id_estudiante, n_pension, monto, fecha_p, mora);
        }
    }
}
