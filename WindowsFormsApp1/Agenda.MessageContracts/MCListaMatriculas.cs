using System;
using WCF = global::System.ServiceModel;

namespace Agenda.MessageContracts
{
    [WCF::MessageContract(IsWrapped = false)]

    public partial class MCListaMatriculas
    {
        private DataContracts.DCListaMatriculas matriculas;

        [WCF::MessageBodyMember(Namespace = "http://agenda.modelo.ServiceContracts", Name = "Matriculas")]
        public DataContracts.DCListaMatriculas Matriculas
        {
            get { return matriculas; }
            set { matriculas = value; }
        }
    }
}
