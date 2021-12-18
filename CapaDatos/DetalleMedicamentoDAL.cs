using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using CapaEntidad;
using Microsoft.Extensions.Configuration;


namespace CapaDatos
{
    public class DetalleMedicamentoDAL : CadenaDAL
    {
        public List<DetalleMedicamentoCLS> ListarDetalleMedicamentos()
        {
            List<DetalleMedicamentoCLS> lista = null;

            using (SqlConnection db = new SqlConnection(cadena))
            {
                try
                {
                    db.Open();
                    using (SqlCommand cmd = new SqlCommand(" select IIDMEDICAMENTOLABORATORIO,IIDMEDICAMENTO,IIDLABOTATORIO,PRECIOCOMPRA,PRECIOVENTA,STOCK,IIDMARCA,IIDENVOLTURA,CAPACIDADCONTENIDO,IIDTIPOADMINISTRACION,IIDSUCURSAL,FOTOMEDICAMENTO, NOMBREFOTOMEDICAMENTO from DetalleMedicamento where BHABILITADO = 1", db))
                    {
                        cmd.CommandType = CommandType.Text;
                        SqlDataReader drd = cmd.ExecuteReader(CommandBehavior.SingleResult);

                        if (drd != null)
                        {
                            DetalleMedicamentoCLS oDetalleMedicamentoCLS;
                            lista = new List<DetalleMedicamentoCLS>();

                            int postMediLabo = drd.GetOrdinal("IIDMEDICAMENTOLABORATORIO");
                            int postIDmedica = drd.GetOrdinal("IIDMEDICAMENTO");
                            int postIDLabo = drd.GetOrdinal("IIDLABOTATORIO");
                            int postPreciocom = drd.GetOrdinal("PRECIOCOMPRA");
                            int postPrecioVent = drd.GetOrdinal("PRECIOVENTA");
                            int postStock = drd.GetOrdinal("STOCK");
                            int postIdMarca = drd.GetOrdinal("IIDMARCA");                            
                            int postenvoltura = drd.GetOrdinal("IIDENVOLTURA");
                            int postCapacidadcontenido = drd.GetOrdinal("CAPACIDADCONTENIDO");
                            int PosttipoAdmin = drd.GetOrdinal("IIDTIPOADMINISTRACION");
                            int postidsucursal = drd.GetOrdinal("IIDSUCURSAL");
                            int postFotomedicamento = drd.GetOrdinal("FOTOMEDICAMENTO");
                            int postnombefotomedi0 = drd.GetOrdinal("NOMBREFOTOMEDICAMENTO");

                            while (drd.Read())
                            {
                                oDetalleMedicamentoCLS = new DetalleMedicamentoCLS();
                                oDetalleMedicamentoCLS.IIDMEDICAMENTOLABORATORIO = drd.IsDBNull(postMediLabo) ? 0 : drd.GetInt32(postMediLabo);
                                oDetalleMedicamentoCLS.IIDMEDICAMENTO = drd.IsDBNull(postIDmedica) ? "" : drd.GetString(postIDmedica);
                                oDetalleMedicamentoCLS.IIDLABOTATORIO = drd.IsDBNull(postIDLabo) ? "" : drd.GetString(postIDLabo);
                                oDetalleMedicamentoCLS.PRECIOCOMPRA = drd.IsDBNull(postPreciocom) ? "" : drd.GetString(postPreciocom);
                                oDetalleMedicamentoCLS.PRECIOVENTA = drd.IsDBNull(postPrecioVent) ? "" : drd.GetString(postPrecioVent);
                                oDetalleMedicamentoCLS.STOCK = drd.IsDBNull(postStock) ? "" : drd.GetString(postStock);
                                oDetalleMedicamentoCLS.IIDMARCA = drd.IsDBNull(postIdMarca) ? "" : drd.GetString(postIdMarca);
                                oDetalleMedicamentoCLS.IIDENVOLTURA = drd.IsDBNull(postenvoltura) ? "" : drd.GetString(postenvoltura);
                                oDetalleMedicamentoCLS.CAPACIDADCONTENIDO = drd.IsDBNull(postCapacidadcontenido) ? "" : drd.GetString(postCapacidadcontenido);
                                oDetalleMedicamentoCLS.IIDTIPOADMINISTRACION = drd.IsDBNull(PosttipoAdmin) ? "" : drd.GetString(PosttipoAdmin);
                                oDetalleMedicamentoCLS.IIDSUCURSAL = drd.IsDBNull(postidsucursal) ? "" : drd.GetString(postidsucursal);
                                oDetalleMedicamentoCLS.FOTOMEDICAMENTO = drd.IsDBNull(postFotomedicamento) ? "" : drd.GetString(postFotomedicamento);
                                oDetalleMedicamentoCLS.NOMBREFOTOMEDICAMENTO = drd.IsDBNull(postnombefotomedi0) ? "" : drd.GetString(postnombefotomedi0);
                                
                                lista.Add(oDetalleMedicamentoCLS);
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