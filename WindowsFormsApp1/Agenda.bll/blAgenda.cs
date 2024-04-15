using Agenda.be;
using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.bll
{
    public class blAgenda
    {
        public bool insertarEstudiante(BEEstudiantes pEstudiante)
        {
            var dataAccess = new dalEstudiantes();

            // aqui la logica de negocio
            if (pEstudiante.telefono == string.Empty)
                return false;
            dataAccess.insertarEstudiante(pEstudiante);
            return true;
        }

        public bool actualizarEstudiante(BEEstudiantes pEstudiante)
        {
            var dataAccess = new dalEstudiantes();
            // aqui la logica de negocio
            if (pEstudiante.id == 3)
            {
                return false;
            }
            return dataAccess.actualizarEstudiante(pEstudiante);
        }

        public bool eliminarEstudiante(int pIdEstu)
        {
            var dataAccess = new dalEstudiantes();
            // aquí la lógica de negocio
            if (pIdEstu == 1)
                return false;
            dataAccess.eliminarEstudiante(pIdEstu);
            return true;
        }

        public BEEstudiantes seleccionarEstudiante(int pIdEstu)
        {
            var dataAccess = new dalEstudiantes();
            return dataAccess.seleccionarEstudiante(pIdEstu);
        }

        public List<BEEstudiantes> seleccionarEstudiantes()
        {
            var dataAccess = new dalEstudiantes();
            return dataAccess.seleccionarEstudiantes();
        }

        //----------------------------------------------------------------
        //---------------------------Matricula----------------------------
        //----------------------------------------------------------------
        public bool insertarMatricula(BEMatricula pMatricula)
        {
            var dataAccess = new dalMatricula();

            // aqui la logica de negocio
            if (pMatricula.nivel == string.Empty)
                return false;
            dataAccess.registrarMatricula(pMatricula);
            return true;
        }

        public bool actualizarMatricula(BEMatricula pMatricula)
        {
            var dataAccess = new dalMatricula();
            // aqui la logica de negocio
            if (pMatricula.idMatricula == 3)
            {
                return false;
            }
            return dataAccess.actualizarMatricula(pMatricula);
        }

        public bool eliminarMatricula(int pIdMatri)
        {
            var dataAccess = new dalEstudiantes();
            // aquí la lógica de negocio
            if (pIdMatri == 1)
                return false;
            dataAccess.eliminarEstudiante(pIdMatri);
            return true;
        }

        public BEMatricula seleccionarMatricula(int pIdMatri)
        {
            var dataAccess = new dalMatricula();
            return dataAccess.seleccionarMatricula(pIdMatri);
        }

        /*public List<BEMatricula> seleccionarMatriculas()
        {
            var dataAccess = new dalMatricula();
            return dataAccess.seleccionarMatriculas();
        }*/

        //----------------------------------------------------------------
        //---------------------------Pensiones----------------------------
        //----------------------------------------------------------------

        public bool insertarPension(BEPencion pPension)
        {
            var dataAccess = new dalPension();

            // aqui la logica de negocio
            if (pPension.id_pensiones == 0)
                return false;
            dataAccess.insertarPension(pPension);
            return true;
        }

        public bool actualizarPension(BEPencion pPension)
        {
            var dataAccess = new dalPension();
            // aqui la logica de negocio
            if (pPension.id_estudiante == 3)
            {
                return false;
            }
            return dataAccess.actualizarPension(pPension);
        }

        public bool eliminarPension(int pIdPen)
        {
            var dataAccess = new dalPension();
            // aquí la lógica de negocio
            if (pIdPen == 1)
                return false;
            dataAccess.eliminarPension(pIdPen);
            return true;
        }

        public BEPencion seleccionarPension(int pIdPen)
        {
            var dataAccess = new dalPension();
            return dataAccess.seleccionarPension(pIdPen);
        }

        /*public List<BEPencion> seleccionarPensiones()
        {
            var dataAccess = new dalPension();
            return dataAccess.seleccionarPensiones();
        }*/
    }
}
