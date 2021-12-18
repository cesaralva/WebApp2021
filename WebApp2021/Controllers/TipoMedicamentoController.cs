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
    public class TipoMedicamentoController : Controller
    {

        public List<TipoMedicamentoCLS> ListarTipoMedicamento()
        {
            TipoMedicamentoBL obj = new TipoMedicamentoBL();
            return obj.ListarMedicamentos();
        }

        public ActionResult TipoMedicamento()
        {
            return View();
        }

        /*
        public string cadena()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder();

            builder.AddJsonFile(Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json"));

            var root = builder.Build();
            var cadenaDato = root.GetConnectionString("db");
            return cadenaDato;
        }
        */

    }
}
