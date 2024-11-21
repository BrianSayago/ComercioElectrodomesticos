namespace Presentacion.Forms
{
    partial class ModificarProductoFrm
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
            lblStockProducto = new Label();
            lblInfoProducto = new Label();
            lblPrecioProducto = new Label();
            lblNombreProducto = new Label();
            txtStockProducto = new TextBox();
            txtInfoProducto = new TextBox();
            txtPrecioProducto = new TextBox();
            txtNombreProducto = new TextBox();
            btnGuardarProducto = new Button();
            btnCancelar = new Button();
            txtProductoID = new TextBox();
            lblProductoID = new Label();
            pictureBox1 = new PictureBox();
            lblTitulo = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblStockProducto
            // 
            lblStockProducto.AutoSize = true;
            lblStockProducto.BorderStyle = BorderStyle.Fixed3D;
            lblStockProducto.FlatStyle = FlatStyle.Flat;
            lblStockProducto.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            lblStockProducto.ForeColor = Color.White;
            lblStockProducto.Location = new Point(88, 400);
            lblStockProducto.Name = "lblStockProducto";
            lblStockProducto.Size = new Size(50, 19);
            lblStockProducto.TabIndex = 19;
            lblStockProducto.Text = "Stock:";
            // 
            // lblInfoProducto
            // 
            lblInfoProducto.AutoSize = true;
            lblInfoProducto.BorderStyle = BorderStyle.Fixed3D;
            lblInfoProducto.FlatStyle = FlatStyle.Flat;
            lblInfoProducto.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            lblInfoProducto.ForeColor = Color.White;
            lblInfoProducto.Location = new Point(84, 292);
            lblInfoProducto.Name = "lblInfoProducto";
            lblInfoProducto.Size = new Size(90, 19);
            lblInfoProducto.TabIndex = 18;
            lblInfoProducto.Text = "Descripcion:";
            // 
            // lblPrecioProducto
            // 
            lblPrecioProducto.AutoSize = true;
            lblPrecioProducto.BorderStyle = BorderStyle.Fixed3D;
            lblPrecioProducto.FlatStyle = FlatStyle.Flat;
            lblPrecioProducto.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            lblPrecioProducto.ForeColor = Color.White;
            lblPrecioProducto.Location = new Point(84, 247);
            lblPrecioProducto.Name = "lblPrecioProducto";
            lblPrecioProducto.Size = new Size(55, 19);
            lblPrecioProducto.TabIndex = 17;
            lblPrecioProducto.Text = "Precio:";
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.BorderStyle = BorderStyle.Fixed3D;
            lblNombreProducto.FlatStyle = FlatStyle.Flat;
            lblNombreProducto.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            lblNombreProducto.ForeColor = Color.White;
            lblNombreProducto.Location = new Point(84, 197);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(65, 19);
            lblNombreProducto.TabIndex = 16;
            lblNombreProducto.Text = "Nombre:";
            // 
            // txtStockProducto
            // 
            txtStockProducto.ContextMenuStrip = contextMenuStrip1;
            txtStockProducto.Location = new Point(178, 393);
            txtStockProducto.Name = "txtStockProducto";
            txtStockProducto.Size = new Size(100, 23);
            txtStockProducto.TabIndex = 15;
            // 
            // txtInfoProducto
            // 
            txtInfoProducto.ContextMenuStrip = contextMenuStrip1;
            txtInfoProducto.Location = new Point(178, 290);
            txtInfoProducto.Multiline = true;
            txtInfoProducto.Name = "txtInfoProducto";
            txtInfoProducto.Size = new Size(268, 83);
            txtInfoProducto.TabIndex = 14;
            // 
            // txtPrecioProducto
            // 
            txtPrecioProducto.ContextMenuStrip = contextMenuStrip1;
            txtPrecioProducto.Location = new Point(178, 240);
            txtPrecioProducto.Name = "txtPrecioProducto";
            txtPrecioProducto.Size = new Size(172, 23);
            txtPrecioProducto.TabIndex = 13;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.ContextMenuStrip = contextMenuStrip1;
            txtNombreProducto.Location = new Point(178, 190);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(172, 23);
            txtNombreProducto.TabIndex = 12;
            // 
            // btnGuardarProducto
            // 
            btnGuardarProducto.Font = new Font("Segoe UI", 11.25F);
            btnGuardarProducto.Location = new Point(84, 488);
            btnGuardarProducto.Name = "btnGuardarProducto";
            btnGuardarProducto.Size = new Size(97, 31);
            btnGuardarProducto.TabIndex = 21;
            btnGuardarProducto.Text = "Guardar";
            btnGuardarProducto.UseVisualStyleBackColor = true;
            btnGuardarProducto.Click += btnGuardarProducto_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 11.25F);
            btnCancelar.Location = new Point(370, 488);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(97, 31);
            btnCancelar.TabIndex = 22;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtProductoID
            // 
            txtProductoID.Location = new Point(178, 151);
            txtProductoID.Name = "txtProductoID";
            txtProductoID.ReadOnly = true;
            txtProductoID.Size = new Size(60, 23);
            txtProductoID.TabIndex = 23;
            // 
            // lblProductoID
            // 
            lblProductoID.AutoSize = true;
            lblProductoID.BorderStyle = BorderStyle.Fixed3D;
            lblProductoID.FlatStyle = FlatStyle.Flat;
            lblProductoID.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            lblProductoID.ForeColor = Color.White;
            lblProductoID.Location = new Point(88, 153);
            lblProductoID.Name = "lblProductoID";
            lblProductoID.Size = new Size(28, 19);
            lblProductoID.TabIndex = 24;
            lblProductoID.Text = "ID:";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.cadena_de_suministro;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(543, 551);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BorderStyle = BorderStyle.Fixed3D;
            lblTitulo.FlatStyle = FlatStyle.Flat;
            lblTitulo.Font = new Font("Yu Gothic", 12F, FontStyle.Bold | FontStyle.Underline);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(163, 55);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(201, 23);
            lblTitulo.TabIndex = 26;
            lblTitulo.Text = "MODIFICAR PRODUCTO";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // ModificarProductoFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 61, 116);
            ClientSize = new Size(543, 551);
            Controls.Add(lblTitulo);
            Controls.Add(lblProductoID);
            Controls.Add(txtProductoID);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardarProducto);
            Controls.Add(lblStockProducto);
            Controls.Add(lblInfoProducto);
            Controls.Add(lblPrecioProducto);
            Controls.Add(lblNombreProducto);
            Controls.Add(txtStockProducto);
            Controls.Add(txtInfoProducto);
            Controls.Add(txtPrecioProducto);
            Controls.Add(txtNombreProducto);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "ModificarProductoFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ModificarProducto";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblStockProducto;
        private Label lblInfoProducto;
        private Label lblPrecioProducto;
        private Label lblNombreProducto;
        private TextBox txtStockProducto;
        private TextBox txtInfoProducto;
        private TextBox txtPrecioProducto;
        private TextBox txtNombreProducto;
        private Button btnGuardarProducto;
        private Button btnCancelar;
        private TextBox txtProductoID;
        private Label lblProductoID;
        private PictureBox pictureBox1;
        private Label lblTitulo;
        private ContextMenuStrip contextMenuStrip1;
    }
}