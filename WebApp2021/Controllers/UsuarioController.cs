using CapaEntidad;
using CapaNegocio;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebApp2021.Controllers
{
    public class UsuarioController : Controller
    {
        public List<UsuarioCLS> ListarUsuarios()
        {
            UsuarioBL obj = new UsuarioBL();
            return obj.ListarUsuarios();
        }

        public ActionResult Usuario()
        {
            return View();
        }
    }
}

