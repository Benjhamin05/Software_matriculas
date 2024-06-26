﻿//using comun;
using Agenda.be;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dalMatricula
    {
        public BEMatricula seleccionarMatricula(int ID_M)
        {
            using (var bd = new BD_MATRICULAEntities())
            {
                var per = new BEMatricula();
                try
                {
                    var pMatricula = bd.MATRICULA.First(s => s.id_matricula == ID_M);
                    per.idMatricula = pMatricula.id_matricula;
                    per.idEstudiante = pMatricula.id_estudiante;
                    per.nivel = pMatricula.nivel;
                    per.monto_m = pMatricula.monto_matricula;
                    per.fecha_m = pMatricula.fecha_m;
                    return per;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }

        public bool registrarMatricula(BEMatricula pMatricula)
        {
            using (var bd = new BD_MATRICULAEntities())
            {
                try
                {
                    var per = new MATRICULA();
                    per.id_matricula = pMatricula.idMatricula;
                    per.id_estudiante = pMatricula.idEstudiante;
                    per.nivel = pMatricula.nivel;
                    per.monto_matricula = pMatricula.monto_m;
                    per.fecha_m = pMatricula.fecha_m;
                    bd.MATRICULA.Add(per);
                    bd.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public bool actualizarMatricula(BEMatricula pMatricula)
        {
            using (var bd = new BD_MATRICULAEntities())
            {
                try
                {
                    var per = bd.MATRICULA.First(s => s.id_matricula == pMatricula.idMatricula);
                    per.id_estudiante = pMatricula.idEstudiante;
                    per.nivel = pMatricula.nivel;
                    per.monto_matricula = pMatricula.monto_m;
                    per.fecha_m = pMatricula.fecha_m;
                    bd.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public bool eliminarMatricula(int ID_MATRICULA)
        {
            using (var bd = new BD_MATRICULAEntities())
            {
                try
                {
                    var per = bd.MATRICULA.First(s => s.id_matricula == ID_MATRICULA);
                    bd.MATRICULA.Remove(per);
                    bd.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public List<BEMatricula> seleccionarMatriculas()
        {
            var bd = new BD_MATRICULAEntities();
            var resultado = new List<BEMatricula>();
            foreach (var item in bd.MATRICULA)
            {
                var matricula = seleccionarMatricula(item.id_matricula);
                if (matricula != null)
                {
                    resultado.Add(matricula);
                }
            }
            return resultado;
        }
    }
}
