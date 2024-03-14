using comun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dalEstudiantes
    {
        public void insertarEstudiante(CEstudiantes pEstudiantes) {
            using (var bd = new BD_MATRICULAEntities()) {
                var est = new ESTUDIANTES();
                est.id_estudiante = pEstudiantes.idEstudiante;
                est.dni = pEstudiantes.DNI;
                est.nombres = pEstudiantes.nombre;
                est.apellidos = pEstudiantes.apellidos;
                est.codigo = pEstudiantes.codigo;
                est.correo = pEstudiantes.correo;

                bd.ESTUDIANTES.Add(est);
                bd.SaveChanges();

            }
        }

        public void actualizarEstudiante(CEstudiantes pEstudiantes){
            using (var bd = new BD_MATRICULAEntities())
            {
                var est = bd.ESTUDIANTES.First(s => s.id_estudiante == pEstudiantes.idEstudiante);
                est.dni = pEstudiantes.DNI;
                est.nombres = pEstudiantes.nombre;
                est.apellidos = pEstudiantes.apellidos;
                est.codigo = pEstudiantes.codigo;
                est.correo = pEstudiantes.correo;

                bd.SaveChanges();

            }
        }

        public void eliminarEstudiante(int id){
            using (var bd = new BD_MATRICULAEntities())
            {
                var est = bd.ESTUDIANTES.First(s => s.id_estudiante == id);

                bd.ESTUDIANTES.Remove(est);
                bd.SaveChanges();

            }
        }

        public CEstudiantes seleccionarEstudiante(int id){
            using (var bd = new BD_MATRICULAEntities())
            {
                var est = new CEstudiantes();
                var pEstudiantes = bd.ESTUDIANTES.First(s => s.id_estudiante == id);
                est.DNI = pEstudiantes.dni;
                est.nombre = pEstudiantes.nombres;
                est.apellidos = pEstudiantes.apellidos;
                est.codigo = pEstudiantes.codigo;
                est.correo = pEstudiantes.correo;

                return est;
            }
        }
    }
}
