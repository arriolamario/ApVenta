using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApInfra
{
    public class Validacion
    {
        public void Validar(List<Object> ListaAValidar)
        {
            foreach (Object item in ListaAValidar)
            {
                if (item is TextBox || item is MaskedTextBox)
                {
                    
                }
            }
        }
    }


    public class RespuestaValidacion
    {
        public List<string> Errores { get; set; }
        public bool Ok { get; set; }

        public RespuestaValidacion()
        {
            this.Errores = new List<string>();
        }
    }
}
