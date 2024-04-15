using System;
using WCF = global::System.ServiceModel;

namespace Agenda.MessageContracts
{
    [WCF::MessageContract(IsWrapped = false)]

    public partial class MCEstudiante
    {
        // atributos
        private DataContracts.DCEstudiante datosEstudiante;
        // propiedad
        [WCF::MessageBodyMember(Namespace = "http://agenda.modelo.ServiceContracts", Name = "DatosEstudiante")]
        public DataContracts.DCEstudiante DatosEstudiante
        {
            get { return datosEstudiante; }
            set { datosEstudiante = value; }
        }
    }
}
