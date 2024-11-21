namespace Presentacion.Forms
{
    partial class ModificarClienteFrm
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
            btnGuardarCliente = new Button();
            btnCancelar = new Button();
            lblTitulo = new Label();
            txtEmailCliente = new TextBox();
            txtTelCliente = new TextBox();
            txtDireCliente = new TextBox();
            txtNombreCliente = new TextBox();
            txtApellidoCliente = new TextBox();
            lblTel = new Label();
            lblEmail = new Label();
            lblDireccion = new Label();
            lblApellidoCliente = new Label();
            lblNombreCliente = new Label();
            pictureBox1 = new PictureBox();
            lblClienteID = new Label();
            txtClienteID = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnGuardarCliente
            // 
            btnGuardarCliente.BackColor = Color.Gainsboro;
            btnGuardarCliente.FlatStyle = FlatStyle.Popup;
            btnGuardarCliente.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarCliente.Location = new Point(89, 424);
            btnGuardarCliente.Name = "btnGuardarCliente";
            btnGuardarCliente.Size = new Size(97, 31);
            btnGuardarCliente.TabIndex = 23;
            btnGuardarCliente.Text = "Confirmar";
            btnGuardarCliente.UseVisualStyleBackColor = false;
            btnGuardarCliente.Click += btnGuardarCliente_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Gainsboro;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(361, 424);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(97, 31);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BorderStyle = BorderStyle.Fixed3D;
            lblTitulo.FlatStyle = FlatStyle.Popup;
            lblTitulo.Font = new Font("Yu Gothic", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(179, 45);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(179, 23);
            lblTitulo.TabIndex = 29;
            lblTitulo.Text = "MODIFICAR CLIENTE";
            // 
            // txtEmailCliente
            // 
            txtEmailCliente.ContextMenuStrip = contextMenuStrip1;
            txtEmailCliente.Location = new Point(203, 340);
            txtEmailCliente.Name = "txtEmailCliente";
            txtEmailCliente.Size = new Size(172, 23);
            txtEmailCliente.TabIndex = 21;
            txtEmailCliente.KeyDown += txtEmailCliente_KeyDown;
            // 
            // txtTelCliente
            // 
            txtTelCliente.ContextMenuStrip = contextMenuStrip1;
            txtTelCliente.Location = new Point(203, 297);
            txtTelCliente.Name = "txtTelCliente";
            txtTelCliente.Size = new Size(172, 23);
            txtTelCliente.TabIndex = 20;
            txtTelCliente.KeyDown += txtTelCliente_KeyDown;
            // 
            // txtDireCliente
            // 
            txtDireCliente.ContextMenuStrip = contextMenuStrip1;
            txtDireCliente.Location = new Point(203, 254);
            txtDireCliente.Name = "txtDireCliente";
            txtDireCliente.Size = new Size(172, 23);
            txtDireCliente.TabIndex = 19;
            txtDireCliente.KeyDown += txtDireCliente_KeyDown;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.ContextMenuStrip = contextMenuStrip1;
            txtNombreCliente.Location = new Point(203, 160);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(172, 23);
            txtNombreCliente.TabIndex = 17;
            txtNombreCliente.KeyDown += txtNombreCliente_KeyDown;
            // 
            // txtApellidoCliente
            // 
            txtApellidoCliente.ContextMenuStrip = contextMenuStrip1;
            txtApellidoCliente.Location = new Point(203, 206);
            txtApellidoCliente.Name = "txtApellidoCliente";
            txtApellidoCliente.Size = new Size(172, 23);
            txtApellidoCliente.TabIndex = 18;
            txtApellidoCliente.KeyDown += txtApellidoCliente_KeyDown;
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.BorderStyle = BorderStyle.FixedSingle;
            lblTel.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            lblTel.ForeColor = Color.White;
            lblTel.Location = new Point(121, 303);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(71, 19);
            lblTel.TabIndex = 28;
            lblTel.Text = "Télefono:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BorderStyle = BorderStyle.Fixed3D;
            lblEmail.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(121, 346);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(50, 19);
            lblEmail.TabIndex = 27;
            lblEmail.Text = "Email:";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.BorderStyle = BorderStyle.Fixed3D;
            lblDireccion.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            lblDireccion.ForeColor = Color.White;
            lblDireccion.Location = new Point(121, 260);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(75, 19);
            lblDireccion.TabIndex = 26;
            lblDireccion.Text = "Dirección:";
            // 
            // lblApellidoCliente
            // 
            lblApellidoCliente.AutoSize = true;
            lblApellidoCliente.BorderStyle = BorderStyle.FixedSingle;
            lblApellidoCliente.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            lblApellidoCliente.ForeColor = Color.White;
            lblApellidoCliente.Location = new Point(121, 212);
            lblApellidoCliente.Name = "lblApellidoCliente";
            lblApellidoCliente.Size = new Size(67, 19);
            lblApellidoCliente.TabIndex = 24;
            lblApellidoCliente.Text = "Apellido:";
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.BorderStyle = BorderStyle.Fixed3D;
            lblNombreCliente.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreCliente.ForeColor = Color.White;
            lblNombreCliente.Location = new Point(121, 166);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(65, 19);
            lblNombreCliente.TabIndex = 22;
            lblNombreCliente.Text = "Nombre:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.comentarios_de_los_clientes;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.ContextMenuStrip = contextMenuStrip1;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.ErrorImage = null;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(511, 496);
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // lblClienteID
            // 
            lblClienteID.AutoSize = true;
            lblClienteID.BorderStyle = BorderStyle.Fixed3D;
            lblClienteID.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClienteID.ForeColor = Color.White;
            lblClienteID.Location = new Point(121, 116);
            lblClienteID.Name = "lblClienteID";
            lblClienteID.Size = new Size(74, 19);
            lblClienteID.TabIndex = 31;
            lblClienteID.Text = "ClienteID:";
            // 
            // txtClienteID
            // 
            txtClienteID.ContextMenuStrip = contextMenuStrip1;
            txtClienteID.Location = new Point(203, 112);
            txtClienteID.Name = "txtClienteID";
            txtClienteID.ReadOnly = true;
            txtClienteID.Size = new Size(91, 23);
            txtClienteID.TabIndex = 32;
            txtClienteID.KeyDown += txtClienteID_KeyDown;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // ModificarClienteFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 61, 116);
            ClientSize = new Size(511, 496);
            Controls.Add(txtClienteID);
            Controls.Add(lblClienteID);
            Controls.Add(btnGuardarCliente);
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
            Name = "ModificarClienteFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modificar Cliente";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardarCliente;
        private Button btnCancelar;
        private Label lblTitulo;
        private TextBox txtEmailCliente;
        private TextBox txtTelCliente;
        private TextBox txtDireCliente;
        private TextBox txtNombreCliente;
        private TextBox txtApellidoCliente;
        private Label lblTel;
        private Label lblEmail;
        private Label lblDireccion;
        private Label lblApellidoCliente;
        private Label lblNombreCliente;
        private PictureBox pictureBox1;
        private Label lblClienteID;
        private TextBox txtClienteID;
        private ContextMenuStrip contextMenuStrip1;
    }
}