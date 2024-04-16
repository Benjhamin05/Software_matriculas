using Agenda.be;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BEEstudiantes
    {
        public int id { get; set; }
        public string dni { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string telefono { get; set; }

        public List<BEMatricula> matriculas { get; set; }
        public List<BEPencion> pensiones { get; set; }
    }
}
