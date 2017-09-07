using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApInfra.Validaciones;

namespace Aplicacion_Venta.Forms
{
    public partial class CrearUsuario : UserControl
    {
        public CrearUsuario()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Dictionary<string, Object> validar = new Dictionary<string, object>();
            validar.Add(lblApellido.Text, tbApellido);
            validar.Add(lblDocumento.Text, tbNumDocumento);
            validar.Add(lblNombre.Text, tbNombre);
            validar.Add(lblNomUsuario.Text, tbNomUsuario);
            validar.Add(lblPassUsuario.Text, tbPassUsuario);

            var listaErrores = Validador.ValidarCampos(validar);

            if(listaErrores.Count > 0)
            {
                MessageBox.Show(Validador.ErroresMensaje(listaErrores));
                return;
            }
        }
    }
}
