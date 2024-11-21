namespace Presentacion.Forms
{
    partial class ModificarDetalleVentaFrm
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
            txtCantidadVenta = new TextBox();
            txtPrecioUnitario = new TextBox();
            txtSubtotal = new TextBox();
            txtDetalleVenta = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnGuardarDetalleVenta = new Button();
            btnCancelar = new Button();
            cmbProductos = new ComboBox();
            label7 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            SuspendLayout();
            // 
            // txtCantidadVenta
            // 
            txtCantidadVenta.ContextMenuStrip = contextMenuStrip1;
            txtCantidadVenta.Location = new Point(230, 279);
            txtCantidadVenta.Name = "txtCantidadVenta";
            txtCantidadVenta.Size = new Size(178, 23);
            txtCantidadVenta.TabIndex = 1;
            // 
            // txtPrecioUnitario
            // 
            txtPrecioUnitario.ContextMenuStrip = contextMenuStrip1;
            txtPrecioUnitario.Location = new Point(230, 319);
            txtPrecioUnitario.Name = "txtPrecioUnitario";
            txtPrecioUnitario.Size = new Size(178, 23);
            txtPrecioUnitario.TabIndex = 2;
            // 
            // txtSubtotal
            // 
            txtSubtotal.ContextMenuStrip = contextMenuStrip1;
            txtSubtotal.Location = new Point(230, 367);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(178, 23);
            txtSubtotal.TabIndex = 3;
            // 
            // txtDetalleVenta
            // 
            txtDetalleVenta.Location = new Point(230, 184);
            txtDetalleVenta.Name = "txtDetalleVenta";
            txtDetalleVenta.ReadOnly = true;
            txtDetalleVenta.Size = new Size(178, 23);
            txtDetalleVenta.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(114, 190);
            label1.Name = "label1";
            label1.Size = new Size(112, 19);
            label1.TabIndex = 5;
            label1.Text = "DetalleVentaID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(114, 238);
            label2.Name = "label2";
            label2.Size = new Size(79, 19);
            label2.TabIndex = 6;
            label2.Text = "Productos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(114, 285);
            label3.Name = "label3";
            label3.Size = new Size(72, 19);
            label3.TabIndex = 7;
            label3.Text = "Cantidad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(114, 325);
            label4.Name = "label4";
            label4.Size = new Size(109, 19);
            label4.TabIndex = 8;
            label4.Text = "Precio unitario:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(114, 369);
            label5.Name = "label5";
            label5.Size = new Size(69, 19);
            label5.TabIndex = 9;
            label5.Text = "Subtotal:";
            // 
            // btnGuardarDetalleVenta
            // 
            btnGuardarDetalleVenta.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnGuardarDetalleVenta.Location = new Point(83, 477);
            btnGuardarDetalleVenta.Name = "btnGuardarDetalleVenta";
            btnGuardarDetalleVenta.Size = new Size(101, 47);
            btnGuardarDetalleVenta.TabIndex = 10;
            btnGuardarDetalleVenta.Text = "Guardar";
            btnGuardarDetalleVenta.UseVisualStyleBackColor = true;
            btnGuardarDetalleVenta.Click += btnGuardarDetalleVenta_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnCancelar.Location = new Point(384, 477);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(101, 47);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cmbProductos
            // 
            cmbProductos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProductos.FormattingEnabled = true;
            cmbProductos.Location = new Point(230, 232);
            cmbProductos.Name = "cmbProductos";
            cmbProductos.Size = new Size(178, 23);
            cmbProductos.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.FlatStyle = FlatStyle.Popup;
            label7.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(142, 64);
            label7.Name = "label7";
            label7.Size = new Size(318, 27);
            label7.TabIndex = 55;
            label7.Text = "MODIFICAR VENTA DETALLADA";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // ModificarDetalleVentaFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 61, 116);
            BackgroundImage = Properties.Resources.informe_de_venta;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(558, 551);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(label7);
            Controls.Add(cmbProductos);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardarDetalleVenta);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDetalleVenta);
            Controls.Add(txtSubtotal);
            Controls.Add(txtPrecioUnitario);
            Controls.Add(txtCantidadVenta);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "ModificarDetalleVentaFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modificar Venta Detallada";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtCantidadVenta;
        private TextBox txtPrecioUnitario;
        private TextBox txtSubtotal;
        private TextBox txtDetalleVenta;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnGuardarDetalleVenta;
        private Button btnCancelar;
        private ComboBox cmbProductos;
        private Label label7;
        private ContextMenuStrip contextMenuStrip1;
    }
}