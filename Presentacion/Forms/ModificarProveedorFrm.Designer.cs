namespace Presentacion.Forms
{
    partial class ModificarProveedorFrm
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
            txtEmailProveedor = new TextBox();
            txtTelProveedor = new TextBox();
            txtDireccionProv = new TextBox();
            txtNombreProveedor = new TextBox();
            btnGuardarProveedor = new Button();
            btnCerrar = new Button();
            label7 = new Label();
            lvlTelProveedor = new Label();
            lblEmailProveedor = new Label();
            lblDireccionProv = new Label();
            lblNombreProveedor = new Label();
            pictureBox3 = new PictureBox();
            lblProovedorID = new Label();
            txtProovedorID = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // txtEmailProveedor
            // 
            txtEmailProveedor.ContextMenuStrip = contextMenuStrip1;
            txtEmailProveedor.Location = new Point(202, 347);
            txtEmailProveedor.Name = "txtEmailProveedor";
            txtEmailProveedor.Size = new Size(172, 23);
            txtEmailProveedor.TabIndex = 58;
            // 
            // txtTelProveedor
            // 
            txtTelProveedor.ContextMenuStrip = contextMenuStrip1;
            txtTelProveedor.Location = new Point(205, 297);
            txtTelProveedor.Name = "txtTelProveedor";
            txtTelProveedor.Size = new Size(169, 23);
            txtTelProveedor.TabIndex = 57;
            // 
            // txtDireccionProv
            // 
            txtDireccionProv.ContextMenuStrip = contextMenuStrip1;
            txtDireccionProv.Location = new Point(202, 196);
            txtDireccionProv.Multiline = true;
            txtDireccionProv.Name = "txtDireccionProv";
            txtDireccionProv.Size = new Size(172, 77);
            txtDireccionProv.TabIndex = 56;
            // 
            // txtNombreProveedor
            // 
            txtNombreProveedor.ContextMenuStrip = contextMenuStrip1;
            txtNombreProveedor.Location = new Point(202, 148);
            txtNombreProveedor.Name = "txtNombreProveedor";
            txtNombreProveedor.Size = new Size(172, 23);
            txtNombreProveedor.TabIndex = 55;
            // 
            // btnGuardarProveedor
            // 
            btnGuardarProveedor.BackColor = Color.Gainsboro;
            btnGuardarProveedor.FlatStyle = FlatStyle.Popup;
            btnGuardarProveedor.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarProveedor.Location = new Point(89, 429);
            btnGuardarProveedor.Name = "btnGuardarProveedor";
            btnGuardarProveedor.Size = new Size(97, 31);
            btnGuardarProveedor.TabIndex = 48;
            btnGuardarProveedor.Text = "Confirmar";
            btnGuardarProveedor.UseVisualStyleBackColor = false;
            btnGuardarProveedor.Click += btnGuardarProveedor_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Gainsboro;
            btnCerrar.FlatStyle = FlatStyle.Popup;
            btnCerrar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.Location = new Point(361, 429);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(97, 31);
            btnCerrar.TabIndex = 49;
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
            label7.Location = new Point(149, 54);
            label7.Name = "label7";
            label7.Size = new Size(209, 23);
            label7.TabIndex = 53;
            label7.Text = "MODIFICAR PROVEEDOR";
            // 
            // lvlTelProveedor
            // 
            lvlTelProveedor.AutoSize = true;
            lvlTelProveedor.BorderStyle = BorderStyle.FixedSingle;
            lvlTelProveedor.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            lvlTelProveedor.ForeColor = Color.White;
            lvlTelProveedor.Location = new Point(96, 299);
            lvlTelProveedor.Name = "lvlTelProveedor";
            lvlTelProveedor.Size = new Size(71, 19);
            lvlTelProveedor.TabIndex = 52;
            lvlTelProveedor.Text = "Télefono:";
            // 
            // lblEmailProveedor
            // 
            lblEmailProveedor.AutoSize = true;
            lblEmailProveedor.BorderStyle = BorderStyle.Fixed3D;
            lblEmailProveedor.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            lblEmailProveedor.ForeColor = Color.White;
            lblEmailProveedor.Location = new Point(96, 347);
            lblEmailProveedor.Name = "lblEmailProveedor";
            lblEmailProveedor.Size = new Size(50, 19);
            lblEmailProveedor.TabIndex = 51;
            lblEmailProveedor.Text = "Email:";
            // 
            // lblDireccionProv
            // 
            lblDireccionProv.AutoSize = true;
            lblDireccionProv.BorderStyle = BorderStyle.Fixed3D;
            lblDireccionProv.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            lblDireccionProv.ForeColor = Color.White;
            lblDireccionProv.Location = new Point(96, 198);
            lblDireccionProv.Name = "lblDireccionProv";
            lblDireccionProv.Size = new Size(75, 19);
            lblDireccionProv.TabIndex = 50;
            lblDireccionProv.Text = "Dirección:";
            // 
            // lblNombreProveedor
            // 
            lblNombreProveedor.AutoSize = true;
            lblNombreProveedor.BorderStyle = BorderStyle.Fixed3D;
            lblNombreProveedor.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreProveedor.ForeColor = Color.White;
            lblNombreProveedor.Location = new Point(96, 150);
            lblNombreProveedor.Name = "lblNombreProveedor";
            lblNombreProveedor.Size = new Size(65, 19);
            lblNombreProveedor.TabIndex = 47;
            lblNombreProveedor.Text = "Nombre:";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.proveedor__2_;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.ContextMenuStrip = contextMenuStrip1;
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.ErrorImage = null;
            pictureBox3.InitialImage = null;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(511, 496);
            pictureBox3.TabIndex = 54;
            pictureBox3.TabStop = false;
            // 
            // lblProovedorID
            // 
            lblProovedorID.AutoSize = true;
            lblProovedorID.BorderStyle = BorderStyle.Fixed3D;
            lblProovedorID.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProovedorID.ForeColor = Color.White;
            lblProovedorID.Location = new Point(96, 109);
            lblProovedorID.Name = "lblProovedorID";
            lblProovedorID.Size = new Size(98, 19);
            lblProovedorID.TabIndex = 59;
            lblProovedorID.Text = "Proovedor ID:";
            // 
            // txtProovedorID
            // 
            txtProovedorID.Location = new Point(202, 105);
            txtProovedorID.Name = "txtProovedorID";
            txtProovedorID.ReadOnly = true;
            txtProovedorID.Size = new Size(69, 23);
            txtProovedorID.TabIndex = 60;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // ModificarProveedorFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 61, 116);
            ClientSize = new Size(511, 496);
            Controls.Add(txtProovedorID);
            Controls.Add(lblProovedorID);
            Controls.Add(txtEmailProveedor);
            Controls.Add(txtTelProveedor);
            Controls.Add(txtDireccionProv);
            Controls.Add(txtNombreProveedor);
            Controls.Add(btnGuardarProveedor);
            Controls.Add(btnCerrar);
            Controls.Add(label7);
            Controls.Add(lvlTelProveedor);
            Controls.Add(lblEmailProveedor);
            Controls.Add(lblDireccionProv);
            Controls.Add(lblNombreProveedor);
            Controls.Add(pictureBox3);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "ModificarProveedorFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modificar Proveedor";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmailProveedor;
        private TextBox txtTelProveedor;
        private TextBox txtDireccionProv;
        private TextBox txtNombreProveedor;
        private Button btnGuardarProveedor;
        private Button btnCerrar;
        private Label label7;
        private Label lvlTelProveedor;
        private Label lblEmailProveedor;
        private Label lblDireccionProv;
        private Label lblNombreProveedor;
        private PictureBox pictureBox3;
        private Label lblProovedorID;
        private TextBox txtProovedorID;
        private ContextMenuStrip contextMenuStrip1;
    }
}