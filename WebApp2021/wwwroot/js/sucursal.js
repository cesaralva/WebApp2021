window.onload = function () {
    listarsucursal();
}



function listarsucursal() {
    mostrar({
        url: "Sucursal/ListarSucursal",
        cabeceras: ["Id Sucursal", "Nombre", "Dirección"],
        propiedades: ["iidsucursal", "nombre", "direccion"]
    }
    )
}

function Buscar() {
    //var nombre = document.getElementById("txtbuscarsucursal").value;
    var nombresucursal = get("txtbuscarsucursal");
    mostrar({
        url: "Sucursal/FiltrarSucursal/?nombresucursal=" + nombresucursal,
        cabeceras: ["Id Sucursal", "Nombre", "Dirección"],
        propiedades: ["iidsucursal", "nombre", "direccion"]
    })
}

function Limpiar() {
    listarsucursal();
    set("txtbuscarsucursal", "")
}