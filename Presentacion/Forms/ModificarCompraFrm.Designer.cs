namespace Presentacion.Forms
{
    partial class ModificarCompraFrm
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
            lblCompraID = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtCompraID = new TextBox();
            cmbProveedores = new ComboBox();
            dtpFecha = new DateTimePicker();
            txtTotal = new TextBox();
            btnGuardarCompra = new Button();
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
            label7.Location = new Point(196, 32);
            label7.Name = "label7";
            label7.Size = new Size(217, 27);
            label7.TabIndex = 55;
            label7.Text = "MODIFICAR COMPRA";
            // 
            // lblCompraID
            // 
            lblCompraID.AutoSize = true;
            lblCompraID.BorderStyle = BorderStyle.Fixed3D;
            lblCompraID.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCompraID.ForeColor = Color.White;
            lblCompraID.Location = new Point(93, 169);
            lblCompraID.Name = "lblCompraID";
            lblCompraID.Size = new Size(78, 19);
            lblCompraID.TabIndex = 56;
            lblCompraID.Text = "CompraID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(93, 213);
            label2.Name = "label2";
            label2.Size = new Size(80, 19);
            label2.TabIndex = 57;
            label2.Text = "Proveedor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(93, 264);
            label3.Name = "label3";
            label3.Size = new Size(124, 19);
            label3.TabIndex = 58;
            label3.Text = "Fecha de compra:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(93, 330);
            label4.Name = "label4";
            label4.Size = new Size(47, 19);
            label4.TabIndex = 59;
            label4.Text = "Total:";
            // 
            // txtCompraID
            // 
            txtCompraID.Location = new Point(231, 167);
            txtCompraID.Name = "txtCompraID";
            txtCompraID.ReadOnly = true;
            txtCompraID.Size = new Size(73, 23);
            txtCompraID.TabIndex = 60;
            // 
            // cmbProveedores
            // 
            cmbProveedores.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProveedores.FormattingEnabled = true;
            cmbProveedores.Location = new Point(231, 211);
            cmbProveedores.Name = "cmbProveedores";
            cmbProveedores.Size = new Size(206, 23);
            cmbProveedores.TabIndex = 61;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(231, 264);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(241, 23);
            dtpFecha.TabIndex = 62;
            // 
            // txtTotal
            // 
            txtTotal.ContextMenuStrip = contextMenuStrip1;
            txtTotal.Location = new Point(231, 328);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(206, 23);
            txtTotal.TabIndex = 63;
            // 
            // btnGuardarCompra
            // 
            btnGuardarCompra.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarCompra.ForeColor = Color.Black;
            btnGuardarCompra.Location = new Point(52, 467);
            btnGuardarCompra.Name = "btnGuardarCompra";
            btnGuardarCompra.Size = new Size(101, 47);
            btnGuardarCompra.TabIndex = 64;
            btnGuardarCompra.Text = "Guardar";
            btnGuardarCompra.UseVisualStyleBackColor = true;
            btnGuardarCompra.Click += btnGuardarCompra_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(411, 467);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(101, 47);
            btnCancelar.TabIndex = 65;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // ModificarCompraFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 61, 116);
            BackgroundImage = Properties.Resources.carrito_de_compras__1_;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(558, 551);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardarCompra);
            Controls.Add(txtTotal);
            Controls.Add(dtpFecha);
            Controls.Add(cmbProveedores);
            Controls.Add(txtCompraID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblCompraID);
            Controls.Add(label7);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "ModificarCompraFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modificar Compra";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label lblCompraID;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtCompraID;
        private ComboBox cmbProveedores;
        private DateTimePicker dtpFecha;
        private TextBox txtTotal;
        private Button btnGuardarCompra;
        private Button btnCancelar;
        private ContextMenuStrip contextMenuStrip1;
    }
}