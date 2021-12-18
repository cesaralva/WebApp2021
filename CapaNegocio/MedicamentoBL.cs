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
    public class MedicamentoBL
    {
        public List<MedicamentoCLS> ListarMedicamentos()
        {
            MedicamentoDAL obj = new MedicamentoDAL();
            return obj.ListarMedicamentos();
        }
    }
}
