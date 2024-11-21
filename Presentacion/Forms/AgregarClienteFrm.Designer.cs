namespace Presentacion.Forms
{
    partial class AgregarClienteFrm
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
            lblNombreCliente = new Label();
            lblApellidoCliente = new Label();
            lblDireccion = new Label();
            lblEmail = new Label();
            lblTel = new Label();
            txtApellidoCliente = new TextBox();
            txtNombreCliente = new TextBox();
            txtDireCliente = new TextBox();
            txtTelCliente = new TextBox();
            txtEmailCliente = new TextBox();
            lblTitulo = new Label();
            pictureBox1 = new PictureBox();
            btnConfirmarCliente = new Button();
            btnCancelar = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.BorderStyle = BorderStyle.Fixed3D;
            lblNombreCliente.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreCliente.ForeColor = Color.White;
            lblNombreCliente.Location = new Point(121, 171);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(65, 19);
            lblNombreCliente.TabIndex = 5;
            lblNombreCliente.Text = "Nombre:";
            // 
            // lblApellidoCliente
            // 
            lblApellidoCliente.AutoSize = true;
            lblApellidoCliente.BorderStyle = BorderStyle.FixedSingle;
            lblApellidoCliente.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            lblApellidoCliente.ForeColor = Color.White;
            lblApellidoCliente.Location = new Point(121, 217);
            lblApellidoCliente.Name = "lblApellidoCliente";
            lblApellidoCliente.Size = new Size(67, 19);
            lblApellidoCliente.TabIndex = 6;
            lblApellidoCliente.Text = "Apellido:";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.BorderStyle = BorderStyle.Fixed3D;
            lblDireccion.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            lblDireccion.ForeColor = Color.White;
            lblDireccion.Location = new Point(121, 265);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(75, 19);
            lblDireccion.TabIndex = 7;
            lblDireccion.Text = "Dirección:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BorderStyle = BorderStyle.Fixed3D;
            lblEmail.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(121, 351);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(50, 19);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email:";
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.BorderStyle = BorderStyle.FixedSingle;
            lblTel.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            lblTel.ForeColor = Color.White;
            lblTel.Location = new Point(121, 308);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(71, 19);
            lblTel.TabIndex = 9;
            lblTel.Text = "Télefono:";
            // 
            // txtApellidoCliente
            // 
            txtApellidoCliente.ContextMenuStrip = contextMenuStrip1;
            txtApellidoCliente.Location = new Point(203, 211);
            txtApellidoCliente.Name = "txtApellidoCliente";
            txtApellidoCliente.Size = new Size(172, 23);
            txtApellidoCliente.TabIndex = 2;
            txtApellidoCliente.KeyDown += txtApellidoCliente_KeyDown;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.ContextMenuStrip = contextMenuStrip1;
            txtNombreCliente.Location = new Point(203, 165);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(172, 23);
            txtNombreCliente.TabIndex = 1;
            txtNombreCliente.KeyDown += txtNombreCliente_KeyDown;
            // 
            // txtDireCliente
            // 
            txtDireCliente.ContextMenuStrip = contextMenuStrip1;
            txtDireCliente.Location = new Point(203, 259);
            txtDireCliente.Name = "txtDireCliente";
            txtDireCliente.Size = new Size(172, 23);
            txtDireCliente.TabIndex = 3;
            txtDireCliente.KeyDown += txtDireCliente_KeyDown;
            // 
            // txtTelCliente
            // 
            txtTelCliente.ContextMenuStrip = contextMenuStrip1;
            txtTelCliente.Location = new Point(203, 302);
            txtTelCliente.Name = "txtTelCliente";
            txtTelCliente.Size = new Size(172, 23);
            txtTelCliente.TabIndex = 4;
            txtTelCliente.KeyDown += txtTelCliente_KeyDown;
            // 
            // txtEmailCliente
            // 
            txtEmailCliente.ContextMenuStrip = contextMenuStrip1;
            txtEmailCliente.Location = new Point(203, 345);
            txtEmailCliente.Name = "txtEmailCliente";
            txtEmailCliente.Size = new Size(172, 23);
            txtEmailCliente.TabIndex = 5;
            txtEmailCliente.KeyDown += txtEmailCliente_KeyDown;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BorderStyle = BorderStyle.Fixed3D;
            lblTitulo.FlatStyle = FlatStyle.Popup;
            lblTitulo.Font = new Font("Yu Gothic", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(179, 50);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(165, 23);
            lblTitulo.TabIndex = 15;
            lblTitulo.Text = "AGREGAR CLIENTE";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.comentarios_de_los_clientes;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.ErrorImage = null;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(511, 496);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // btnConfirmarCliente
            // 
            btnConfirmarCliente.BackColor = Color.Gainsboro;
            btnConfirmarCliente.FlatStyle = FlatStyle.Popup;
            btnConfirmarCliente.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmarCliente.Location = new Point(89, 429);
            btnConfirmarCliente.Name = "btnConfirmarCliente";
            btnConfirmarCliente.Size = new Size(97, 31);
            btnConfirmarCliente.TabIndex = 6;
            btnConfirmarCliente.Text = "Confirmar";
            btnConfirmarCliente.UseVisualStyleBackColor = false;
            btnConfirmarCliente.Click += btnConfirmarCliente_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Gainsboro;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(361, 429);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(97, 31);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // AgregarClienteFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 61, 116);
            ClientSize = new Size(511, 496);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(btnConfirmarCliente);
            Controls.Add(btnCancelar);
            Controls.Add(lblTitulo);
            Controls.Add(txtEmailCliente);
            Controls.Add(txtTelCliente);
            Controls.Add(txtDireCliente);
            Controls.Add(txtNombreCliente);
            Controls.Add(txtApellidoCliente);
            Controls.Add(lblTel);
            Controls.Add(lblEmail);
            Controls.Add(lblDireccion);
            Controls.Add(lblApellidoCliente);
            Controls.Add(lblNombreCliente);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            Name = "AgregarClienteFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo cliente";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombreCliente;
        private Label lblApellidoCliente;
        private Label lblDireccion;
        private Label lblEmail;
        private Label lblTel;
        private TextBox txtApellidoCliente;
        private TextBox txtNombreCliente;
        private TextBox txtDireCliente;
        private TextBox txtTelCliente;
        private TextBox txtEmailCliente;
        private Label lblTitulo;
        private PictureBox pictureBox1;
        private Button btnConfirmarCliente;
        private Button btnCancelar;
        private ContextMenuStrip contextMenuStrip1;
    }
}