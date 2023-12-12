using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using DAL;

namespace BOL
{
    public class Categoria
    {
        DBAccess conexion = new DBAccess();
        public DataTable Listar()
        {

            return conexion.listarDatos("spu_categorias_listar");
        }
    }
}
