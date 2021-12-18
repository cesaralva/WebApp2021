function get(idcontrol) {
    return document.getElementById("txtbuscarsucursal").value;
}

function set(idcontrol, valor) {
    return document.getElementById("txtbuscarsucursal").value = valor;
}

async function fetchGet(url, tiporespuesta, callback) {
    try {
        var raiz = document.getElementById("hdfOculto").value;
        //http://...
        var urlCompleta = window.location.protocol + "//" + window.location.host + "/" + raiz + url
        var res = await fetch(urlCompleta)
        if (tiporespuesta == "json")
            res = await res.json();
        else if (tiporespuesta == "text")
            res = await res.text();

        // JSON (Object)
        callback(res)

    } catch (e) {
        alert("Ocurrio un error: " + e);
    }
}

var objConfiguracionGlobal;

// {url:"", columnas:[], propiedades:[]}
function mostrar(objConfiguracion) {
    objConfiguracionGlobal = objConfiguracion;
    fetchGet(objConfiguracion.url, "json", function (res) {
        var contenido = "";

        contenido += generarTabla(res)
        document.getElementById("divTabla").innerHTML = contenido;

    })
}


function generarTabla(res) {

    var contenido = "";
    var cabeceras = objConfiguracionGlobal.cabeceras;
    var propiedades = objConfiguracionGlobal.propiedades;

    contenido += "<table class='table'>";
    contenido += "<thead>";
    contenido += "<tr>";
    for (var i = 0; i < cabeceras.length; i++) {
        contenido += "<td>" + cabeceras[i] + "</td>";
    }
    contenido += "</tr>";
    contenido += "</thead>";

    var nregistros = res.length
    var obj;
    var propiedadActual;

    contenido += "<tbody>";
    for (var i = 0; i < nregistros; i++) {
        obj = res[i]
        contenido += "<tr>";
        for (var j = 0; j < propiedades.length; j++) {
            propiedadActual = propiedades[j]
            contenido += "<td>" + obj[propiedadActual] + "</td>";
        }
        contenido += "</tr>";
    }

    contenido += "</tbody>";

    contenido += "</table>";
    return contenido;
}
