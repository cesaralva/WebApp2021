using System;

namespace CapaEntidad
{
    public class VentaCLS
    {
        public int iidventa { get; set; }
        public string iidusuariocliente { get; set; }
        public string iidusuarioventa { get; set; }
        public int iidtipodocumento { get; set; }
        public string vobservacion { get; set; }
        public string totalpagar { get; set; }
        public string pagocon { get; set; }
        public DateTime dfechaventa { get; set; }
    }
}
