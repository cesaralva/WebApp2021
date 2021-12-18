using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaNegocio;
using CapaDatos;

namespace CapaNegocio
{
    public class LaboratorioBL
    {
        public List<LaboratorioCLS> ListarLaboratorio()
        {
            LaboratorioDAL obj = new LaboratorioDAL();
            return obj.ListarLaboratorio();
        }
    }
}