namespace Presentacion.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            lblPw = new Label();
            lblUser = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            btnIniciarSesion = new Button();
            chkboxShowPw = new CheckBox();
            btnCancelar = new Button();
            linkPw = new LinkLabel();
            pictureBox1 = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblPw
            // 
            lblPw.AutoSize = true;
            lblPw.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblPw.ForeColor = Color.White;
            lblPw.Location = new Point(130, 355);
            lblPw.Name = "lblPw";
            lblPw.Size = new Size(116, 20);
            lblPw.TabIndex = 14;
            lblPw.Text = "Constraseña:";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser.ForeColor = Color.White;
            lblUser.Location = new Point(147, 300);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(76, 20);
            lblUser.TabIndex = 13;
            lblUser.Text = "Usuario:";
            // 
            // txtPassword
            // 
            txtPassword.ContextMenuStrip = contextMenuStrip1;
            txtPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(252, 350);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(201, 25);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.KeyDown += txtPassword_KeyDown;
            // 
            // txtUsername
            // 
            txtUsername.ContextMenuStrip = contextMenuStrip1;
            txtUsername.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(252, 299);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(201, 25);
            txtUsername.TabIndex = 1;
            txtUsername.KeyDown += txtUsername_KeyDown;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.BackColor = Color.Silver;
            btnIniciarSesion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciarSesion.Location = new Point(130, 466);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(145, 38);
            btnIniciarSesion.TabIndex = 4;
            btnIniciarSesion.Text = "Iniciar Sesion";
            btnIniciarSesion.UseVisualStyleBackColor = false;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // chkboxShowPw
            // 
            chkboxShowPw.AutoSize = true;
            chkboxShowPw.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkboxShowPw.ForeColor = Color.White;
            chkboxShowPw.Location = new Point(252, 393);
            chkboxShowPw.Name = "chkboxShowPw";
            chkboxShowPw.Size = new Size(143, 20);
            chkboxShowPw.TabIndex = 3;
            chkboxShowPw.Text = "Mostrar Contraseña";
            chkboxShowPw.UseVisualStyleBackColor = true;
            chkboxShowPw.CheckedChanged += chkboxShowPw_CheckedChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Silver;
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnCancelar.Location = new Point(308, 466);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(145, 38);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // linkPw
            // 
            linkPw.AutoSize = true;
            linkPw.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkPw.Location = new Point(210, 518);
            linkPw.Name = "linkPw";
            linkPw.Size = new Size(163, 21);
            linkPw.TabIndex = 6;
            linkPw.TabStop = true;
            linkPw.Text = "Olvido su contraseña?";
            linkPw.LinkClicked += linkPw_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.Logo_restaurante_marino;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(188, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 220);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 61, 116);
            ClientSize = new Size(583, 592);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(pictureBox1);
            Controls.Add(linkPw);
            Controls.Add(btnCancelar);
            Controls.Add(chkboxShowPw);
            Controls.Add(lblPw);
            Controls.Add(lblUser);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btnIniciarSesion);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += LoginForm_Load;
            KeyDown += LoginForm_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPw;
        private Label lblUser;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Button btnIniciarSesion;
        private CheckBox chkboxShowPw;
        private Button btnCancelar;
        private LinkLabel linkPw;
        private PictureBox pictureBox1;
        private ContextMenuStrip contextMenuStrip1;
    }
}