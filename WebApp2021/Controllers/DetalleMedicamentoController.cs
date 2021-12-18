using CapaEntidad;
using CapaNegocio;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace WebApp2021.Controllers
{
    public class DetalleMedicamentoController : Controller
    {
        public List<DetalleMedicamentoCLS> ListarDetalleMedicamentos()
        {
            DetalleMedicamentoBL obj = new DetalleMedicamentoBL();
            return obj.ListarDetalleMedicamentos();

        }
        public ActionResult DetalleMedicamento()
        {
            return View();
        }
    }
}