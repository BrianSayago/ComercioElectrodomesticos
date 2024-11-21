namespace Presentacion.Forms
{
    partial class AgregarCompraFrm
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
            label4 = new Label();
            label1 = new Label();
            cmbProveedores = new ComboBox();
            dgvProductos = new DataGridView();
            dgvCarrito = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            btnAgregarProducto = new Button();
            lblTotal = new Label();
            txtTotal = new TextBox();
            btnGuardarCompra = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(458, 23);
            label4.Name = "label4";
            label4.Size = new Size(175, 24);
            label4.TabIndex = 11;
            label4.Text = "NUEVA COMPRA";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(21, 72);
            label1.Name = "label1";
            label1.Size = new Size(168, 20);
            label1.TabIndex = 12;
            label1.Text = "Seleccionar proveedor:";
            // 
            // cmbProveedores
            // 
            cmbProveedores.Anchor = AnchorStyles.Top;
            cmbProveedores.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProveedores.FormattingEnabled = true;
            cmbProveedores.Location = new Point(195, 69);
            cmbProveedores.Name = "cmbProveedores";
            cmbProveedores.Size = new Size(206, 23);
            cmbProveedores.TabIndex = 13;
            // 
            // dgvProductos
            // 
            dgvProductos.Anchor = AnchorStyles.Top;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(21, 143);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.Size = new Size(500, 296);
            dgvProductos.TabIndex = 14;
            // 
            // dgvCarrito
            // 
            dgvCarrito.Anchor = AnchorStyles.Top;
            dgvCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrito.Location = new Point(541, 143);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.ReadOnly = true;
            dgvCarrito.RowHeadersVisible = false;
            dgvCarrito.Size = new Size(500, 296);
            dgvCarrito.TabIndex = 15;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold | FontStyle.Underline);
            label2.ForeColor = Color.White;
            label2.Location = new Point(236, 122);
            label2.Name = "label2";
            label2.Size = new Size(86, 18);
            label2.TabIndex = 16;
            label2.Text = "Productos";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold | FontStyle.Underline);
            label3.ForeColor = Color.White;
            label3.Location = new Point(763, 122);
            label3.Name = "label3";
            label3.Size = new Size(60, 18);
            label3.TabIndex = 17;
            label3.Text = "Carrito";
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Anchor = AnchorStyles.Top;
            btnAgregarProducto.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarProducto.Image = Properties.Resources.bienes__1_;
            btnAgregarProducto.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarProducto.Location = new Point(21, 457);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(227, 56);
            btnAgregarProducto.TabIndex = 18;
            btnAgregarProducto.Text = "Agregar al carrito";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Top;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(820, 459);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(51, 18);
            lblTotal.TabIndex = 19;
            lblTotal.Text = "Total:";
            // 
            // txtTotal
            // 
            txtTotal.Anchor = AnchorStyles.Top;
            txtTotal.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotal.Location = new Point(877, 457);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(164, 25);
            txtTotal.TabIndex = 20;
            // 
            // btnGuardarCompra
            // 
            btnGuardarCompra.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGuardarCompra.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnGuardarCompra.Location = new Point(931, 528);
            btnGuardarCompra.Name = "btnGuardarCompra";
            btnGuardarCompra.Size = new Size(110, 58);
            btnGuardarCompra.TabIndex = 21;
            btnGuardarCompra.Text = "Guardar compra";
            btnGuardarCompra.UseVisualStyleBackColor = true;
            btnGuardarCompra.Click += btnGuardarCompra_Click;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalir.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnSalir.Location = new Point(802, 528);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(110, 58);
            btnSalir.TabIndex = 22;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // AgregarCompraFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 61, 116);
            ClientSize = new Size(1059, 607);
            Controls.Add(btnSalir);
            Controls.Add(btnGuardarCompra);
            Controls.Add(txtTotal);
            Controls.Add(lblTotal);
            Controls.Add(btnAgregarProducto);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvCarrito);
            Controls.Add(dgvProductos);
            Controls.Add(cmbProveedores);
            Controls.Add(label1);
            Controls.Add(label4);
            Name = "AgregarCompraFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nueva Compra";
            Load += AgregarCompraFrm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label1;
        private ComboBox cmbProveedores;
        private DataGridView dgvProductos;
        private DataGridView dgvCarrito;
        private Label label2;
        private Label label3;
        private Button btnAgregarProducto;
        private Label lblTotal;
        private TextBox txtTotal;
        private Button btnGuardarCompra;
        private Button btnSalir;
    }
}