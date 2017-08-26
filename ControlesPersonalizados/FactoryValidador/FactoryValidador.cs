using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlesPersonalizados
{
    public enum TipoValidador { SoloNumero, SoloLetras, LetrasNumeros, Todo};
    public static class FactoryValidador
    {
        public static IValidador GetValidador(TipoValidador tipo)
        {
            IValidador validador = default(IValidador);
            switch (tipo)
            {
                case TipoValidador.SoloNumero:
                    validador = new ValidadorSoloNumeros();
                    break;
                case TipoValidador.SoloLetras:
                    validador = new ValidadorSoloLetras();
                    break;
                case TipoValidador.LetrasNumeros:
                    validador = new ValidadorLetrasNumeros();
                    break;
                default:
                    validador = new ValidadorTodo();
                    break;
            }

            return validador;
        }
    }
}
