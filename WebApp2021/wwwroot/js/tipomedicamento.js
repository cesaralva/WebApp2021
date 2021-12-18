window.onload = function () {
    listartipomedicamento();
}

function listartipomedicamento() {
    mostrar({
        url: "TipoMedicamento/ListarTipoMedicamento",
        cabeceras: ["Id", "Nombre", "Descripción"],
        propiedades: ["iidtipomedicamento", "nombre", "descripcion"]
    }
    )
}