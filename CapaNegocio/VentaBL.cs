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
    public class VentaBL
    {
        public List<VentaCLS> ListarVentas()
        {
            VentaDAL obj = new VentaDAL();
            return obj.ListarVentas();
        }
    }
}
