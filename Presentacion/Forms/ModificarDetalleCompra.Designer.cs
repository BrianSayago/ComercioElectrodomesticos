namespace Presentacion.Forms
{
    partial class ModificarDetalleCompra
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
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtDetalleCompra = new TextBox();
            cmbProductos = new ComboBox();
            txtCantidadCompra = new TextBox();
            txtPrecioUnitario = new TextBox();
            txtSubtotal = new TextBox();
            btnGuardarDetalleVenta = new Button();
            btnCancelar = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.FlatStyle = FlatStyle.Popup;
            label7.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(116, 48);
            label7.Name = "label7";
            label7.Size = new Size(339, 27);
            label7.TabIndex = 56;
            label7.Text = "MODIFICAR COMPRA DETALLADA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(94, 340);
            label5.Name = "label5";
            label5.Size = new Size(69, 19);
            label5.TabIndex = 61;
            label5.Text = "Subtotal:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(94, 296);
            label4.Name = "label4";
            label4.Size = new Size(109, 19);
            label4.TabIndex = 60;
            label4.Text = "Precio unitario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(94, 256);
            label3.Name = "label3";
            label3.Size = new Size(72, 19);
            label3.TabIndex = 59;
            label3.Text = "Cantidad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(94, 209);
            label2.Name = "label2";
            label2.Size = new Size(79, 19);
            label2.TabIndex = 58;
            label2.Text = "Productos:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(94, 161);
            label1.Name = "label1";
            label1.Size = new Size(125, 19);
            label1.TabIndex = 57;
            label1.Text = "DetalleCompraID:";
            // 
            // txtDetalleCompra
            // 
            txtDetalleCompra.Location = new Point(238, 155);
            txtDetalleCompra.Name = "txtDetalleCompra";
            txtDetalleCompra.ReadOnly = true;
            txtDetalleCompra.Size = new Size(178, 23);
            txtDetalleCompra.TabIndex = 62;
            // 
            // cmbProductos
            // 
            cmbProductos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProductos.FormattingEnabled = true;
            cmbProductos.Location = new Point(238, 203);
            cmbProductos.Name = "cmbProductos";
            cmbProductos.Size = new Size(178, 23);
            cmbProductos.TabIndex = 63;
            // 
            // txtCantidadCompra
            // 
            txtCantidadCompra.ContextMenuStrip = contextMenuStrip1;
            txtCantidadCompra.Location = new Point(238, 250);
            txtCantidadCompra.Name = "txtCantidadCompra";
            txtCantidadCompra.Size = new Size(178, 23);
            txtCantidadCompra.TabIndex = 64;
            // 
            // txtPrecioUnitario
            // 
            txtPrecioUnitario.ContextMenuStrip = contextMenuStrip1;
            txtPrecioUnitario.Location = new Point(238, 290);
            txtPrecioUnitario.Name = "txtPrecioUnitario";
            txtPrecioUnitario.Size = new Size(178, 23);
            txtPrecioUnitario.TabIndex = 65;
            // 
            // txtSubtotal
            // 
            txtSubtotal.ContextMenuStrip = contextMenuStrip1;
            txtSubtotal.Location = new Point(238, 334);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(178, 23);
            txtSubtotal.TabIndex = 66;
            // 
            // btnGuardarDetalleVenta
            // 
            btnGuardarDetalleVenta.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnGuardarDetalleVenta.Location = new Point(63, 448);
            btnGuardarDetalleVenta.Name = "btnGuardarDetalleVenta";
            btnGuardarDetalleVenta.Size = new Size(101, 47);
            btnGuardarDetalleVenta.TabIndex = 67;
            btnGuardarDetalleVenta.Text = "Guardar";
            btnGuardarDetalleVenta.UseVisualStyleBackColor = true;
            btnGuardarDetalleVenta.Click += btnGuardarDetalleCompra_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnCancelar.Location = new Point(396, 448);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(101, 47);
            btnCancelar.TabIndex = 68;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // ModificarDetalleCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 61, 116);
            BackgroundImage = Properties.Resources.carrito_de_compras__1_;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(562, 555);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardarDetalleVenta);
            Controls.Add(txtSubtotal);
            Controls.Add(txtPrecioUnitario);
            Controls.Add(txtCantidadCompra);
            Controls.Add(cmbProductos);
            Controls.Add(txtDetalleCompra);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label7);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "ModificarDetalleCompra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ModificarDetalleCompra";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtDetalleCompra;
        private ComboBox cmbProductos;
        private TextBox txtCantidadCompra;
        private TextBox txtPrecioUnitario;
        private TextBox txtSubtotal;
        private Button btnGuardarDetalleVenta;
        private Button btnCancelar;
        private ContextMenuStrip contextMenuStrip1;
    }
}