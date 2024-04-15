using System;
using WcfSerialization = global::System.Runtime.Serialization;

namespace Agenda.DataContracts
{
    [WcfSerialization::DataContract(Namespace = "http://agenda.datacontracts", Name = "Pensiones")]
    public partial class DCPension
    {
        //atributos
        private int idPension;
        private int idEstudiante;
        private int nPension;
        private decimal monto;
        private DateTime fechaP;

        //propiedades
        [WcfSerialization::DataMember(Name = "IdPension", IsRequired = true, Order = 0)]
        public int IdPension
        {
            get { return idPension; }
            set { idPension = value; }
        }

        [WcfSerialization::DataMember(Name = "IdEstudiante", IsRequired = true, Order = 1)]
        public int IdEstudiante
        {
            get { return idEstudiante; }
            set { idEstudiante = value; }
        }

        [WcfSerialization::DataMember(Name = "NPension", IsRequired = true, Order = 2)]
        public int NPension
        {
            get { return nPension; }
            set { nPension = value; }
        }

        [WcfSerialization::DataMember(Name = "Monto", IsRequired = true, Order = 3)]
        public decimal Monto
        {
            get { return monto; }
            set { monto = value; }
        }

        [WcfSerialization::DataMember(Name = "FechaP", IsRequired = false, Order = 4)]
        public DateTime FechaP
        {
            get { return fechaP; }
            set { fechaP = value; }
        }

        public override string ToString()
        {
            return idPension + ", " + idEstudiante;
        }
    }
}
