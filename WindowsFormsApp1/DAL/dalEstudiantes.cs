using Agenda.be;
using BLL;
//using comun;
using System;
using System.Collections.Generic;
using System.Linq;
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
                    //bd.ESTUDIANTE.Add(per);
                    //bd.SaveChanges();
                    //return true;
                }
                foreach (var item in pEstudiante.matriculas)
                {
                    var mat = new MATRICULA() { id_matricula = item.idMatricula, id_estudiante = item.idEstudiante, nivel = item.nivel, monto_matricula = item.monto_m, fecha_m = item.fecha_m };
                    per.MATRICULA.Add(mat);
                }
                foreach (var item in pEstudiante.pensiones)
                {
                    var pens = new PENSION() { id_pensiones = item.id_pensiones, id_estudiante = item.id_estudiante, n_pension = item.n_pension, monto = item.monto, fecha_p = item.fecha_p };
                    per.PENSION.Add(pens);
                }
                bd.ESTUDIANTE.Add(per);
                bd.SaveChanges();
                return true;
            }
        }

        public bool actualizarEstudiante(BEEstudiantes pEstudiantes)
        {
            using (var bd = new BD_MATRICULAEntities())
            {
                var estudiante = bd.ESTUDIANTE.First(s => s.id_estudiante == pEstudiantes.id);
                estudiante.dni = pEstudiantes.dni;
                estudiante.nombres = pEstudiantes.nombres;
                estudiante.apellidos = pEstudiantes.apellidos;
                estudiante.telefono = pEstudiantes.telefono;
                //bd.SaveChanges();
                if (estudiante.MATRICULA != null)
                {
                    estudiante.MATRICULA.Clear();
                    foreach (var mat in pEstudiantes.matriculas)
                    {
                        var matr = new MATRICULA() { id_matricula = mat.idMatricula, id_estudiante = mat.idEstudiante, nivel = mat.nivel, monto_matricula = mat.monto_m, fecha_m = mat.fecha_m };
                        estudiante.MATRICULA.Add(matr);
                    }
                    foreach (var mat in pEstudiantes.pensiones)
                    {
                        var pens = new PENSION() { id_pensiones = mat.id_pensiones, id_estudiante = mat.id_estudiante, n_pension = mat.n_pension, monto = mat.monto, fecha_p = mat.fecha_p };
                        estudiante.PENSION.Add(pens);
                    }
                }
                return true;               
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
                var pEstudiante = bd.ESTUDIANTE.First(s => s.id_estudiante == ID);
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
