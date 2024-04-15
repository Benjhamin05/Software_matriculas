using System;
using WCF = global::System.ServiceModel;

namespace Agenda.MessageContracts
{
    [WCF::MessageContract(IsWrapped = false)]

    public partial class MCCodigo
    {
        // atributos
        private int codigoEstudiante;
        // propiedad
        [WCF::MessageBodyMember(Namespace = "http://agenda.modelo.ServiceContracts", Name = "CodigoEstudiante")]
        public int CodigoEstudiante
        {
            get { return codigoEstudiante; }
            set { codigoEstudiante = value; }
        }

        // atributos
        private int codigoMatricula;
        // propiedad
        [WCF::MessageBodyMember(Namespace = "http://agenda.modelo.ServiceContracts", Name = "CodigoMatricula")]
        public int CodigoMatricula
        {
            get { return codigoMatricula; }
            set { codigoMatricula = value; }
        }

        private int codigoPension;
        // propiedad
        [WCF::MessageBodyMember(Namespace = "http://agenda.modelo.ServiceContracts", Name = "CodigoPension")]
        public int CodigoPension
        {
            get { return codigoPension; }
            set { codigoPension = value; }
        }
    }
}
