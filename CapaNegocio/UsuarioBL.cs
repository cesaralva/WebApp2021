<<<<<<< HEAD
﻿using System;
=======
using System;
>>>>>>> b0d435beb7a739e0965cb5cdc46a45aee272ac53
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaNegocio;
using CapaDatos;

namespace CapaNegocio
{
    public class UsuarioBL
    {
        public List<UsuarioCLS> ListarUsuarios()
        {
            UsuarioDAL obj = new UsuarioDAL();
            return obj.ListarUsuarios();
        }
    }
}
