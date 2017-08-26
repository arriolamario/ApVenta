using ApVentaContracts.Enumerados;
using ApVentaContracts.Entidades;
using ApVentaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aplicacion_Venta.Prueba;

namespace Aplicacion_Venta.Forms
{
    public partial class frmPrincipal : Form
    {
        ucIniciarSesion viewIniciarSesion;
        public frmPrincipal()
        {
            InitializeComponent();
            viewIniciarSesion = new ucIniciarSesion();
            //viewIniciarSesion.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            scPrincipal.Panel2.Controls.Add(viewIniciarSesion);
        }
    }
}
