//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class PENSION
    {
        public int id_pensiones { get; set; }
        public int id_estudiante { get; set; }
        public int n_pension { get; set; }
        public decimal monto { get; set; }
        public System.DateTime fecha_p { get; set; }
    
        public virtual ESTUDIANTE ESTUDIANTE { get; set; }
    }
}
