using CapaDatos;
using CapaEntidad;

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebApp2021.Controllers
{
    public class LaboratorioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public List<LaboratorioCLS> ListarLaboratorio()
        {
            LaboratorioDAL obj = new LaboratorioDAL();
            return obj.ListarLaboratorio();
        }
    }
}
 