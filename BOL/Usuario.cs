using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL; // ACCESO A CONEXION SERVER + DB
using System.Data;  // OBJETOS MANEJADORES DE DATOS - EN LA MEMORIA
using System.Data.SqlClient; // ACCESO 'MSSQL' SERVER
using ENTITIES;     // ESTRUCTURA QUE CONTENDRAN LOS DATOS


namespace BOL
{
    // CLASE PUBLICA
    public class Usuario
    {

        // INSTANCIA DE LA CLASE DE CONEXION
        DBAccess conexion = new DBAccess();

        // METOSO QUE INICIE SESION
        /// <summary>
        /// Iniciar sesión utilizando datos del servidor
        /// </summary>
        /// <param name="email">Identificar o nombre de usuario</param>
        /// <returns>
        /// Objeto contenido toda la fila (varios campos)
        /// </returns>
        public DataTable iniciarSesion(string email)
        {
            // 1. OBJETO QUE CONTENDRA EL RESULTADO
            DataTable dt = new DataTable();

            //2. ABRIR CONEXION
            conexion.abrirConexion();

            //3. OBJETO PARA ENVIAR CONSULTA
            SqlCommand comando = new SqlCommand("spu_usuarios_login",conexion.getConexion());

            // 4.TIPO DE COMANDO ( procedimiento almacenado)
            comando.CommandType = CommandType.StoredProcedure;

            // 5. PASR LA VARIABLE
            comando.Parameters.AddWithValue("@email", email);

            // 6. EJECUTAR Y OBTENER LOS DATOS
            //comando.ExecuteNonQuery();
            dt.Load(comando.ExecuteReader());

            // 7. CERRAR
            conexion.cerrarConexion();

            // 8. .RETORNAMOS EL OBJETO CON LA INFO
            return dt;
        }


        public DataTable Login(string email)
        {
            return conexion.listarDatosVariable("spu_usuarios_listar", "@email", email);
        }
        // REGISTRAR USUARIO CON EL PROCEDIMIENTO ALMACENADO
        
        public int Registrar(EUsuario entidad)
        {

            int totalRegistros = 0;
            SqlCommand comando = new SqlCommand("spu_usuarios_registrar", conexion.getConexion());
            comando.CommandType = CommandType.StoredProcedure;

            
            conexion.abrirConexion();


            try
            {
                comando.Parameters.AddWithValue("@apellidos", entidad.apellidos);
                comando.Parameters.AddWithValue("@nombres", entidad.nombres);
                comando.Parameters.AddWithValue("@email", entidad.email);
                comando.Parameters.AddWithValue("@claveacceso", entidad.claveAcceso);
                comando.Parameters.AddWithValue("@nivelacceso", entidad.nivelAcceso);
                
                // ExecuteNonQuery -> Solo ejecuta
                totalRegistros = comando.ExecuteNonQuery();

            }
            catch (Exception )
            {
                totalRegistros = -1;
            }
            finally
            {
                conexion.cerrarConexion();
            }

            return totalRegistros;
        }

        public DataTable Listar()
        {
            DataTable dt = new DataTable();

            SqlCommand comando = new SqlCommand("spu_usuarios_listar", conexion.getConexion());
            comando.CommandType = CommandType.StoredProcedure;

            conexion.abrirConexion();
            dt.Load(comando.ExecuteReader());
            conexion.cerrarConexion();

            return dt;
        }

    }
}
