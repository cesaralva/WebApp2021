using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CapaNegocio;
using CapaEntidad;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace WebApp2021.Controllers
{
    public class MedicamentoController : Controller
    {

        public List<MedicamentoCLS> ListarMedicamentos()
        {
            MedicamentoBL obj = new MedicamentoBL();
            return obj.ListarMedicamentos();
        }

        public ActionResult Medicamento()
        {
            return View();
        }
    }
}

