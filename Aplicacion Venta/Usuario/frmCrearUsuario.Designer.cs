using ControlesPersonalizados;
namespace Aplicacion_Venta.Usuario
{
    partial class frmCrearUsuario
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNomUsuario = new System.Windows.Forms.Label();
            this.cbRolUsuario = new System.Windows.Forms.ComboBox();
            this.lblRolUsuario = new System.Windows.Forms.Label();
            this.lblPassUsuario = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.tbNumDocumento = new ControlesPersonalizados.TextBoxEx();
            this.tbPassUsuario = new ControlesPersonalizados.TextBoxEx();
            this.tbNomUsuario = new ControlesPersonalizados.TextBoxEx();
            this.tbApellido = new ControlesPersonalizados.TextBoxEx();
            this.tbNombre = new ControlesPersonalizados.TextBoxEx();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(414, 103);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(414, 152);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNomUsuario
            // 
            this.lblNomUsuario.AutoSize = true;
            this.lblNomUsuario.Location = new System.Drawing.Point(388, 201);
            this.lblNomUsuario.Name = "lblNomUsuario";
            this.lblNomUsuario.Size = new System.Drawing.Size(83, 13);
            this.lblNomUsuario.TabIndex = 5;
            this.lblNomUsuario.Text = "Nombre Usuario";
            // 
            // cbRolUsuario
            // 
            this.cbRolUsuario.FormattingEnabled = true;
            this.cbRolUsuario.Location = new System.Drawing.Point(537, 217);
            this.cbRolUsuario.Name = "cbRolUsuario";
            this.cbRolUsuario.Size = new System.Drawing.Size(216, 21);
            this.cbRolUsuario.TabIndex = 6;
            // 
            // lblRolUsuario
            // 
            this.lblRolUsuario.AutoSize = true;
            this.lblRolUsuario.Location = new System.Drawing.Point(616, 201);
            this.lblRolUsuario.Name = "lblRolUsuario";
            this.lblRolUsuario.Size = new System.Drawing.Size(67, 13);
            this.lblRolUsuario.TabIndex = 7;
            this.lblRolUsuario.Text = "Tipo Usuario";
            // 
            // lblPassUsuario
            // 
            this.lblPassUsuario.AutoSize = true;
            this.lblPassUsuario.Location = new System.Drawing.Point(636, 103);
            this.lblPassUsuario.Name = "lblPassUsuario";
            this.lblPassUsuario.Size = new System.Drawing.Size(61, 13);
            this.lblPassUsuario.TabIndex = 9;
            this.lblPassUsuario.Text = "Contraseña";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(595, 152);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(115, 13);
            this.lblDocumento.TabIndex = 11;
            this.lblDocumento.Text = "Numero de documento";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(608, 271);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 12;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Location = new System.Drawing.Point(391, 271);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarCampos.TabIndex = 13;
            this.btnLimpiarCampos.Text = "Limpiar";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // tbNumDocumento
            // 
            this.tbNumDocumento.borrar = false;
            this.tbNumDocumento.Location = new System.Drawing.Point(534, 168);
            this.tbNumDocumento.Name = "tbNumDocumento";
            this.tbNumDocumento.Size = new System.Drawing.Size(216, 20);
            this.tbNumDocumento.TabIndex = 10;
            this.tbNumDocumento.TipoValidador = ControlesPersonalizados.TipoValidador.SoloNumero;
            // 
            // tbPassUsuario
            // 
            this.tbPassUsuario.borrar = false;
            this.tbPassUsuario.Location = new System.Drawing.Point(534, 119);
            this.tbPassUsuario.Name = "tbPassUsuario";
            this.tbPassUsuario.Size = new System.Drawing.Size(216, 20);
            this.tbPassUsuario.TabIndex = 8;
            this.tbPassUsuario.TipoValidador = ControlesPersonalizados.TipoValidador.LetrasNumeros;
            this.tbPassUsuario.UseSystemPasswordChar = true;
            // 
            // tbNomUsuario
            // 
            this.tbNomUsuario.borrar = false;
            this.tbNomUsuario.Location = new System.Drawing.Point(312, 217);
            this.tbNomUsuario.Name = "tbNomUsuario";
            this.tbNomUsuario.Size = new System.Drawing.Size(216, 20);
            this.tbNomUsuario.TabIndex = 4;
            this.tbNomUsuario.TipoValidador = ControlesPersonalizados.TipoValidador.SoloLetras;
            // 
            // tbApellido
            // 
            this.tbApellido.borrar = false;
            this.tbApellido.Location = new System.Drawing.Point(312, 168);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(216, 20);
            this.tbApellido.TabIndex = 2;
            this.tbApellido.TipoValidador = ControlesPersonalizados.TipoValidador.SoloLetras;
            // 
            // tbNombre
            // 
            this.tbNombre.borrar = false;
            this.tbNombre.Location = new System.Drawing.Point(312, 119);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(216, 20);
            this.tbNombre.TabIndex = 0;
            this.tbNombre.TipoValidador = ControlesPersonalizados.TipoValidador.SoloLetras;
            // 
            // frmCrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 467);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.tbNumDocumento);
            this.Controls.Add(this.lblPassUsuario);
            this.Controls.Add(this.tbPassUsuario);
            this.Controls.Add(this.lblRolUsuario);
            this.Controls.Add(this.cbRolUsuario);
            this.Controls.Add(this.lblNomUsuario);
            this.Controls.Add(this.tbNomUsuario);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.tbNombre);
            this.Name = "frmCrearUsuario";
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.frmCrearUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBoxEx tbNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private TextBoxEx tbApellido;
        private System.Windows.Forms.Label lblNomUsuario;
        private TextBoxEx tbNomUsuario;
        private System.Windows.Forms.ComboBox cbRolUsuario;
        private System.Windows.Forms.Label lblRolUsuario;
        private System.Windows.Forms.Label lblPassUsuario;
        private TextBoxEx tbPassUsuario;
        private System.Windows.Forms.Label lblDocumento;
        private TextBoxEx tbNumDocumento;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnLimpiarCampos;
    }
}