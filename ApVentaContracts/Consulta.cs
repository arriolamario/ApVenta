using ApVentaContracts.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApVentaContracts
{
    public class Consulta
    {
        public UsuarioDTO usuario { get; set; }

        public string mensaje { get; set; }

        public bool valido { get; set; }
    }
}
