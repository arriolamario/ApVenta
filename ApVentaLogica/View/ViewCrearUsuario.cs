using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApVentaLogica.View
{
    public static class ViewCrearUsuario
    {


        private static void InitializeComponent(Panel principal)
        {
            Panel pnlBotonesCrearUsuario;
            Panel pnlContenidoCrearUsuario;
            Button btnCrear;
            TextBox tbContraseña;
            Label lblContraseña;
            TextBox tbUsuario;
            Label lblUsuario;
            TextBox tbApellido;
            Label lblApellido;
            TextBox tbNombre;
            Label lblNombre;
            pnlBotonesCrearUsuario = new Panel();
            btnCrear = new Button();
            pnlContenidoCrearUsuario = new Panel();
            tbContraseña = new TextBox();
            lblContraseña = new Label();
            tbUsuario = new TextBox();
            lblUsuario = new Label();
            tbApellido = new TextBox();
            lblApellido = new Label();
            tbNombre = new TextBox();
            lblNombre = new Label();
            pnlBotonesCrearUsuario.SuspendLayout();
            pnlContenidoCrearUsuario.SuspendLayout();
            // 
            // pnlBotonesCrearUsuario
            // 
            pnlBotonesCrearUsuario.Controls.Add(btnCrear);
            pnlBotonesCrearUsuario.Dock = DockStyle.Bottom;
            pnlBotonesCrearUsuario.Location = new System.Drawing.Point(0, 343);
            pnlBotonesCrearUsuario.Name = "pnlBotonesCrearUsuario";
            pnlBotonesCrearUsuario.Padding = new Padding(10);
            pnlBotonesCrearUsuario.Size = new System.Drawing.Size(540, 100);
            pnlBotonesCrearUsuario.TabIndex = 0;
            // 
            // btnCrear
            // 
            btnCrear.Dock = DockStyle.Right;
            btnCrear.Location = new System.Drawing.Point(455, 10);
            btnCrear.Name = "btnCrear";
            btnCrear.Padding = new Padding(10);
            btnCrear.Size = new System.Drawing.Size(75, 80);
            btnCrear.TabIndex = 0;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            // 
            // pnlContenidoCrearUsuario
            // 
            pnlContenidoCrearUsuario.Controls.Add(tbContraseña);
            pnlContenidoCrearUsuario.Controls.Add(lblContraseña);
            pnlContenidoCrearUsuario.Controls.Add(tbUsuario);
            pnlContenidoCrearUsuario.Controls.Add(lblUsuario);
            pnlContenidoCrearUsuario.Controls.Add(tbApellido);
            pnlContenidoCrearUsuario.Controls.Add(lblApellido);
            pnlContenidoCrearUsuario.Controls.Add(tbNombre);
            pnlContenidoCrearUsuario.Controls.Add(lblNombre);
            pnlContenidoCrearUsuario.Dock = DockStyle.Fill;
            pnlContenidoCrearUsuario.Location = new System.Drawing.Point(0, 0);
            pnlContenidoCrearUsuario.Margin = new Padding(6);
            pnlContenidoCrearUsuario.Name = "pnlContenidoCrearUsuario";
            pnlContenidoCrearUsuario.Padding = new Padding(40, 60, 40, 0);
            pnlContenidoCrearUsuario.Size = new System.Drawing.Size(540, 343);
            pnlContenidoCrearUsuario.TabIndex = 1;
            //pnlContenidoCrearUsuario.Paint += new PaintEventHandler(pnlContenidoCrearUsuario_Paint);
            // 
            // tbContraseña
            // 
            tbContraseña.Dock = DockStyle.Top;
            tbContraseña.Location = new System.Drawing.Point(40, 212);
            tbContraseña.Name = "tbContraseña";
            tbContraseña.Size = new System.Drawing.Size(460, 20);
            tbContraseña.TabIndex = 7;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Dock = DockStyle.Top;
            lblContraseña.Location = new System.Drawing.Point(40, 189);
            lblContraseña.Margin = new Padding(5);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Padding = new Padding(5);
            lblContraseña.Size = new System.Drawing.Size(71, 23);
            lblContraseña.TabIndex = 6;
            lblContraseña.Text = "Contraseña";
            lblContraseña.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbUsuario
            // 
            tbUsuario.Dock = DockStyle.Top;
            tbUsuario.Location = new System.Drawing.Point(40, 169);
            tbUsuario.Name = "tbUsuario";
            tbUsuario.Size = new System.Drawing.Size(460, 20);
            tbUsuario.TabIndex = 5;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Dock = DockStyle.Top;
            lblUsuario.Location = new System.Drawing.Point(40, 146);
            lblUsuario.Margin = new Padding(5);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Padding = new Padding(5);
            lblUsuario.Size = new System.Drawing.Size(53, 23);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Usuario";
            lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbApellido
            // 
            tbApellido.Dock = DockStyle.Top;
            tbApellido.Location = new System.Drawing.Point(40, 126);
            tbApellido.Name = "tbApellido";
            tbApellido.Size = new System.Drawing.Size(460, 20);
            tbApellido.TabIndex = 3;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Dock = DockStyle.Top;
            lblApellido.Location = new System.Drawing.Point(40, 103);
            lblApellido.Margin = new Padding(5);
            lblApellido.Name = "lblApellido";
            lblApellido.Padding = new Padding(5);
            lblApellido.Size = new System.Drawing.Size(54, 23);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido";
            lblApellido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbNombre
            // 
            tbNombre.Dock = DockStyle.Top;
            tbNombre.Location = new System.Drawing.Point(40, 83);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new System.Drawing.Size(460, 20);
            tbNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Dock = DockStyle.Top;
            lblNombre.Location = new System.Drawing.Point(40, 60);
            lblNombre.Margin = new Padding(5);
            lblNombre.Name = "lblNombre";
            lblNombre.Padding = new Padding(5);
            lblNombre.Size = new System.Drawing.Size(54, 23);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormCrearUsuario
            // 
            pnlBotonesCrearUsuario.ResumeLayout(false);
            pnlContenidoCrearUsuario.ResumeLayout(false);
            pnlContenidoCrearUsuario.PerformLayout();
        }

    }
}
