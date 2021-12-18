window.onload = function () {
    listarVentas();
}

function listarVentas() {
    mostrar({
        url: "Venta/ListarVentas",
        cabeceras: ["Venta", "Usuario Cliente", "Usuario Venta", "Tipo de Documento", "Observacion", "Total al pagar", "Pagocon", "Fecha de venta"],
        propiedades: ["iidventa", "iidusuariocliente", "iidusuarioventa", "iidtipodocumento", "vobservacion", "totalpagar", "pagocon", "dfechaventa"]
    }
    )
}









//select "iidventa", "iidusuariocliente","iidusuarioventa", "iidtipodocumento", "vobservacion", "totalpagar", "pagocon", "dfechaventa"