using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApInfra;

namespace ControlesPersonalizados
{
    public class TextBoxEx : TextBox
    {
        public TextBoxEx()
        {
            TipoValidador = TipoValidador.Todo;
        }

        public TipoValidador TipoValidador { get; set; }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            FactoryValidador.GetValidador(TipoValidador).validar(e);
        }

        public bool borrar { get; set; }

    }
}