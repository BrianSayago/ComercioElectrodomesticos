namespace Presentacion.Forms
{
    partial class AgregarProveedorFrm
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
            lblTitulo = new Label();
            lblTel = new Label();
            lblEmail = new Label();
            lblDireccion = new Label();
            lblApellidoCliente = new Label();
            lblNombreCliente = new Label();
            pictureBox1 = new PictureBox();
            btnConfirmarCliente = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            btnAgregarProveedor = new Button();
            btnCerrar = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            lblDescripcionProv = new Label();
            label12 = new Label();
            pictureBox3 = new PictureBox();
            txtEmailProveedor = new TextBox();
            txtTelProveedor = new TextBox();
            txtDireccionProv = new TextBox();
            txtNombreProveedor = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
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
            lblTitulo.TabIndex = 22;
            lblTitulo.Text = "AGREGAR CLIENTE";
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
            lblTel.TabIndex = 21;
            lblTel.Text = "Télefono:";
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
            lblEmail.TabIndex = 20;
            lblEmail.Text = "Email:";
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
            lblDireccion.TabIndex = 19;
            lblDireccion.Text = "Dirección:";
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
            lblApellidoCliente.TabIndex = 18;
            lblApellidoCliente.Text = "Apellido:";
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
            lblNombreCliente.TabIndex = 17;
            lblNombreCliente.Text = "Nombre:";
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
            pictureBox1.TabIndex = 23;
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
            btnConfirmarCliente.TabIndex = 25;
            btnConfirmarCliente.Text = "Confirmar";
            btnConfirmarCliente.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Gainsboro;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(361, 429);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(97, 31);
            btnCancelar.TabIndex = 27;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Yu Gothic", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(179, 50);
            label1.Name = "label1";
            label1.Size = new Size(165, 23);
            label1.TabIndex = 31;
            label1.Text = "AGREGAR CLIENTE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(121, 308);
            label2.Name = "label2";
            label2.Size = new Size(71, 19);
            label2.TabIndex = 30;
            label2.Text = "Télefono:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(121, 351);
            label3.Name = "label3";
            label3.Size = new Size(50, 19);
            label3.TabIndex = 29;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(121, 265);
            label4.Name = "label4";
            label4.Size = new Size(75, 19);
            label4.TabIndex = 28;
            label4.Text = "Dirección:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(121, 217);
            label5.Name = "label5";
            label5.Size = new Size(67, 19);
            label5.TabIndex = 26;
            label5.Text = "Apellido:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(121, 171);
            label6.Name = "label6";
            label6.Size = new Size(65, 19);
            label6.TabIndex = 24;
            label6.Text = "Nombre:";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.comentarios_de_los_clientes;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.ErrorImage = null;
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(511, 496);
            pictureBox2.TabIndex = 32;
            pictureBox2.TabStop = false;
            // 
            // btnAgregarProveedor
            // 
            btnAgregarProveedor.BackColor = Color.Gainsboro;
            btnAgregarProveedor.FlatStyle = FlatStyle.Popup;
            btnAgregarProveedor.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarProveedor.Location = new Point(89, 429);
            btnAgregarProveedor.Name = "btnAgregarProveedor";
            btnAgregarProveedor.Size = new Size(97, 31);
            btnAgregarProveedor.TabIndex = 34;
            btnAgregarProveedor.Text = "Confirmar";
            btnAgregarProveedor.UseVisualStyleBackColor = false;
            btnAgregarProveedor.Click += btnAgregarProveedor_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Gainsboro;
            btnCerrar.FlatStyle = FlatStyle.Popup;
            btnCerrar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.Location = new Point(361, 429);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(97, 31);
            btnCerrar.TabIndex = 36;
            btnCerrar.Text = "Cancelar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.FlatStyle = FlatStyle.Popup;
            label7.Font = new Font("Yu Gothic", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(149, 61);
            label7.Name = "label7";
            label7.Size = new Size(195, 23);
            label7.TabIndex = 40;
            label7.Text = "AGREGAR PROVEEDOR";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(98, 292);
            label8.Name = "label8";
            label8.Size = new Size(71, 19);
            label8.TabIndex = 39;
            label8.Text = "Télefono:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BorderStyle = BorderStyle.Fixed3D;
            label9.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(98, 340);
            label9.Name = "label9";
            label9.Size = new Size(50, 19);
            label9.TabIndex = 38;
            label9.Text = "Email:";
            // 
            // lblDescripcionProv
            // 
            lblDescripcionProv.AutoSize = true;
            lblDescripcionProv.BorderStyle = BorderStyle.Fixed3D;
            lblDescripcionProv.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            lblDescripcionProv.ForeColor = Color.White;
            lblDescripcionProv.Location = new Point(98, 191);
            lblDescripcionProv.Name = "lblDescripcionProv";
            lblDescripcionProv.Size = new Size(75, 19);
            lblDescripcionProv.TabIndex = 37;
            lblDescripcionProv.Text = "Dirección:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BorderStyle = BorderStyle.Fixed3D;
            label12.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(98, 143);
            label12.Name = "label12";
            label12.Size = new Size(65, 19);
            label12.TabIndex = 33;
            label12.Text = "Nombre:";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.proveedor__2_;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.ErrorImage = null;
            pictureBox3.InitialImage = null;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(511, 496);
            pictureBox3.TabIndex = 41;
            pictureBox3.TabStop = false;
            // 
            // txtEmailProveedor
            // 
            txtEmailProveedor.ContextMenuStrip = contextMenuStrip1;
            txtEmailProveedor.Location = new Point(204, 340);
            txtEmailProveedor.Name = "txtEmailProveedor";
            txtEmailProveedor.Size = new Size(172, 23);
            txtEmailProveedor.TabIndex = 46;
            txtEmailProveedor.KeyDown += txtEmailProveedor_KeyDown;
            // 
            // txtTelProveedor
            // 
            txtTelProveedor.ContextMenuStrip = contextMenuStrip1;
            txtTelProveedor.Location = new Point(207, 290);
            txtTelProveedor.Name = "txtTelProveedor";
            txtTelProveedor.Size = new Size(169, 23);
            txtTelProveedor.TabIndex = 45;
            txtTelProveedor.KeyDown += txtTelProveedor_KeyDown;
            // 
            // txtDireccionProv
            // 
            txtDireccionProv.ContextMenuStrip = contextMenuStrip1;
            txtDireccionProv.Location = new Point(204, 189);
            txtDireccionProv.Multiline = true;
            txtDireccionProv.Name = "txtDireccionProv";
            txtDireccionProv.Size = new Size(172, 77);
            txtDireccionProv.TabIndex = 44;
            txtDireccionProv.KeyDown += txtDireccionProv_KeyDown;
            // 
            // txtNombreProveedor
            // 
            txtNombreProveedor.ContextMenuStrip = contextMenuStrip1;
            txtNombreProveedor.Location = new Point(204, 141);
            txtNombreProveedor.Name = "txtNombreProveedor";
            txtNombreProveedor.Size = new Size(172, 23);
            txtNombreProveedor.TabIndex = 42;
            txtNombreProveedor.KeyDown += txtNombreProveedor_KeyDown;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // AgregarProveedorFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 61, 116);
            BackgroundImage = Properties.Resources.proveedor__2_;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(511, 496);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(txtEmailProveedor);
            Controls.Add(txtTelProveedor);
            Controls.Add(txtDireccionProv);
            Controls.Add(txtNombreProveedor);
            Controls.Add(btnAgregarProveedor);
            Controls.Add(btnCerrar);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(lblDescripcionProv);
            Controls.Add(label12);
            Controls.Add(pictureBox3);
            Controls.Add(btnConfirmarCliente);
            Controls.Add(btnCancelar);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(pictureBox2);
            Controls.Add(lblTitulo);
            Controls.Add(lblTel);
            Controls.Add(lblEmail);
            Controls.Add(lblDireccion);
            Controls.Add(lblApellidoCliente);
            Controls.Add(lblNombreCliente);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "AgregarProveedorFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo Proveedor";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblTel;
        private Label lblEmail;
        private Label lblDireccion;
        private Label lblApellidoCliente;
        private Label lblNombreCliente;
        private PictureBox pictureBox1;
        private Button btnConfirmarCliente;
        private Button btnCancelar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox2;
        private Button btnAgregarProveedor;
        private Button btnCerrar;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label lblDescripcionProv;
        private Label label12;
        private PictureBox pictureBox3;
        private TextBox txtEmailProveedor;
        private TextBox txtTelProveedor;
        private TextBox txtDireccionProv;
        private TextBox txtNombreProveedor;
        private ContextMenuStrip contextMenuStrip1;
    }
}