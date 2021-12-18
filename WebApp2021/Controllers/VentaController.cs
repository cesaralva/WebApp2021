using CapaEntidad;
using CapaNegocio;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace WebApp2021.Controllers
{
    public class VentaController : Controller
    {
        public List<VentaCLS> ListarVentas()
        {
            VentaBL obj = new VentaBL();
            return obj.ListarVentas();
            
        }
        public ActionResult venta()
        {
            return View();
        }
    }
}



