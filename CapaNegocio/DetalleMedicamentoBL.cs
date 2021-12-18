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
    public class DetalleMedicamentoBL
    {
        public List<DetalleMedicamentoCLS> ListarDetalleMedicamentos()
        {
            DetalleMedicamentoDAL obj = new DetalleMedicamentoDAL();
            return obj.ListarDetalleMedicamentos();
        }


    }
}