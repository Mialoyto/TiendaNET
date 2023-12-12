using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DAL
{
    public class DBAccess
    {
        private SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["AccesoTiendaNET"].ConnectionString);


        public SqlConnection getConexion()
        {
            return this.conexion;
        }

        public void abrirConexion()
        {
            if (this.conexion.State == ConnectionState.Closed)
            {
                this.conexion.Open();
            }
        }

        public void cerrarConexion()
        {
            if (this.conexion.State == ConnectionState.Open)
            {
                this.conexion.Close();
            }
        }


        /// <summary>
        /// Metodo general que retorna una conexion de datos de una consulta que no tiene variables de entradas
        /// </summary>
        /// <param name="spu">Nombre del Store Procedure</param>
        /// <returns>
        /// colecion de datos de tipo DataTable
        /// </returns>
        public DataTable listarDatos(string spu)
        {
            DataTable dt = new DataTable();

            this.abrirConexion();

            SqlCommand comando = new SqlCommand(spu, this.getConexion());

            comando.CommandType = CommandType.StoredProcedure;

            dt.Load(comando.ExecuteReader());

            this.cerrarConexion();

            return dt;
        }


        public DataTable listarDatosVariable(string spu, string nombreVarianble, object valorVariable)
        {
            DataTable dt = new DataTable();

            this.abrirConexion();

            SqlCommand comando = new SqlCommand(spu, this.getConexion());

            comando.CommandType = CommandType.StoredProcedure;
            //AGREGAR PARAMETRO DE ENTRADAS

            comando.Parameters.AddWithValue(nombreVarianble, valorVariable);

            dt.Load(comando.ExecuteReader());

            this.cerrarConexion();

            return dt;

        }
    }

    
}
