using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlesPersonalizados
{
    public class ValidadorSoloNumeros : IValidador
    {
        public void validar(KeyPressEventArgs e)
        {
            //Solo numero
            if (Char.IsLetterOrDigit(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar))
            {
                if(!char.IsDigit(e.KeyChar))
                    e.Handled = true;
            }
        }
    }
}
