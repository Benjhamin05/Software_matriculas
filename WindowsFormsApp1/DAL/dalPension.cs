﻿//using comun;
using Agenda.be;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dalPension
    {
        public BEPencion seleccionarPension(int ID)
        {
            using (var bd = new BD_MATRICULAEntities())
            {
                var per = new BEPencion();
                var pPension = bd.PENSION.First(s => s.id_pensiones == ID);
                per.id_pensiones = pPension.id_pensiones;
                per.id_estudiante = pPension.id_estudiante;
                per.n_pension = pPension.n_pension;
                per.monto = pPension.monto;
                per.fecha_p = pPension.fecha_p;
                return per;
            }
        }

        public bool insertarPension(BEPencion pPension)
        {
            using (var bd = new BD_MATRICULAEntities())
            {
                try
                {
                    var per = new PENSION();
                    per.id_pensiones = pPension.id_pensiones;
                    per.id_estudiante = pPension.id_estudiante;
                    per.n_pension = pPension.n_pension;
                    per.monto = pPension.monto;
                    per.fecha_p = pPension.fecha_p;
                    bd.PENSION.Add(per);
                    bd.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public bool actualizarPension(BEPencion pPension)
        {
            using (var bd = new BD_MATRICULAEntities())
            {
                try
                {
                    var per = bd.PENSION.First(s => s.id_pensiones == pPension.id_pensiones);
                    per.id_estudiante = pPension.id_estudiante;
                    per.n_pension = pPension.n_pension;
                    per.monto = pPension.monto;
                    per.fecha_p = pPension.fecha_p;
                    bd.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public bool eliminarPension(int ID_PENSIONES)
        {
            using (var bd = new BD_MATRICULAEntities())
            {
                try
                {
                    var per = bd.PENSION.First(s => s.id_pensiones == ID_PENSIONES);
                    bd.PENSION.Remove(per);
                    bd.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
    }
}
