using Agenda.be;
using BLL;
//using comun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dalEstudiantes
    {
        public bool insertarEstudiante(BEEstudiantes pEstudiante)
        {
            using (var bd = new BD_MATRICULAEntities())
            {
                var per = new ESTUDIANTE();
                {
                    per.id_estudiante = pEstudiante.id;
                    per.dni = pEstudiante.dni;
                    per.nombres = pEstudiante.nombres;
                    per.apellidos = pEstudiante.apellidos;
                    per.telefono = pEstudiante.telefono;
                }
                bd.ESTUDIANTE.Add(per);
                bd.SaveChanges();
                var estudianteInsertado = seleccionarEstudiante(per.id_estudiante);
                return true;
            }
        }

        public bool actualizarEstudiante(BEEstudiantes pEstudiantes)
        {
            using (var bd = new BD_MATRICULAEntities())
            {
                try
                {
                    var estudiante = bd.ESTUDIANTE.First(s => s.id_estudiante == pEstudiantes.id);
                    estudiante.dni = pEstudiantes.dni;
                    estudiante.nombres = pEstudiantes.nombres;
                    estudiante.apellidos = pEstudiantes.apellidos;
                    estudiante.telefono = pEstudiantes.telefono;

                    if (estudiante.MATRICULA != null)
                    {
                        estudiante.MATRICULA.Clear();
                    }
                    bd.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public bool eliminarEstudiante(int ID_ESTUDIANTE)
        {
            using (var bd = new BD_MATRICULAEntities())
            {
                var per = bd.ESTUDIANTE.First(s => s.id_estudiante == ID_ESTUDIANTE);
                bd.ESTUDIANTE.Remove(per);
                bd.SaveChanges();
                return true;
            }
        }

        public BEEstudiantes seleccionarEstudiante(int ID)
        {
            using (var bd = new BD_MATRICULAEntities())
            {
                var pEstudiante = bd.ESTUDIANTE.FirstOrDefault(s => s.id_estudiante == ID);

                if (pEstudiante == null)
                {
                    return null;
                }

                var per = new BEEstudiantes();
                per.id = pEstudiante.id_estudiante;
                per.dni = pEstudiante.dni;
                per.nombres = pEstudiante.nombres;
                per.apellidos = pEstudiante.apellidos;
                per.telefono = pEstudiante.telefono;
                per.matriculas = new List<BEMatricula>();
                per.pensiones = new List<BEPencion>();

                if (pEstudiante.MATRICULA != null)
                {

                    foreach (var tel in pEstudiante.MATRICULA)
                    {
                        var mat = new BEMatricula() { idMatricula = tel.id_matricula, idEstudiante = tel.id_estudiante, nivel = tel.nivel, monto_m = tel.monto_matricula, fecha_m = tel.fecha_m };
                        per.matriculas.Add(mat);
                    }
                    foreach (var tel in pEstudiante.PENSION)
                    {
                        var pens = new BEPencion() { id_pensiones = tel.id_pensiones, id_estudiante = tel.id_estudiante, n_pension = tel.n_pension, monto = tel.monto, fecha_p = tel.fecha_p };
                        per.pensiones.Add(pens);
                    }
                }
                return per;
            }
        }

        public List<BEEstudiantes> seleccionarEstudiantes()
        {
            var bd = new BD_MATRICULAEntities();
            var resultado = new List<BEEstudiantes>();
            foreach (var item in bd.ESTUDIANTE)
            {
                var estudiante = seleccionarEstudiante(item.id_estudiante);
                if (estudiante != null)
                {
                    resultado.Add(estudiante);
                }
            }
            return resultado;
        }
    }
}
