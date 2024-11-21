namespace Presentacion
{
    partial class Proveedores
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
            lblEliminarProve = new Label();
            txtEliminarProve = new TextBox();
            btnModificarProve = new Button();
            btnEliminarProve = new Button();
            btnAgregarProveedor = new Button();
            dgvProveedores = new DataGridView();
            btnActualizar = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            SuspendLayout();
            // 
            // lblProductos
            // 
            lblProductos.Anchor = AnchorStyles.Top;
            lblProductos.AutoSize = true;
            lblProductos.Font = new Font("Segoe UI", 15F);
            lblProductos.Location = new Point(398, 9);
            lblProductos.Name = "lblProductos";
            lblProductos.Size = new Size(144, 28);
            lblProductos.TabIndex = 4;
            lblProductos.Text = "PROVEEDORES";
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
            // lblEliminarProve
            // 
            lblEliminarProve.Anchor = AnchorStyles.Top;
            lblEliminarProve.AutoSize = true;
            lblEliminarProve.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEliminarProve.Location = new Point(530, 462);
            lblEliminarProve.Name = "lblEliminarProve";
            lblEliminarProve.Size = new Size(142, 34);
            lblEliminarProve.TabIndex = 33;
            lblEliminarProve.Text = "Ingrese el ProveedorID\r\nque desea eliminar:";
            lblEliminarProve.Visible = false;
            // 
            // txtEliminarProve
            // 
            txtEliminarProve.Anchor = AnchorStyles.Top;
            txtEliminarProve.ContextMenuStrip = contextMenuStrip1;
            txtEliminarProve.Font = new Font("Segoe UI", 12F);
            txtEliminarProve.Location = new Point(678, 467);
            txtEliminarProve.Name = "txtEliminarProve";
            txtEliminarProve.Size = new Size(46, 29);
            txtEliminarProve.TabIndex = 32;
            txtEliminarProve.Visible = false;
            // 
            // btnModificarProve
            // 
            btnModificarProve.Anchor = AnchorStyles.Top;
            btnModificarProve.Location = new Point(176, 451);
            btnModificarProve.Name = "btnModificarProve";
            btnModificarProve.Size = new Size(96, 63);
            btnModificarProve.TabIndex = 31;
            btnModificarProve.Text = "Modificar proveedor";
            btnModificarProve.UseVisualStyleBackColor = true;
            btnModificarProve.Click += btnModificarProve_Click;
            // 
            // btnEliminarProve
            // 
            btnEliminarProve.Anchor = AnchorStyles.Top;
            btnEliminarProve.Location = new Point(745, 451);
            btnEliminarProve.Name = "btnEliminarProve";
            btnEliminarProve.Size = new Size(96, 63);
            btnEliminarProve.TabIndex = 30;
            btnEliminarProve.Text = "Eliminar proveedor";
            btnEliminarProve.UseVisualStyleBackColor = true;
            btnEliminarProve.Click += btnEliminarProveedor_Click;
            // 
            // btnAgregarProveedor
            // 
            btnAgregarProveedor.Anchor = AnchorStyles.Top;
            btnAgregarProveedor.Location = new Point(59, 451);
            btnAgregarProveedor.Name = "btnAgregarProveedor";
            btnAgregarProveedor.Size = new Size(96, 63);
            btnAgregarProveedor.TabIndex = 29;
            btnAgregarProveedor.Text = "Nuevo proveedor";
            btnAgregarProveedor.UseVisualStyleBackColor = true;
            btnAgregarProveedor.Click += btnAgregarProveedor_Click;
            // 
            // dgvProveedores
            // 
            dgvProveedores.AllowUserToAddRows = false;
            dgvProveedores.Anchor = AnchorStyles.Top;
            dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.Location = new Point(59, 89);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.ReadOnly = true;
            dgvProveedores.RowHeadersVisible = false;
            dgvProveedores.Size = new Size(782, 321);
            dgvProveedores.TabIndex = 28;
            dgvProveedores.CellClick += dgvProveedores_CellClick;
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
            btnActualizar.TabIndex = 34;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Proveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 603);
            Controls.Add(btnActualizar);
            Controls.Add(lblEliminarProve);
            Controls.Add(txtEliminarProve);
            Controls.Add(btnModificarProve);
            Controls.Add(btnEliminarProve);
            Controls.Add(btnAgregarProveedor);
            Controls.Add(dgvProveedores);
            Controls.Add(btnCerrar);
            Controls.Add(lblProductos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Proveedores";
            Text = "Proveedores";
            Load += Proveedores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblProductos;
        private Label btnCerrar;
        private Label lblEliminarProve;
        private TextBox txtEliminarProve;
        private Button btnModificarProve;
        private Button btnEliminarProve;
        private Button btnAgregarProveedor;
        private DataGridView dgvProveedores;
        private Button btnActualizar;
        private ContextMenuStrip contextMenuStrip1;
    }
}