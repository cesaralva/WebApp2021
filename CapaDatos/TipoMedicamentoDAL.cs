using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using CapaEntidad;
using Microsoft.Extensions.Configuration;

namespace CapaDatos
{
    public class TipoMedicamentoDAL : CadenaDAL
    {

        public List<TipoMedicamentoCLS> ListarMedicamentos()
        {
            List<TipoMedicamentoCLS> lista = null;

            using (SqlConnection db = new SqlConnection(cadena))
            {
                try
                {
                    db.Open();
                    using (SqlCommand cmd = new SqlCommand("select nombre, iidtipomedicamento,  descripcion from TipoMedicamento where BHABILITADO = 1", db))
                    {
                        cmd.CommandType = CommandType.Text;
                        SqlDataReader drd = cmd.ExecuteReader(CommandBehavior.SingleResult);

                        if (drd != null)
                        {
                            TipoMedicamentoCLS oTipoMedicamentoCLS;
                            lista = new List<TipoMedicamentoCLS>();

                            int postId = drd.GetOrdinal("iidtipomedicamento");
                            int postNombre = drd.GetOrdinal("nombre");
                            int postDescripcion = drd.GetOrdinal("descripcion");

                            while (drd.Read())
                            {
                                oTipoMedicamentoCLS = new TipoMedicamentoCLS();
                                oTipoMedicamentoCLS.iidtipomedicamento = drd.IsDBNull(postId)? 0: drd.GetInt32(postId);
                                oTipoMedicamentoCLS.nombre = drd.IsDBNull(postNombre)? "": drd.GetString(postNombre);
                                oTipoMedicamentoCLS.descripcion = drd.IsDBNull(postDescripcion) ? "": drd.GetString(postDescripcion);
                                lista.Add(oTipoMedicamentoCLS);
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
