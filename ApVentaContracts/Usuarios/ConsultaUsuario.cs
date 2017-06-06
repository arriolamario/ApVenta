using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApVentaContracts.Usuarios
{
    public class ConsultaUsuario
    {
        public UsuarioDTO usuario { get; set; }

        public string mensaje { get; set; }

        public bool valido { get; set; }
    }
}
