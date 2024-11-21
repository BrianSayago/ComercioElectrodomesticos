namespace Presentacion.Forms
{
    partial class AgregarVentaFrm
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
            dgvProductos = new DataGridView();
            dgvCarrito = new DataGridView();
            txtTotal = new TextBox();
            cmbClientes = new ComboBox();
            btnAgregarProducto = new Button();
            btnGuardarVenta = new Button();
            lblTotal = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            SuspendLayout();
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
            dgvProductos.TabIndex = 0;
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
            dgvCarrito.TabIndex = 1;
            // 
            // txtTotal
            // 
            txtTotal.Anchor = AnchorStyles.Top;
            txtTotal.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotal.Location = new Point(877, 455);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(164, 25);
            txtTotal.TabIndex = 2;
            // 
            // cmbClientes
            // 
            cmbClientes.Anchor = AnchorStyles.Top;
            cmbClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(167, 65);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(206, 23);
            cmbClientes.TabIndex = 3;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Anchor = AnchorStyles.Top;
            btnAgregarProducto.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarProducto.Image = Properties.Resources.bienes__1_;
            btnAgregarProducto.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarProducto.Location = new Point(21, 462);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(227, 56);
            btnAgregarProducto.TabIndex = 4;
            btnAgregarProducto.Text = "Agregar al carrito";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // btnGuardarVenta
            // 
            btnGuardarVenta.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGuardarVenta.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnGuardarVenta.Location = new Point(931, 537);
            btnGuardarVenta.Name = "btnGuardarVenta";
            btnGuardarVenta.Size = new Size(110, 58);
            btnGuardarVenta.TabIndex = 5;
            btnGuardarVenta.Text = "Guardar venta";
            btnGuardarVenta.UseVisualStyleBackColor = true;
            btnGuardarVenta.Click += btnGuardarVenta_Click;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Top;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(820, 462);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(51, 18);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "Total:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(21, 68);
            label1.Name = "label1";
            label1.Size = new Size(140, 20);
            label1.TabIndex = 7;
            label1.Text = "Seleccionar cliente:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold | FontStyle.Underline);
            label2.ForeColor = Color.White;
            label2.Location = new Point(236, 120);
            label2.Name = "label2";
            label2.Size = new Size(86, 18);
            label2.TabIndex = 8;
            label2.Text = "Productos";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold | FontStyle.Underline);
            label3.ForeColor = Color.White;
            label3.Location = new Point(757, 120);
            label3.Name = "label3";
            label3.Size = new Size(60, 18);
            label3.TabIndex = 9;
            label3.Text = "Carrito";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(452, 19);
            label4.Name = "label4";
            label4.Size = new Size(157, 24);
            label4.TabIndex = 10;
            label4.Text = "NUEVA VENTA";
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalir.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnSalir.Location = new Point(801, 537);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(110, 58);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // AgregarVentaFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 61, 116);
            ClientSize = new Size(1059, 607);
            Controls.Add(btnSalir);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTotal);
            Controls.Add(btnGuardarVenta);
            Controls.Add(btnAgregarProducto);
            Controls.Add(cmbClientes);
            Controls.Add(txtTotal);
            Controls.Add(dgvCarrito);
            Controls.Add(dgvProductos);
            Name = "AgregarVentaFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nueva Venta";
            Load += AgregarVentaFrm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductos;
        private DataGridView dgvCarrito;
        private TextBox txtTotal;
        private ComboBox cmbClientes;
        private Button btnAgregarProducto;
        private Button btnGuardarVenta;
        private Label lblTotal;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnSalir;
    }
}