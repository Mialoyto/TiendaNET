using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using DAL;

namespace BOL
{
    public class Subcategoria
    {
        DBAccess conexion = new DBAccess();

        public DataTable listar(int idcategoria)
        {
            /*DataTable dt = new DataTable();
            conexion.abrirConexion();
            SqlCommand comando = new SqlCommand("spu_subcategorias_listar", conexion.getConexion());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idcategoria", idcategoria);
            dt.Load(comando.ExecuteReader());
            conexion.cerrarConexion();
            return dt;*/

            return conexion.listarDatosVariable("spu_subcategoria_listar", "@idcategoria", idcategoria);
        }
    }
}
