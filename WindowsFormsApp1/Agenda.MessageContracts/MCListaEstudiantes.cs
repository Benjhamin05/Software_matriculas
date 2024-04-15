using System;
using WCF = global::System.ServiceModel;

namespace Agenda.MessageContracts
{
    [WCF::MessageContract(IsWrapped = false)]

    public partial class MCListaEstudiantes
    {
        private DataContracts.DCListaEsctudiantes estudiantes;

        [WCF::MessageBodyMember(Namespace = "http://agenda.modelo.ServiceContracts", Name = "Estudiantes")]
        public DataContracts.DCListaEsctudiantes Estudiantes
        {
            get { return estudiantes; }
            set { estudiantes = value; }
        }
    }
}
