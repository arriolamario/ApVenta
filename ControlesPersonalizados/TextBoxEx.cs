using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlesPersonalizados
{
    public class TextBoxEx : TextBox
    {
        public bool NoEmpty { get; set; }

        public bool SoloNumero { get; set; }

        public bool Validar()
        {
            bool retorno = true;
            if (NoEmpty)
            {
                retorno = !String.IsNullOrEmpty(this.Text);
            }

            return retorno;
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            if (borrar)
            {
                this.Text = this.Text.Substring(0, this.Text.Length - 1);
            }
        }

        protected override void OnPreviewKeyDown(PreviewKeyDownEventArgs e)
        {
            base.OnPreviewKeyDown(e);
            //if (!SoloNumero) { return; }
            if (e.Alt || e.Control || e.Shift) { return; }

            try
            {
                var valor = e.KeyValue;
                Char valorChar = Convert.ToChar(valor);
                if (!Char.IsNumber(valorChar))
                {
                    borrar = true;
                }
                else
                {
                    borrar = false;
                }
            }
            catch (Exception)
            {
            }
        }

        public bool borrar { get; set; }
    }
}
