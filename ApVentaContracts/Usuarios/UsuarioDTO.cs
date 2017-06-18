using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApVentaContracts.Usuarios
{
    public partial class UsuarioDTO
    {
        public UsuarioDTO() { }

        public int IdUsuario {get; set;}
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        //public string Documento { get; set; }
        //public bool estado { get; set; }
    }
}
