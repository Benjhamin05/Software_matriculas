using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfAgendaService
{
    [ServiceContract(Namespace = "http://agenda.modelo.ServiceContracts", Name = "SCAgenda", SessionMode = SessionMode.Allowed, ProtectionLevel = ProtectionLevel.None)]

    public interface IServAgenda
    {
        [OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false, Action = "ObtenerEstudiantes", ProtectionLevel = ProtectionLevel.None)]
        Agenda.MessageContracts.MCListaEstudiantes ObtenerEstudiantes();

        [OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false, Action = "SeleccionarEstudiante", ProtectionLevel = ProtectionLevel.None)]
        Agenda.MessageContracts.MCEstudiante SeleccionarEstudiante(Agenda.MessageContracts.MCCodigo request);

        [OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false, Action = "InsertarEstudiante", ProtectionLevel = ProtectionLevel.None)]
        Agenda.MessageContracts.MCRespuesta InsertarEstudiante(Agenda.MessageContracts.MCEstudiante request);

        [OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false, Action = "ActualizarEstudiante", ProtectionLevel = ProtectionLevel.None)]
        Agenda.MessageContracts.MCRespuesta ActualizarEstudiante(Agenda.MessageContracts.MCEstudiante request);

        [OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false, Action = "EliminarEstudiante", ProtectionLevel = ProtectionLevel.None)]
        Agenda.MessageContracts.MCRespuesta EliminarEstudiante(Agenda.MessageContracts.MCEstudiante request);
    }
}