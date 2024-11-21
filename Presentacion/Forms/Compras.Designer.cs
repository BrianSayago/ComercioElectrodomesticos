namespace Presentacion
{
    partial class Compras
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
            lblEliminarCompra = new Label();
            txtEliminarCompra = new TextBox();
            btnModificarCompra = new Button();
            btnEliminarCompra = new Button();
            btnAgregarCompra = new Button();
            dgvCompras = new DataGridView();
            btnActualizar = new Button();
            label1 = new Label();
            dgvComprasDetalladas = new DataGridView();
            btnModificarDetalleCompra = new Button();
            btnEliminarDetalleCompra = new Button();
            lblDetalleCompra = new Label();
            txtDetalleCompra = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)dgvCompras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvComprasDetalladas).BeginInit();
            SuspendLayout();
            // 
            // lblProductos
            // 
            lblProductos.Anchor = AnchorStyles.Top;
            lblProductos.AutoSize = true;
            lblProductos.Font = new Font("Segoe UI", 15F);
            lblProductos.Location = new Point(378, 9);
            lblProductos.Name = "lblProductos";
            lblProductos.Size = new Size(103, 28);
            lblProductos.TabIndex = 4;
            lblProductos.Text = "COMPRAS";
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
            btnCerrar.TabIndex = 5;
            btnCerrar.Text = "X";
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblEliminarCompra
            // 
            lblEliminarCompra.Anchor = AnchorStyles.Top;
            lblEliminarCompra.AutoSize = true;
            lblEliminarCompra.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEliminarCompra.Location = new Point(656, 209);
            lblEliminarCompra.Name = "lblEliminarCompra";
            lblEliminarCompra.Size = new Size(128, 34);
            lblEliminarCompra.TabIndex = 39;
            lblEliminarCompra.Text = "Ingrese la CompraID\r\nque desea eliminar:";
            lblEliminarCompra.Visible = false;
            // 
            // txtEliminarCompra
            // 
            txtEliminarCompra.Anchor = AnchorStyles.Top;
            txtEliminarCompra.ContextMenuStrip = contextMenuStrip1;
            txtEliminarCompra.Font = new Font("Segoe UI", 12F);
            txtEliminarCompra.Location = new Point(801, 214);
            txtEliminarCompra.Name = "txtEliminarCompra";
            txtEliminarCompra.Size = new Size(46, 29);
            txtEliminarCompra.TabIndex = 38;
            txtEliminarCompra.Visible = false;
            // 
            // btnModificarCompra
            // 
            btnModificarCompra.Anchor = AnchorStyles.Top;
            btnModificarCompra.Location = new Point(778, 49);
            btnModificarCompra.Name = "btnModificarCompra";
            btnModificarCompra.Size = new Size(96, 63);
            btnModificarCompra.TabIndex = 37;
            btnModificarCompra.Text = "Modificar compra";
            btnModificarCompra.UseVisualStyleBackColor = true;
            btnModificarCompra.Click += btnModificarCompra_Click;
            // 
            // btnEliminarCompra
            // 
            btnEliminarCompra.Anchor = AnchorStyles.Top;
            btnEliminarCompra.Location = new Point(778, 134);
            btnEliminarCompra.Name = "btnEliminarCompra";
            btnEliminarCompra.Size = new Size(96, 63);
            btnEliminarCompra.TabIndex = 36;
            btnEliminarCompra.Text = "Eliminar compra";
            btnEliminarCompra.UseVisualStyleBackColor = true;
            btnEliminarCompra.Click += btnEliminarCompra_Click;
            // 
            // btnAgregarCompra
            // 
            btnAgregarCompra.Anchor = AnchorStyles.Top;
            btnAgregarCompra.Location = new Point(59, 451);
            btnAgregarCompra.Name = "btnAgregarCompra";
            btnAgregarCompra.Size = new Size(96, 63);
            btnAgregarCompra.TabIndex = 35;
            btnAgregarCompra.Text = "Nueva compra";
            btnAgregarCompra.UseVisualStyleBackColor = true;
            btnAgregarCompra.Click += btnAgregarCompra_Click;
            // 
            // dgvCompras
            // 
            dgvCompras.AllowUserToAddRows = false;
            dgvCompras.Anchor = AnchorStyles.Top;
            dgvCompras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompras.Location = new Point(59, 49);
            dgvCompras.Name = "dgvCompras";
            dgvCompras.ReadOnly = true;
            dgvCompras.RowHeadersVisible = false;
            dgvCompras.Size = new Size(691, 148);
            dgvCompras.TabIndex = 34;
            dgvCompras.CellClick += dgvCompras_CellClick;
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
            btnActualizar.Location = new Point(322, 540);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(216, 51);
            btnActualizar.TabIndex = 40;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(322, 229);
            label1.Name = "label1";
            label1.Size = new Size(224, 28);
            label1.TabIndex = 41;
            label1.Text = "COMPRAS DETALLADAS";
            // 
            // dgvComprasDetalladas
            // 
            dgvComprasDetalladas.AllowUserToAddRows = false;
            dgvComprasDetalladas.Anchor = AnchorStyles.Top;
            dgvComprasDetalladas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvComprasDetalladas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvComprasDetalladas.Location = new Point(59, 270);
            dgvComprasDetalladas.Name = "dgvComprasDetalladas";
            dgvComprasDetalladas.ReadOnly = true;
            dgvComprasDetalladas.RowHeadersVisible = false;
            dgvComprasDetalladas.Size = new Size(691, 148);
            dgvComprasDetalladas.TabIndex = 42;
            dgvComprasDetalladas.CellClick += dgvComprasDetalladas_CellClick;
            // 
            // btnModificarDetalleCompra
            // 
            btnModificarDetalleCompra.Anchor = AnchorStyles.Top;
            btnModificarDetalleCompra.Location = new Point(778, 270);
            btnModificarDetalleCompra.Name = "btnModificarDetalleCompra";
            btnModificarDetalleCompra.Size = new Size(96, 63);
            btnModificarDetalleCompra.TabIndex = 43;
            btnModificarDetalleCompra.Text = "Modificar compra detallada";
            btnModificarDetalleCompra.UseVisualStyleBackColor = true;
            btnModificarDetalleCompra.Click += btnModificarDetalleCompra_Click;
            // 
            // btnEliminarDetalleCompra
            // 
            btnEliminarDetalleCompra.Anchor = AnchorStyles.Top;
            btnEliminarDetalleCompra.Location = new Point(778, 355);
            btnEliminarDetalleCompra.Name = "btnEliminarDetalleCompra";
            btnEliminarDetalleCompra.Size = new Size(96, 63);
            btnEliminarDetalleCompra.TabIndex = 44;
            btnEliminarDetalleCompra.Text = "Eliminar compra detallada";
            btnEliminarDetalleCompra.UseVisualStyleBackColor = true;
            btnEliminarDetalleCompra.Click += btnEliminarDetalleCompra_Click;
            // 
            // lblDetalleCompra
            // 
            lblDetalleCompra.Anchor = AnchorStyles.Top;
            lblDetalleCompra.AutoSize = true;
            lblDetalleCompra.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDetalleCompra.Location = new Point(612, 427);
            lblDetalleCompra.Name = "lblDetalleCompra";
            lblDetalleCompra.Size = new Size(172, 34);
            lblDetalleCompra.TabIndex = 45;
            lblDetalleCompra.Text = "Ingrese el  DetalleCompraID\r\nque desea eliminar:";
            lblDetalleCompra.Visible = false;
            // 
            // txtDetalleCompra
            // 
            txtDetalleCompra.Anchor = AnchorStyles.Top;
            txtDetalleCompra.ContextMenuStrip = contextMenuStrip1;
            txtDetalleCompra.Font = new Font("Segoe UI", 12F);
            txtDetalleCompra.Location = new Point(801, 432);
            txtDetalleCompra.Name = "txtDetalleCompra";
            txtDetalleCompra.Size = new Size(46, 29);
            txtDetalleCompra.TabIndex = 46;
            txtDetalleCompra.Visible = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Compras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 603);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(txtDetalleCompra);
            Controls.Add(lblDetalleCompra);
            Controls.Add(btnEliminarDetalleCompra);
            Controls.Add(btnModificarDetalleCompra);
            Controls.Add(dgvComprasDetalladas);
            Controls.Add(label1);
            Controls.Add(btnActualizar);
            Controls.Add(lblEliminarCompra);
            Controls.Add(txtEliminarCompra);
            Controls.Add(btnModificarCompra);
            Controls.Add(btnEliminarCompra);
            Controls.Add(btnAgregarCompra);
            Controls.Add(dgvCompras);
            Controls.Add(btnCerrar);
            Controls.Add(lblProductos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Compras";
            Text = "Compras";
            Load += Compras_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCompras).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvComprasDetalladas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblProductos;
        private Label btnCerrar;
        private Label lblEliminarCompra;
        private TextBox txtEliminarCompra;
        private Button btnModificarCompra;
        private Button btnEliminarCompra;
        private Button btnAgregarCompra;
        private DataGridView dgvCompras;
        private Button btnActualizar;
        private Label label1;
        private DataGridView dgvComprasDetalladas;
        private Button btnModificarDetalleCompra;
        private Button btnEliminarDetalleCompra;
        private Label lblDetalleCompra;
        private TextBox txtDetalleCompra;
        private ContextMenuStrip contextMenuStrip1;
    }
}