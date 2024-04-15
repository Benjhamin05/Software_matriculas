using System;
using WCF = global::System.ServiceModel;

namespace Agenda.MessageContracts
{
    [WCF::MessageContract(IsWrapped = false)]

    public partial class MCListaPensiones
    {
        private DataContracts.DCListaPensiones pensiones;

        [WCF::MessageBodyMember(Namespace = "http://agenda.modelo.ServiceContracts", Name = "Pensiones")]
        public DataContracts.DCListaPensiones Pensiones
        {
            get { return pensiones; }
            set { pensiones = value; }
        }
    }
}
