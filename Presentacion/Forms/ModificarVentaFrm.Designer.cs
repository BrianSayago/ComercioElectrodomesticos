namespace Presentacion.Forms
{
    partial class ModificarVentaFrm
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
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            cmbClientes = new ComboBox();
            txtTotal = new TextBox();
            dtpFecha = new DateTimePicker();
            txtVentaID = new TextBox();
            btnGuardarVenta = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label7 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            SuspendLayout();
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // cmbClientes
            // 
            cmbClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(202, 190);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(206, 23);
            cmbClientes.TabIndex = 4;
            // 
            // txtTotal
            // 
            txtTotal.ContextMenuStrip = contextMenuStrip1;
            txtTotal.Location = new Point(202, 320);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(206, 23);
            txtTotal.TabIndex = 6;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(202, 260);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(241, 23);
            dtpFecha.TabIndex = 7;
            // 
            // txtVentaID
            // 
            txtVentaID.Location = new Point(202, 126);
            txtVentaID.Name = "txtVentaID";
            txtVentaID.ReadOnly = true;
            txtVentaID.Size = new Size(73, 23);
            txtVentaID.TabIndex = 8;
            // 
            // btnGuardarVenta
            // 
            btnGuardarVenta.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarVenta.ForeColor = Color.Black;
            btnGuardarVenta.Location = new Point(94, 461);
            btnGuardarVenta.Name = "btnGuardarVenta";
            btnGuardarVenta.Size = new Size(101, 47);
            btnGuardarVenta.TabIndex = 9;
            btnGuardarVenta.Text = "Guardar";
            btnGuardarVenta.UseVisualStyleBackColor = true;
            btnGuardarVenta.Click += btnGuardarVenta_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(360, 461);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(101, 47);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(85, 132);
            label1.Name = "label1";
            label1.Size = new Size(65, 19);
            label1.TabIndex = 11;
            label1.Text = "VentaID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(85, 192);
            label2.Name = "label2";
            label2.Size = new Size(60, 19);
            label2.TabIndex = 12;
            label2.Text = "Cliente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(85, 265);
            label3.Name = "label3";
            label3.Size = new Size(112, 19);
            label3.TabIndex = 13;
            label3.Text = "Fecha de venta:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(86, 326);
            label4.Name = "label4";
            label4.Size = new Size(47, 19);
            label4.TabIndex = 14;
            label4.Text = "Total:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.FlatStyle = FlatStyle.Popup;
            label7.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(181, 54);
            label7.Name = "label7";
            label7.Size = new Size(196, 27);
            label7.TabIndex = 54;
            label7.Text = "MODIFICAR VENTA";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // ModificarVentaFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 61, 116);
            BackgroundImage = Properties.Resources.informe_de_venta;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(554, 547);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardarVenta);
            Controls.Add(txtVentaID);
            Controls.Add(dtpFecha);
            Controls.Add(txtTotal);
            Controls.Add(cmbClientes);
            DoubleBuffered = true;
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "ModificarVentaFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modificar Venta";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private ComboBox cmbClientes;
        private TextBox txtTotal;
        private DateTimePicker dtpFecha;
        private TextBox txtVentaID;
        private Button btnGuardarVenta;
        private Button btnCancelar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label7;
        private ContextMenuStrip contextMenuStrip1;
    }
}