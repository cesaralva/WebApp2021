
window.onload = function () {
    listarlaboratorio();
}

function listarlaboratorio() {
    mostrar({
        url: "Laboratorio/ListarLaboratorio",
        cabeceras: ["Id", "Nombre", "Direccion", "Contacto"],
        propiedades: ["iidlaboratorio", "nombre", "direccion", "personacontacto"]
    }
    )
}