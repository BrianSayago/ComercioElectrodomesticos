namespace Presentacion
{
    partial class RecuperarContraFrm
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
            components = new System.ComponentModel.Container();
            txtEmail = new TextBox();
            lblCorreo = new Label();
            btnEnviarCorreo = new Button();
            btnCancelar = new Button();
            txtUsuarioID = new TextBox();
            label1 = new Label();
            txtContrasena = new TextBox();
            label2 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Enabled = false;
            txtEmail.Location = new Point(209, 67);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(205, 23);
            txtEmail.TabIndex = 0;
            txtEmail.TabStop = false;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCorreo.ForeColor = Color.White;
            lblCorreo.Location = new Point(40, 67);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(153, 17);
            lblCorreo.TabIndex = 1;
            lblCorreo.Text = "Su correo electronico es:";
            // 
            // btnEnviarCorreo
            // 
            btnEnviarCorreo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEnviarCorreo.Location = new Point(310, 167);
            btnEnviarCorreo.Name = "btnEnviarCorreo";
            btnEnviarCorreo.Size = new Size(104, 28);
            btnEnviarCorreo.TabIndex = 2;
            btnEnviarCorreo.Text = "Enviar";
            btnEnviarCorreo.UseVisualStyleBackColor = true;
            btnEnviarCorreo.Click += btnObtenerContrasena_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(28, 167);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(104, 28);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtUsuarioID
            // 
            txtUsuarioID.ContextMenuStrip = contextMenuStrip1;
            txtUsuarioID.Location = new Point(209, 27);
            txtUsuarioID.Name = "txtUsuarioID";
            txtUsuarioID.Size = new Size(72, 23);
            txtUsuarioID.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(40, 28);
            label1.Name = "label1";
            label1.Size = new Size(132, 17);
            label1.TabIndex = 5;
            label1.Text = "Ingrese su UsuarioID:";
            // 
            // txtContrasena
            // 
            txtContrasena.Enabled = false;
            txtContrasena.Location = new Point(209, 111);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.ReadOnly = true;
            txtContrasena.Size = new Size(205, 23);
            txtContrasena.TabIndex = 6;
            txtContrasena.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(40, 111);
            label2.Name = "label2";
            label2.Size = new Size(110, 17);
            label2.TabIndex = 7;
            label2.Text = "Su contraseña es:";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // RecuperarContraFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 61, 116);
            ClientSize = new Size(441, 207);
            Controls.Add(label2);
            Controls.Add(txtContrasena);
            Controls.Add(label1);
            Controls.Add(txtUsuarioID);
            Controls.Add(btnCancelar);
            Controls.Add(btnEnviarCorreo);
            Controls.Add(lblCorreo);
            Controls.Add(txtEmail);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "RecuperarContraFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recuperar contraseña";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private Label lblCorreo;
        private Button btnEnviarCorreo;
        private Button btnCancelar;
        private TextBox txtUsuarioID;
        private Label label1;
        private TextBox txtContrasena;
        private Label label2;
        private ContextMenuStrip contextMenuStrip1;
    }
}