using CapaEntidad;
using CapaNegocio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp2021.Controllers
{
    public class SucursalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public List<SucursalCLS> ListarSucursal()
        {
            SucursalBL obj = new SucursalBL();
            return obj.ListarSucursal();
        }

        public List<SucursalCLS> FiltrarSucursal(string nombresucursal)
        {
            SucursalBL obj = new SucursalBL();
            return obj.FiltrarSucursal(nombresucursal);
        }
    }
}
