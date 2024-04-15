using System;
using WcfSerialization = global::System.Runtime.Serialization;

namespace Agenda.DataContracts
{
    [WcfSerialization::DataContract(Namespace = "http://agenda.datacontracts", Name = "Estudiante")]
    public partial class DCEstudiante
    {
        //atributos
        private int id;
        private string dni;
        private string nombres;
        private string apellidos;
        private string telefono;
        //private DCListaMatriculas matriculas;
        //private DCListaPensiones pensiones;

        //propiedades
        [WcfSerialization::DataMember(Name = "Id", IsRequired = true, Order = 0)]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [WcfSerialization::DataMember(Name = "Dni", IsRequired = true, Order = 1)]
        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        [WcfSerialization::DataMember(Name = "Nombres", IsRequired = true, Order = 2)]
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

        [WcfSerialization::DataMember(Name = "Apellidos", IsRequired = true, Order = 3)]
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        [WcfSerialization::DataMember(Name = "Direccion", IsRequired = false, Order = 4)]
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        /*
        [WcfSerialization::DataMember(Name = "Matriculas", IsRequired = true, Order = 5)]
        public DCListaMatriculas Matriculas
        {
            get { return matriculas; }
            set { matriculas = value; }
        }

        [WcfSerialization::DataMember(Name = "Pensiones", IsRequired = true, Order = 6)]
        public DCListaMatriculas Pensiones
        {
            get { return pensiones; }
            set { pensiones = value; }
        }*/

        public override string ToString()
        {
            return apellidos + ", " + nombres;
        }
    }
}
