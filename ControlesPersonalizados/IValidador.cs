using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlesPersonalizados
{
    public interface IValidador
    {
        void validar(KeyPressEventArgs e);
    }
}
