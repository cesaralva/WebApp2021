using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using CapaEntidad;
using Microsoft.Extensions.Configuration;

namespace CapaDatos
{
    public class MedicamentoDAL : CadenaDAL
    {

        public List<MedicamentoCLS> ListarMedicamentos()
        {
            List<MedicamentoCLS> lista = null;

            using (SqlConnection db = new SqlConnection(cadena))
            {
                try
                {
                    db.Open();
                    using (SqlCommand cmd = new SqlCommand("select IIDMEDICAMENTO, CODIGO, NOMBREMEDICAMENTO, IIDLABORATORIO, IIDTIPOMEDICAMENTO,USOMEDICAMENTO,CONTENIDO from Medicamento where BHABILITADO = 1", db))
                    {
                        cmd.CommandType = CommandType.Text;
                        SqlDataReader drd = cmd.ExecuteReader(CommandBehavior.SingleResult);

                        if (drd != null)
                        {
                            MedicamentoCLS oMedicamentoCLS;
                            lista = new List<MedicamentoCLS>();

                            int postMedicamento = drd.GetOrdinal("IIDMEDICAMENTO");
                            int postCodigo = drd.GetOrdinal("CODIGO");
                            int postNombreMedicamento = drd.GetOrdinal("NOMBREMEDICAMENTO");
                            int postIDlaboratorio = drd.GetOrdinal("IIDLABORATORIO");
                            int postIDTipoMedicamento = drd.GetOrdinal("IIDTIPOMEDICAMENTO");
                            int postUsoMedicamento = drd.GetOrdinal("USOMEDICAMENTO");
                            int postContenido = drd.GetOrdinal("CONTENIDO");


                            while (drd.Read())
                            {
                                oMedicamentoCLS = new MedicamentoCLS();
                                oMedicamentoCLS.IIDMEDICAMENTO = drd.IsDBNull(postMedicamento) ? 0 : drd.GetInt32(postMedicamento);
                                oMedicamentoCLS.CODIGO = drd.IsDBNull(postCodigo) ? "" : drd.GetString(postCodigo);
                                oMedicamentoCLS.NOMBREMEDICAMENTO = drd.IsDBNull(postNombreMedicamento) ? "" : drd.GetString(postNombreMedicamento);
                                oMedicamentoCLS.IIDLABORATORIO = drd.IsDBNull(postIDlaboratorio) ? 0 : drd.GetInt32(postIDlaboratorio);
                                oMedicamentoCLS.IIDTIPOMEDICAMENTO = drd.IsDBNull(postIDTipoMedicamento) ? 0 : drd.GetInt32(postIDTipoMedicamento);
                                oMedicamentoCLS.USOMEDICAMENTO = drd.IsDBNull(postUsoMedicamento) ? "" : drd.GetString(postUsoMedicamento);
                                oMedicamentoCLS.CONTENIDO = drd.IsDBNull(postContenido) ? "" : drd.GetString(postContenido);


                                lista.Add(oMedicamentoCLS);
                            }
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