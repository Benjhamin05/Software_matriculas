using System;
using WCF = global::System.ServiceModel;

namespace Agenda.MessageContracts
{
    [WCF::MessageContract(IsWrapped = false)]

    public partial class MCMatricula
    {
        // atributos
        private DataContracts.DCMatricula datosMatricula;
        // propiedad
        [WCF::MessageBodyMember(Namespace = "http://agenda.modelo.ServiceContracts", Name = "DatosMatricula")]
        public DataContracts.DCMatricula DatosMatricula
        {
            get { return datosMatricula; }
            set { datosMatricula = value; }
        }
    }
}
