using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using CapaEntidad;
using Microsoft.Extensions.Configuration;


namespace CapaDatos
{
    public class VentaDAL :CadenaDAL
    {
        public List<VentaCLS> ListarVentas()
        {
            List<VentaCLS> lista = null;

            using (SqlConnection db = new SqlConnection(cadena))
            {
                try
                {
                    db.Open();
                    using (SqlCommand cmd = new SqlCommand("select iidventa, iidusuariocliente,iidusuarioventa, iidtipodocumento, vobservacion, totalpagar, pagocon, dfechaventa from venta where BHABILITADO = 1", db))
                    {
                        cmd.CommandType = CommandType.Text;
                        SqlDataReader drd = cmd.ExecuteReader(CommandBehavior.SingleResult);

                        if (drd != null)
                        {
                            VentaCLS oVentaCLS;
                            lista = new List<VentaCLS>();

                            int postVenta = drd.GetOrdinal("iidventa");
                            int postUsuarioCliente = drd.GetOrdinal("iidusuariocliente");
                            int postUsuarioVenta = drd.GetOrdinal("iidusuarioventa");
                            int postTipoDocumento = drd.GetOrdinal("iidtipodocumento");
                            int postVobservacion = drd.GetOrdinal("vobservacion");
                            int postTotalPagar = drd.GetOrdinal("totalpagar");
                            int postPagocon = drd.GetOrdinal("pagocon");
                            int postDfechaventa = drd.GetOrdinal("dfechaventa");

                            while (drd.Read())
                            {
                                DateTime Tiempo = new DateTime(1900,1,1);//01/01/1900;
                                oVentaCLS = new VentaCLS();
                                oVentaCLS.iidventa = drd.IsDBNull(postVenta) ? 0 : drd.GetInt32(postVenta);
                                oVentaCLS.iidusuariocliente = drd.IsDBNull(postUsuarioCliente) ? "" : drd.GetString(postUsuarioCliente);
                                oVentaCLS.iidusuarioventa = drd.IsDBNull(postUsuarioVenta) ? "" : drd.GetString(postUsuarioVenta);
                                oVentaCLS.iidtipodocumento = drd.IsDBNull(postTipoDocumento) ? 0 : drd.GetInt32(postTipoDocumento);
                                oVentaCLS.vobservacion = drd.IsDBNull(postVobservacion) ? "" : drd.GetString(postVobservacion);
                                oVentaCLS.totalpagar = drd.IsDBNull(postTotalPagar) ? "" : drd.GetString(postTotalPagar);
                                oVentaCLS.pagocon = drd.IsDBNull(postPagocon) ? "" : drd.GetString(postPagocon);
                                oVentaCLS.dfechaventa = drd.IsDBNull(postDfechaventa) ? Tiempo : drd.GetDateTime(postDfechaventa);

                                lista.Add(oVentaCLS);
                            }
                            db.Close();
                        }
                    }
                }

                catch (Exception ex)
                {
                    db.Close();
                    lista = null;
                }

            }
            return lista;
        }

    }
}
