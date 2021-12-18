window.onload = function () {
    listarMedicamentos();
}

function listarMedicamentos() {
    mostrar({
        url: "Medicamento/ListarMedicamentos",
        cabeceras: ["Id","Codigo", "Nombre Del medicamento", "Laboratorio", "Tipo de Medicamento", "Uso del Medicamento", "Contenido"],
        propiedades: ["iidmedicamento","codigo", "nombremedicamento", "iidlaboratorio", "iidtipomedicamento", "usomedicamento", "contenido"]
    }
    )
}


//select "IIDMEDICAMENTO", "CODIGO","NOMBREMEDICAMENTO", "IIDLABORATORIO", "IIDTIPOMEDICAMENTO","USOMEDICAMENTO","CONTENIDO" 


//window.onload = function () {
//    listarMedicamentos();
//}


//function listarMedicamentos() {
//    fetchGet("Medicamento/saludos", "text", function (res) {
//        alert(res);

//    })
//    fetchGet("Medicamento/numero", "text", function (res) {
//        alert(res);

//    })
//}

