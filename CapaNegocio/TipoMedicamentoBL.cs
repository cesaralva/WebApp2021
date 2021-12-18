using System;
using System.Collections.Generic;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class TipoMedicamentoBL
    {
        public List<TipoMedicamentoCLS> ListarMedicamentos()
        {
            TipoMedicamentoDAL obj = new TipoMedicamentoDAL();
            return obj.ListarMedicamentos();
        }
    }
}
