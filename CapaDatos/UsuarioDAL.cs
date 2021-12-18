<<<<<<< HEAD
﻿using System;
=======
using System;
>>>>>>> b0d435beb7a739e0965cb5cdc46a45aee272ac53
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using CapaEntidad;
using Microsoft.Extensions.Configuration;

namespace CapaDatos
{
    public class UsuarioDAL : CadenaDAL
    {

        public List<UsuarioCLS> ListarUsuarios()
        {
            List<UsuarioCLS> lista = null;

            using (SqlConnection db = new SqlConnection(cadena))
            {
                try
                {
                    db.Open();
                    using (SqlCommand cmd = new SqlCommand("select iidusuario, nombreusuario,iidtipousuario, contra from Usuario where BHABILITADO = 1", db))
                    {
                        cmd.CommandType = CommandType.Text;
                        SqlDataReader drd = cmd.ExecuteReader(CommandBehavior.SingleResult);

                        if (drd != null)
                        {
                            UsuarioCLS oUsuarioCLS;
                            lista = new List<UsuarioCLS>();

                            int postId = drd.GetOrdinal("iidusuario");
                            int postNombreUsuario = drd.GetOrdinal("nombreusuario");
                            int postTipoUsuarios = drd.GetOrdinal("iidtipousuario");
                            int postContra = drd.GetOrdinal("contra");


                            while (drd.Read())
                            {
                                oUsuarioCLS = new UsuarioCLS();
                                oUsuarioCLS.iidusuario = drd.IsDBNull(postId) ? 0 : drd.GetInt32(postId);
                                oUsuarioCLS.nombreusuario = drd.IsDBNull(postNombreUsuario) ? "" : drd.GetString(postNombreUsuario);
                                oUsuarioCLS.iidtipousuario = drd.IsDBNull(postTipoUsuarios) ? 0 : drd.GetInt32(postTipoUsuarios);
                                oUsuarioCLS.contra = drd.IsDBNull(postContra) ? "" : drd.GetString(postContra);
                                lista.Add(oUsuarioCLS);
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
<<<<<<< HEAD
}
=======
}
>>>>>>> b0d435beb7a739e0965cb5cdc46a45aee272ac53
