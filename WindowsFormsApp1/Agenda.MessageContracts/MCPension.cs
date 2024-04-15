using System;
using WCF = global::System.ServiceModel;

namespace Agenda.MessageContracts
{
    [WCF::MessageContract(IsWrapped = false)]

    public partial class MCPension
    {
        // atributos
        private DataContracts.DCPension datosPension;
        // propiedad
        [WCF::MessageBodyMember(Namespace = "http://agenda.modelo.ServiceContracts", Name = "DatosPension")]
        public DataContracts.DCPension DatosPension
        {
            get { return datosPension; }
            set { datosPension = value; }
        }
    }
}