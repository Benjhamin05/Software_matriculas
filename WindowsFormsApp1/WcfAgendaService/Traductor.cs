using Agenda.be;
using Agenda.DataContracts;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfAgendaService
{
    public class Traductor
    {
        private static DCEstudiante TraduceEstudiante(BEEstudiantes origen)
        {
            DCEstudiante destino = new DCEstudiante();
            destino.Id = origen.id;
            destino.Dni = origen.dni;
            destino.Nombres = origen.nombres;
            destino.Apellidos = origen.apellidos;
            destino.Telefono = origen.telefono;
            return destino;
        }

        private static BEEstudiantes TraduceEstudiante(DCEstudiante origen)
        {
            BEEstudiantes destino = new BEEstudiantes();
            destino.id = origen.Id;
            destino.dni = origen.Dni;
            destino.nombres = origen.Nombres;
            destino.apellidos = origen.Apellidos;
            destino.telefono = origen.Telefono;
            return destino;
        }

        public static DCMatricula TraduceMatricula(BEMatricula origen)
        {
            DCMatricula destino = new DCMatricula();
            destino.IdMatricula = origen.idMatricula;
            destino.IdEstudiante = origen.idEstudiante;
            destino.Nivel = origen.nivel;
            destino.Monto_matricula = origen.monto_m;
            destino.Fecha = origen.fecha_m;
            return destino;
        }

        public static BEMatricula TraduceMatricula(DCMatricula origen)
        {
            BEMatricula destino = new BEMatricula();
            destino.idMatricula = origen.IdMatricula;
            destino.idEstudiante = origen.IdEstudiante;
            destino.nivel = origen.Nivel;
            destino.monto_m = origen.Monto_matricula;
            destino.fecha_m = origen.Fecha;
            return destino;
        }

        public static DCPension TraducePension(BEPencion origen)
        {
            DCPension destino = new DCPension();
            destino.IdPension = origen.id_pensiones;
            destino.IdEstudiante = origen.id_estudiante;
            destino.NPension = origen.n_pension;
            destino.Monto = origen.monto;
            destino.FechaP = origen.fecha_p;
            return destino;
        }

        public static BEPencion TraducePension(DCPension origen)
        {
            BEPencion destino = new BEPencion();
            destino.id_pensiones = origen.IdPension;
            destino.id_estudiante = origen.IdEstudiante;
            destino.n_pension = origen.NPension;
            destino.monto = origen.Monto;
            destino.fecha_p = origen.FechaP;
            return destino;
        }

        public static DCListaEsctudiantes TraduceListaEstudiantes(List<BEEstudiantes> origen)
        {
            var destino = new DCListaEsctudiantes();
            destino.AddRange(origen.Select(TraduceEstudiante));
            return destino;
        }

        public static List<BEEstudiantes> TraduceListaEstudiantes(DCListaEsctudiantes origen)
        {
            var destino = new List<BEEstudiantes>();
            destino.AddRange(origen.Select(TraduceEstudiante));
            return destino;
        }
        /*
        public static DCListaMatriculas TraduceListaMatricula(List<BEMatricula> origen)
        {
            var destino = new DCListaMatriculas();
            destino.AddRange(origen.Select(TraduceMatricula));
            return destino;
        }

        public static List<BEMatricula> TraduceListaMatricula(DCListaMatriculas origen)
        {
            var destino = new List<BEMatricula>();
            destino.AddRange(origen.Select(TraduceMatricula));
            return destino;
        }

        public static DCListaPensiones TraduceListaPension(List<BEPencion> origen)
        {
            var destino = new DCListaPensiones();
            destino.AddRange(origen.Select(TraducePension));
            return destino;
        }

        public static List<BEPencion> TraduceListaPension(DCListaPensiones origen)
        {
            var destino = new List<BEPencion>();
            destino.AddRange(origen.Select(TraduceListaPension));
            return destino;
        }*/
    }
}