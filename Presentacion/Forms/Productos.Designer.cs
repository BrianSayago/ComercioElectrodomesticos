namespace Presentacion
{
    partial class Productos
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
            btnActualizar = new Button();
            dgvProductos = new DataGridView();
            btnAgregarProducto = new Button();
            btnEliminarProducto = new Button();
            btnModificarProducto = new Button();
            txtEliminarProd = new TextBox();
            lblEliminarProd = new Label();
            btnCargarExcel = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // lblProductos
            // 
            lblProductos.Anchor = AnchorStyles.Top;
            lblProductos.AutoSize = true;
            lblProductos.Font = new Font("Segoe UI", 15F);
            lblProductos.Location = new Point(398, 9);
            lblProductos.Name = "lblProductos";
            lblProductos.Size = new Size(125, 28);
            lblProductos.TabIndex = 0;
            lblProductos.Text = "PRODUCTOS";
            lblProductos.TextAlign = ContentAlignment.TopCenter;
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
            btnCerrar.TabIndex = 7;
            btnCerrar.Text = "X";
            btnCerrar.Click += btnCerrar_Click;
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
            btnActualizar.TabIndex = 8;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.Anchor = AnchorStyles.Top;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(69, 82);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.Size = new Size(782, 321);
            dgvProductos.TabIndex = 9;
            dgvProductos.CellClick += dgvProductos_CellClick;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Anchor = AnchorStyles.Top;
            btnAgregarProducto.Location = new Point(69, 444);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(96, 63);
            btnAgregarProducto.TabIndex = 10;
            btnAgregarProducto.Text = "Nuevo producto";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Anchor = AnchorStyles.Top;
            btnEliminarProducto.Location = new Point(755, 444);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(96, 63);
            btnEliminarProducto.TabIndex = 11;
            btnEliminarProducto.Text = "Eliminar producto";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // btnModificarProducto
            // 
            btnModificarProducto.Anchor = AnchorStyles.Top;
            btnModificarProducto.Location = new Point(186, 444);
            btnModificarProducto.Name = "btnModificarProducto";
            btnModificarProducto.Size = new Size(96, 63);
            btnModificarProducto.TabIndex = 12;
            btnModificarProducto.Text = "Modificar Producto";
            btnModificarProducto.UseVisualStyleBackColor = true;
            btnModificarProducto.Click += btnModificarProducto_Click;
            // 
            // txtEliminarProd
            // 
            txtEliminarProd.Anchor = AnchorStyles.Top;
            txtEliminarProd.ContextMenuStrip = contextMenuStrip1;
            txtEliminarProd.Font = new Font("Segoe UI", 12F);
            txtEliminarProd.Location = new Point(684, 466);
            txtEliminarProd.Name = "txtEliminarProd";
            txtEliminarProd.Size = new Size(46, 29);
            txtEliminarProd.TabIndex = 13;
            txtEliminarProd.Visible = false;
            // 
            // lblEliminarProd
            // 
            lblEliminarProd.Anchor = AnchorStyles.Top;
            lblEliminarProd.AutoSize = true;
            lblEliminarProd.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEliminarProd.Location = new Point(544, 461);
            lblEliminarProd.Name = "lblEliminarProd";
            lblEliminarProd.Size = new Size(134, 34);
            lblEliminarProd.TabIndex = 14;
            lblEliminarProd.Text = "Ingrese el ProductoID\r\nque desea eliminar:";
            lblEliminarProd.Visible = false;
            // 
            // btnCargarExcel
            // 
            btnCargarExcel.Anchor = AnchorStyles.Top;
            btnCargarExcel.Location = new Point(300, 444);
            btnCargarExcel.Name = "btnCargarExcel";
            btnCargarExcel.Size = new Size(92, 63);
            btnCargarExcel.TabIndex = 15;
            btnCargarExcel.Text = "Insertar archivo";
            btnCargarExcel.UseVisualStyleBackColor = true;
            btnCargarExcel.Click += btnCargarExcel_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 603);
            Controls.Add(btnCargarExcel);
            Controls.Add(lblEliminarProd);
            Controls.Add(txtEliminarProd);
            Controls.Add(btnModificarProducto);
            Controls.Add(btnEliminarProducto);
            Controls.Add(btnAgregarProducto);
            Controls.Add(dgvProductos);
            Controls.Add(btnActualizar);
            Controls.Add(btnCerrar);
            Controls.Add(lblProductos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Productos";
            Text = "Productos";
            Load += Productos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProductos;
        private Label btnCerrar;
        private Button btnActualizar;
        private DataGridView dgvProductos;
        private Button btnAgregarProducto;
        private Button btnEliminarProducto;
        private Button btnModificarProducto;
        private TextBox txtEliminarProd;
        private Label lblEliminarProd;
        private Button btnCargarExcel;
        private ContextMenuStrip contextMenuStrip1;
    }
}