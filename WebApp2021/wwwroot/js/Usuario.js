window.onload = function () {
    listarUsuarios();
}

function listarUsuarios() {
    mostrar({
        url: "Usuario/ListarUsuarios",
        cabeceras: ["Id", "Nombre De Usuarios", "TipoUsuario", "Contra"],
        propiedades: ["iidusuario", "nombreusuario", "iidtipousuario", "contra"]
    }
    )
}

//select "iidusuario", "nombreusuario","iidtipousuario", "contra"