using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES
{
    public class EUsuario
    {
        public int idusuario { get; set; }
        public string apellidos { get; set; }
        public string nombres { get; set; }
        public string email { get; set; }
        public string claveAcceso { get; set; }
        public string nivelAcceso { get; set; }
    }
}
