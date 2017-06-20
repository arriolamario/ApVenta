namespace Aplicacion_Venta.Forms
{
    partial class FormCrearUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlBotonesCrearUsuario = new System.Windows.Forms.Panel();
            this.btnCrear = new System.Windows.Forms.Button();
            this.pnlContenidoCrearUsuario = new System.Windows.Forms.Panel();
            this.tbContraseña = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pnlBotonesCrearUsuario.SuspendLayout();
            this.pnlContenidoCrearUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBotonesCrearUsuario
            // 
            this.pnlBotonesCrearUsuario.Controls.Add(this.btnCrear);
            this.pnlBotonesCrearUsuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotonesCrearUsuario.Location = new System.Drawing.Point(0, 343);
            this.pnlBotonesCrearUsuario.Name = "pnlBotonesCrearUsuario";
            this.pnlBotonesCrearUsuario.Padding = new System.Windows.Forms.Padding(10);
            this.pnlBotonesCrearUsuario.Size = new System.Drawing.Size(540, 100);
            this.pnlBotonesCrearUsuario.TabIndex = 0;
            // 
            // btnCrear
            // 
            this.btnCrear.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCrear.Location = new System.Drawing.Point(455, 10);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Padding = new System.Windows.Forms.Padding(10);
            this.btnCrear.Size = new System.Drawing.Size(75, 80);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            // 
            // pnlContenidoCrearUsuario
            // 
            this.pnlContenidoCrearUsuario.Controls.Add(this.tbContraseña);
            this.pnlContenidoCrearUsuario.Controls.Add(this.lblContraseña);
            this.pnlContenidoCrearUsuario.Controls.Add(this.tbUsuario);
            this.pnlContenidoCrearUsuario.Controls.Add(this.lblUsuario);
            this.pnlContenidoCrearUsuario.Controls.Add(this.tbApellido);
            this.pnlContenidoCrearUsuario.Controls.Add(this.lblApellido);
            this.pnlContenidoCrearUsuario.Controls.Add(this.tbNombre);
            this.pnlContenidoCrearUsuario.Controls.Add(this.lblNombre);
            this.pnlContenidoCrearUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenidoCrearUsuario.Location = new System.Drawing.Point(0, 0);
            this.pnlContenidoCrearUsuario.Margin = new System.Windows.Forms.Padding(6);
            this.pnlContenidoCrearUsuario.Name = "pnlContenidoCrearUsuario";
            this.pnlContenidoCrearUsuario.Padding = new System.Windows.Forms.Padding(40, 60, 40, 0);
            this.pnlContenidoCrearUsuario.Size = new System.Drawing.Size(540, 343);
            this.pnlContenidoCrearUsuario.TabIndex = 1;
            this.pnlContenidoCrearUsuario.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContenidoCrearUsuario_Paint);
            // 
            // tbContraseña
            // 
            this.tbContraseña.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbContraseña.Location = new System.Drawing.Point(40, 212);
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.Size = new System.Drawing.Size(460, 20);
            this.tbContraseña.TabIndex = 7;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblContraseña.Location = new System.Drawing.Point(40, 189);
            this.lblContraseña.Margin = new System.Windows.Forms.Padding(5);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Padding = new System.Windows.Forms.Padding(5);
            this.lblContraseña.Size = new System.Drawing.Size(71, 23);
            this.lblContraseña.TabIndex = 6;
            this.lblContraseña.Text = "Contraseña";
            this.lblContraseña.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbUsuario
            // 
            this.tbUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbUsuario.Location = new System.Drawing.Point(40, 169);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(460, 20);
            this.tbUsuario.TabIndex = 5;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUsuario.Location = new System.Drawing.Point(40, 146);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(5);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Padding = new System.Windows.Forms.Padding(5);
            this.lblUsuario.Size = new System.Drawing.Size(53, 23);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbApellido
            // 
            this.tbApellido.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbApellido.Location = new System.Drawing.Point(40, 126);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(460, 20);
            this.tbApellido.TabIndex = 3;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblApellido.Location = new System.Drawing.Point(40, 103);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(5);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Padding = new System.Windows.Forms.Padding(5);
            this.lblApellido.Size = new System.Drawing.Size(54, 23);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido";
            this.lblApellido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbNombre
            // 
            this.tbNombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbNombre.Location = new System.Drawing.Point(40, 83);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(460, 20);
            this.tbNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNombre.Location = new System.Drawing.Point(40, 60);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(5);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Padding = new System.Windows.Forms.Padding(5);
            this.lblNombre.Size = new System.Drawing.Size(54, 23);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormCrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 443);
            this.Controls.Add(this.pnlContenidoCrearUsuario);
            this.Controls.Add(this.pnlBotonesCrearUsuario);
            this.Name = "FormCrearUsuario";
            this.Text = "Form1";
            this.pnlBotonesCrearUsuario.ResumeLayout(false);
            this.pnlContenidoCrearUsuario.ResumeLayout(false);
            this.pnlContenidoCrearUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBotonesCrearUsuario;
        private System.Windows.Forms.Panel pnlContenidoCrearUsuario;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.TextBox tbContraseña;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lblNombre;
    }
}