using System;
using WcfSerialization = global::System.Runtime.Serialization;

namespace Agenda.DataContracts
{
    [WcfSerialization::DataContract(Namespace = "http://agenda.datacontracts", Name = "Estudiante")]
    public partial class DCMatricula
    {
        //atributos
        private int idMatricula;
        private int idEstudiante;
        private string nivel;
        private decimal nonto_matricula;
        private DateTime fecha;

        //propiedades
        [WcfSerialization::DataMember(Name = "IdMatricula", IsRequired = true, Order = 0)]
        public int IdMatricula
        {
            get { return idMatricula; }
            set { idMatricula = value; }
        }

        [WcfSerialization::DataMember(Name = "IdEstudiante", IsRequired = true, Order = 1)]
        public int IdEstudiante
        {
            get { return idEstudiante; }
            set { idEstudiante = value; }
        }

        [WcfSerialization::DataMember(Name = "Nivel", IsRequired = true, Order = 2)]
        public string Nivel
        {
            get { return nivel; }
            set { nivel = value; }
        }

        [WcfSerialization::DataMember(Name = "Monto_matricula", IsRequired = true, Order = 3)]
        public decimal Monto_matricula
        {
            get { return nonto_matricula; }
            set { nonto_matricula = value; }
        }

        [WcfSerialization::DataMember(Name = "Fecha", IsRequired = false, Order = 4)]
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public override string ToString()
        {
            return idMatricula + ", " + idEstudiante;
        }
    }
}
