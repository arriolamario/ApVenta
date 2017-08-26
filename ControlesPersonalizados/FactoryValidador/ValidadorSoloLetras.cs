using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlesPersonalizados
{
    public class ValidadorSoloLetras : IValidador
    {
        public void validar(KeyPressEventArgs e)
        {
            //Solo letras
            if (Char.IsLetterOrDigit(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar))
            {
                if (!char.IsLetter(e.KeyChar))
                    e.Handled = true;
            }
        }
    }
}
