namespace Presentacion.Forms
{
    partial class AgregarProductoFrm
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
            txtNombreProducto = new TextBox();
            txtPrecioProducto = new TextBox();
            txtInfoProducto = new TextBox();
            txtStockProducto = new TextBox();
            lblNombreProducto = new Label();
            lblPrecioProducto = new Label();
            lblInfoProducto = new Label();
            lblStockProducto = new Label();
            btnCancelar = new Button();
            btnConfirmarProducto = new Button();
            pictureBox1 = new PictureBox();
            lblTitulo = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.BackColor = SystemColors.Window;
            txtNombreProducto.ContextMenuStrip = contextMenuStrip1;
            txtNombreProducto.Location = new Point(202, 125);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(172, 23);
            txtNombreProducto.TabIndex = 0;
            txtNombreProducto.KeyDown += txtNombreProducto_KeyDown;
            // 
            // txtPrecioProducto
            // 
            txtPrecioProducto.ContextMenuStrip = contextMenuStrip1;
            txtPrecioProducto.Location = new Point(202, 175);
            txtPrecioProducto.Name = "txtPrecioProducto";
            txtPrecioProducto.Size = new Size(172, 23);
            txtPrecioProducto.TabIndex = 1;
            txtPrecioProducto.KeyDown += txtPrecioProducto_KeyDown;
            // 
            // txtInfoProducto
            // 
            txtInfoProducto.ContextMenuStrip = contextMenuStrip1;
            txtInfoProducto.Location = new Point(202, 225);
            txtInfoProducto.Multiline = true;
            txtInfoProducto.Name = "txtInfoProducto";
            txtInfoProducto.Size = new Size(257, 83);
            txtInfoProducto.TabIndex = 2;
            txtInfoProducto.KeyDown += txtInfoProducto_KeyDown;
            // 
            // txtStockProducto
            // 
            txtStockProducto.ContextMenuStrip = contextMenuStrip1;
            txtStockProducto.Location = new Point(202, 328);
            txtStockProducto.Name = "txtStockProducto";
            txtStockProducto.Size = new Size(87, 23);
            txtStockProducto.TabIndex = 3;
            txtStockProducto.KeyDown += txtStockProducto_KeyDown;
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.BorderStyle = BorderStyle.Fixed3D;
            lblNombreProducto.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            lblNombreProducto.ForeColor = Color.White;
            lblNombreProducto.Location = new Point(100, 127);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(65, 19);
            lblNombreProducto.TabIndex = 4;
            lblNombreProducto.Text = "Nombre:";
            // 
            // lblPrecioProducto
            // 
            lblPrecioProducto.AutoSize = true;
            lblPrecioProducto.BorderStyle = BorderStyle.Fixed3D;
            lblPrecioProducto.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            lblPrecioProducto.ForeColor = Color.White;
            lblPrecioProducto.Location = new Point(104, 177);
            lblPrecioProducto.Name = "lblPrecioProducto";
            lblPrecioProducto.Size = new Size(55, 19);
            lblPrecioProducto.TabIndex = 5;
            lblPrecioProducto.Text = "Precio:";
            // 
            // lblInfoProducto
            // 
            lblInfoProducto.AutoSize = true;
            lblInfoProducto.BorderStyle = BorderStyle.Fixed3D;
            lblInfoProducto.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            lblInfoProducto.ForeColor = Color.White;
            lblInfoProducto.Location = new Point(100, 227);
            lblInfoProducto.Name = "lblInfoProducto";
            lblInfoProducto.Size = new Size(90, 19);
            lblInfoProducto.TabIndex = 6;
            lblInfoProducto.Text = "Descripcion:";
            // 
            // lblStockProducto
            // 
            lblStockProducto.AutoSize = true;
            lblStockProducto.BorderStyle = BorderStyle.Fixed3D;
            lblStockProducto.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            lblStockProducto.ForeColor = Color.White;
            lblStockProducto.Location = new Point(109, 330);
            lblStockProducto.Name = "lblStockProducto";
            lblStockProducto.Size = new Size(50, 19);
            lblStockProducto.TabIndex = 7;
            lblStockProducto.Text = "Stock:";
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(362, 426);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(97, 31);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnConfirmarProducto
            // 
            btnConfirmarProducto.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmarProducto.Location = new Point(84, 426);
            btnConfirmarProducto.Name = "btnConfirmarProducto";
            btnConfirmarProducto.Size = new Size(97, 31);
            btnConfirmarProducto.TabIndex = 10;
            btnConfirmarProducto.Text = "Confirmar";
            btnConfirmarProducto.UseVisualStyleBackColor = true;
            btnConfirmarProducto.Click += btnConfirmarProducto_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.nuevo_producto;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(542, 492);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BorderStyle = BorderStyle.Fixed3D;
            lblTitulo.ContextMenuStrip = contextMenuStrip1;
            lblTitulo.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(166, 44);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(226, 27);
            lblTitulo.TabIndex = 12;
            lblTitulo.Text = "AGREGAR PRODUCTO";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // AgregarProductoFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 61, 116);
            ClientSize = new Size(542, 492);
            Controls.Add(lblTitulo);
            Controls.Add(btnConfirmarProducto);
            Controls.Add(btnCancelar);
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
            Name = "AgregarProductoFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar producto";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreProducto;
        private TextBox txtPrecioProducto;
        private TextBox txtInfoProducto;
        private TextBox txtStockProducto;
        private Label lblNombreProducto;
        private Label lblPrecioProducto;
        private Label lblInfoProducto;
        private Label lblStockProducto;
        private Button btnCancelar;
        private Button btnConfirmarProducto;
        private PictureBox pictureBox1;
        private Label lblTitulo;
        private ContextMenuStrip contextMenuStrip1;
    }
}