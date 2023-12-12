using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
using System.Data;
using System.Data.SqlClient;
using ENTITIES;
namespace BOL
{
    public class Producto
    {

        DBAccess conexion = new DBAccess();

        public DataTable Listar()
        {
           DataTable dt = new DataTable();

            /* conexion.abrirConexion();

            SqlCommand comando = new SqlCommand("spu_productos_listar", conexion.getConexion());

            comando.CommandType = CommandType.StoredProcedure;

            dt.Load(comando.ExecuteReader());

            conexion.cerrarConexion();

            return dt;*/

            return conexion.listarDatos("spu_productos_listar");
        }




        public int Registrar(EProducto entidad)
        {
            int totalRegistro = 0;
            conexion.abrirConexion();
            try
            {
                SqlCommand comando = new SqlCommand("spu_productos_registrar",conexion.getConexion());
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@idmarca", entidad.idmarca);
                comando.Parameters.AddWithValue("@idsubcategoria", entidad.idsubcartegoria);
                comando.Parameters.AddWithValue("@descripcion", entidad.descripcion);
                comando.Parameters.AddWithValue("@garantia", entidad.garantia);
                comando.Parameters.AddWithValue("@precio", entidad.precio);
                comando.Parameters.AddWithValue("@stock", entidad.stock);

                totalRegistro = comando.ExecuteNonQuery();

            }
            catch
            {
                totalRegistro = -1;
            }
            finally
            {
                conexion.cerrarConexion();
            }
            return totalRegistro;
        }
    }
}
