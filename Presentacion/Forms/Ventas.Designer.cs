namespace Presentacion
{
    partial class Ventas
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
            lblProductos = new Label();
            btnCerrar = new Label();
            lblEliminarVenta = new Label();
            txtEliminarVenta = new TextBox();
            btnModificarVenta = new Button();
            btnEliminarVenta = new Button();
            btnAgregarVenta = new Button();
            dgvVentas = new DataGridView();
            btnActualizar = new Button();
            dgvVentasDetalladas = new DataGridView();
            label1 = new Label();
            btnEliminarDetalleVenta = new Button();
            lblDetalleVenta = new Label();
            txtDetalleVenta = new TextBox();
            btnModificarDetalleVenta = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVentasDetalladas).BeginInit();
            SuspendLayout();
            // 
            // lblProductos
            // 
            lblProductos.Anchor = AnchorStyles.Top;
            lblProductos.AutoSize = true;
            lblProductos.Font = new Font("Segoe UI", 15F);
            lblProductos.Location = new Point(398, 9);
            lblProductos.Name = "lblProductos";
            lblProductos.Size = new Size(82, 28);
            lblProductos.TabIndex = 4;
            lblProductos.Text = "VENTAS";
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.AutoSize = true;
            btnCerrar.BackColor = Color.WhiteSmoke;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Font = new Font("Segoe UI", 11F);
            btnCerrar.ForeColor = Color.Black;
            btnCerrar.Location = new Point(880, -1);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(18, 20);
            btnCerrar.TabIndex = 6;
            btnCerrar.Text = "X";
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblEliminarVenta
            // 
            lblEliminarVenta.Anchor = AnchorStyles.Top;
            lblEliminarVenta.AutoSize = true;
            lblEliminarVenta.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEliminarVenta.Location = new Point(614, 200);
            lblEliminarVenta.Name = "lblEliminarVenta";
            lblEliminarVenta.Size = new Size(122, 34);
            lblEliminarVenta.TabIndex = 20;
            lblEliminarVenta.Text = "Ingrese la VentaID\r\nque desea eliminar:";
            lblEliminarVenta.Visible = false;
            // 
            // txtEliminarVenta
            // 
            txtEliminarVenta.Anchor = AnchorStyles.Top;
            txtEliminarVenta.ContextMenuStrip = contextMenuStrip1;
            txtEliminarVenta.Font = new Font("Segoe UI", 12F);
            txtEliminarVenta.Location = new Point(772, 205);
            txtEliminarVenta.Name = "txtEliminarVenta";
            txtEliminarVenta.Size = new Size(46, 29);
            txtEliminarVenta.TabIndex = 19;
            txtEliminarVenta.Visible = false;
            // 
            // btnModificarVenta
            // 
            btnModificarVenta.Anchor = AnchorStyles.Top;
            btnModificarVenta.Location = new Point(752, 49);
            btnModificarVenta.Name = "btnModificarVenta";
            btnModificarVenta.Size = new Size(96, 63);
            btnModificarVenta.TabIndex = 18;
            btnModificarVenta.Text = "Modificar venta";
            btnModificarVenta.UseVisualStyleBackColor = true;
            btnModificarVenta.Click += btnModificarVenta_Click;
            // 
            // btnEliminarVenta
            // 
            btnEliminarVenta.Anchor = AnchorStyles.Top;
            btnEliminarVenta.Location = new Point(752, 134);
            btnEliminarVenta.Name = "btnEliminarVenta";
            btnEliminarVenta.Size = new Size(96, 63);
            btnEliminarVenta.TabIndex = 17;
            btnEliminarVenta.Text = "Eliminar venta";
            btnEliminarVenta.UseVisualStyleBackColor = true;
            btnEliminarVenta.Click += btnEliminarVenta_Click;
            // 
            // btnAgregarVenta
            // 
            btnAgregarVenta.Anchor = AnchorStyles.Top;
            btnAgregarVenta.Location = new Point(59, 451);
            btnAgregarVenta.Name = "btnAgregarVenta";
            btnAgregarVenta.Size = new Size(96, 63);
            btnAgregarVenta.TabIndex = 16;
            btnAgregarVenta.Text = "Nueva venta";
            btnAgregarVenta.UseVisualStyleBackColor = true;
            btnAgregarVenta.Click += btnAgregarVenta_Click;
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.Anchor = AnchorStyles.Top;
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(59, 49);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.ReadOnly = true;
            dgvVentas.RowHeadersVisible = false;
            dgvVentas.Size = new Size(677, 148);
            dgvVentas.TabIndex = 15;
            dgvVentas.CellClick += dgvVentas_CellClick;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Bottom;
            btnActualizar.BackColor = Color.FromArgb(42, 61, 116);
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnActualizar.FlatStyle = FlatStyle.Popup;
            btnActualizar.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Image = Properties.Resources.Actualizar__1_;
            btnActualizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnActualizar.Location = new Point(343, 540);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(216, 51);
            btnActualizar.TabIndex = 21;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click_1;
            // 
            // dgvVentasDetalladas
            // 
            dgvVentasDetalladas.AllowUserToAddRows = false;
            dgvVentasDetalladas.Anchor = AnchorStyles.Top;
            dgvVentasDetalladas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentasDetalladas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentasDetalladas.Location = new Point(59, 270);
            dgvVentasDetalladas.Name = "dgvVentasDetalladas";
            dgvVentasDetalladas.ReadOnly = true;
            dgvVentasDetalladas.RowHeadersVisible = false;
            dgvVentasDetalladas.Size = new Size(677, 148);
            dgvVentasDetalladas.TabIndex = 22;
            dgvVentasDetalladas.CellClick += dgvVentasDetalladas_CellClick;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(343, 230);
            label1.Name = "label1";
            label1.Size = new Size(203, 28);
            label1.TabIndex = 23;
            label1.Text = "VENTAS DETALLADAS";
            // 
            // btnEliminarDetalleVenta
            // 
            btnEliminarDetalleVenta.Anchor = AnchorStyles.Top;
            btnEliminarDetalleVenta.Location = new Point(752, 355);
            btnEliminarDetalleVenta.Name = "btnEliminarDetalleVenta";
            btnEliminarDetalleVenta.Size = new Size(96, 63);
            btnEliminarDetalleVenta.TabIndex = 24;
            btnEliminarDetalleVenta.Text = "Eliminar venta detallada";
            btnEliminarDetalleVenta.UseVisualStyleBackColor = true;
            btnEliminarDetalleVenta.Click += btnEliminarDetalleVenta_Click;
            // 
            // lblDetalleVenta
            // 
            lblDetalleVenta.Anchor = AnchorStyles.Top;
            lblDetalleVenta.AutoSize = true;
            lblDetalleVenta.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDetalleVenta.Location = new Point(579, 423);
            lblDetalleVenta.Name = "lblDetalleVenta";
            lblDetalleVenta.Size = new Size(157, 34);
            lblDetalleVenta.TabIndex = 26;
            lblDetalleVenta.Text = "Ingrese el  DetalleVentaID\r\nque desea eliminar:";
            lblDetalleVenta.Visible = false;
            // 
            // txtDetalleVenta
            // 
            txtDetalleVenta.Anchor = AnchorStyles.Top;
            txtDetalleVenta.ContextMenuStrip = contextMenuStrip1;
            txtDetalleVenta.Font = new Font("Segoe UI", 12F);
            txtDetalleVenta.Location = new Point(772, 428);
            txtDetalleVenta.Name = "txtDetalleVenta";
            txtDetalleVenta.Size = new Size(46, 29);
            txtDetalleVenta.TabIndex = 25;
            txtDetalleVenta.Visible = false;
            // 
            // btnModificarDetalleVenta
            // 
            btnModificarDetalleVenta.Anchor = AnchorStyles.Top;
            btnModificarDetalleVenta.Location = new Point(752, 270);
            btnModificarDetalleVenta.Name = "btnModificarDetalleVenta";
            btnModificarDetalleVenta.Size = new Size(96, 63);
            btnModificarDetalleVenta.TabIndex = 27;
            btnModificarDetalleVenta.Text = "Modificar venta detallada";
            btnModificarDetalleVenta.UseVisualStyleBackColor = true;
            btnModificarDetalleVenta.Click += btnModificarDetalleVenta_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(901, 603);
            Controls.Add(btnModificarDetalleVenta);
            Controls.Add(lblDetalleVenta);
            Controls.Add(txtDetalleVenta);
            Controls.Add(btnEliminarDetalleVenta);
            Controls.Add(label1);
            Controls.Add(dgvVentasDetalladas);
            Controls.Add(btnActualizar);
            Controls.Add(lblEliminarVenta);
            Controls.Add(txtEliminarVenta);
            Controls.Add(btnModificarVenta);
            Controls.Add(btnEliminarVenta);
            Controls.Add(btnAgregarVenta);
            Controls.Add(dgvVentas);
            Controls.Add(btnCerrar);
            Controls.Add(lblProductos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Ventas";
            Text = "Ventas";
            Load += Ventas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVentasDetalladas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblProductos;
        private Label btnCerrar;
        private Label lblEliminarVenta;
        private TextBox txtEliminarVenta;
        private Button btnModificarVenta;
        private Button btnEliminarVenta;
        private Button btnAgregarVenta;
        private DataGridView dgvVentas;
        private Button btnActualizar;
        private DataGridView dgvVentasDetalladas;
        private Label label1;
        private Button btnEliminarDetalleVenta;
        private Label lblDetalleVenta;
        private TextBox txtDetalleVenta;
        private Button btnModificarDetalleVenta;
        private ContextMenuStrip contextMenuStrip1;
    }
}