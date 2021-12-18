using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;


namespace CapaDatos
{
    public class LaboratorioDAL : CadenaDAL
    {
        public List<LaboratorioCLS> ListarLaboratorio()
        {
            List<LaboratorioCLS> lista = null;

            using (SqlConnection db = new SqlConnection(cadena))
            {
                try
                {
                    db.Open();
                    using (SqlCommand cmd = new SqlCommand("uspListarLaboratorio", db))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataReader drd = cmd.ExecuteReader(CommandBehavior.SingleResult);

                        if (drd != null)
                        {
                            LaboratorioCLS oLaboratorioCLS;
                            lista = new List<LaboratorioCLS>();

                            int postId = drd.GetOrdinal("iidlaboratorio");
                            int postNombre = drd.GetOrdinal("nombre");
                            int postDireccion = drd.GetOrdinal("direccion");
                            int postContacto = drd.GetOrdinal("personacontacto");

                            while (drd.Read())
                            {
                                oLaboratorioCLS = new LaboratorioCLS();
                                oLaboratorioCLS.iidlaboratorio = drd.IsDBNull(postId) ? 0 : drd.GetInt32(postId);
                                oLaboratorioCLS.nombre = drd.IsDBNull(postNombre) ? "" : drd.GetString(postNombre);
                                oLaboratorioCLS.direccion = drd.IsDBNull(postDireccion) ? "" : drd.GetString(postDireccion);
                                oLaboratorioCLS.personacontacto = drd.IsDBNull(postContacto) ? "" : drd.GetString(postContacto);
                                lista.Add(oLaboratorioCLS);
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