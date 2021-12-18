window.onload = function () {
    listarDetalleMedicamentos();
}

function listarDetalleMedicamentos() {
    mostrar({
             url: "DetalleMedicamento/ListarDetalleMedicamentos",
            cabeceras: ["Medicamento de Laboratorio", "IdMedicamento", "Id de Laboratorio", "precio de Compra", "Precio de venta", "Stock", "Id de marca", "Id de envoltura", "capacidad de contenido", "idtipoadministracion", "Id de sucursal", "Foto del medicamento", "Nombre de la foto del medicamento" ],
        propiedades: ["IIDMEDICAMENTOLABORATORIO", "IIDMEDICAMENTO", "IIDLABOTATORIO", "PRECIOCOMPRA", "PRECIOVENTA", "STOCK", "IIDMARCA", "IIDENVOLTURA", "CAPACIDADCONTENIDO", "IIDTIPOADMINISTRACION", "IIDSUCURSAL", "FOTOMEDICAMENTO", "NOMBREFOTOMEDICAMENTO"]
    
    }
    )
}