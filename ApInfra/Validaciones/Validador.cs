using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApInfra.Validaciones
{
    public static class Validador
    {
        public static List<string> ValidarCampos(Dictionary<string, Object> listaValidacion)
        {
            List<string> errores = new List<string>();
            for (int i = 0; i < listaValidacion.Count; i++)
            {
                var campo = listaValidacion.ElementAt(i);
                if (campo.Value is MaskedTextBox)
                {
                    var campoAux = campo.Value as MaskedTextBox;
                    if (string.IsNullOrEmpty(campoAux.Text))
                    {
                        errores.Add(campo.Key);
                    }
                }
                else if(campo.Value is TextBox)
                {
                    var campoAux = campo.Value as TextBox;
                    if (string.IsNullOrEmpty(campoAux.Text))
                    {
                        errores.Add(campo.Key);
                    }
                }
            }

            return errores;
        }

        public static string ErroresMensaje(List<string> errores)
        {
            String res = "Completar los siguiente campos: \n";
            errores.OrderBy(x => x).ToList().ForEach(x => res += x + "\n");

            return res;
        }
    }
}
