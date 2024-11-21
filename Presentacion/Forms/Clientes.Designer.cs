namespace Presentacion
{
    partial class Clientes
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
            lblEliminarCliente = new Label();
            txtEliminarCliente = new TextBox();
            btnModificarCliente = new Button();
            btnEliminarCliente = new Button();
            btnAgregarCliente = new Button();
            dgvClientes = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // lblProductos
            // 
            lblProductos.Anchor = AnchorStyles.Top;
            lblProductos.AutoSize = true;
            lblProductos.Font = new Font("Segoe UI", 15F);
            lblProductos.Location = new Point(398, 9);
            lblProductos.Name = "lblProductos";
            lblProductos.Size = new Size(94, 28);
            lblProductos.TabIndex = 4;
            lblProductos.Text = "CLIENTES";
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
            btnActualizar.TabIndex = 28;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // lblEliminarCliente
            // 
            lblEliminarCliente.Anchor = AnchorStyles.Top;
            lblEliminarCliente.AutoSize = true;
            lblEliminarCliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEliminarCliente.Location = new Point(538, 459);
            lblEliminarCliente.Name = "lblEliminarCliente";
            lblEliminarCliente.Size = new Size(122, 34);
            lblEliminarCliente.TabIndex = 27;
            lblEliminarCliente.Text = "Ingrese el ClienteID\r\nque desea eliminar:";
            lblEliminarCliente.Visible = false;
            // 
            // txtEliminarCliente
            // 
            txtEliminarCliente.Anchor = AnchorStyles.Top;
            txtEliminarCliente.ContextMenuStrip = contextMenuStrip1;
            txtEliminarCliente.Font = new Font("Segoe UI", 12F);
            txtEliminarCliente.Location = new Point(678, 464);
            txtEliminarCliente.Name = "txtEliminarCliente";
            txtEliminarCliente.Size = new Size(46, 29);
            txtEliminarCliente.TabIndex = 26;
            txtEliminarCliente.Visible = false;
            // 
            // btnModificarCliente
            // 
            btnModificarCliente.Anchor = AnchorStyles.Top;
            btnModificarCliente.Location = new Point(176, 448);
            btnModificarCliente.Name = "btnModificarCliente";
            btnModificarCliente.Size = new Size(96, 63);
            btnModificarCliente.TabIndex = 25;
            btnModificarCliente.Text = "Modificar cliente";
            btnModificarCliente.UseVisualStyleBackColor = true;
            btnModificarCliente.Click += btnModificarCliente_Click;
            // 
            // btnEliminarCliente
            // 
            btnEliminarCliente.Anchor = AnchorStyles.Top;
            btnEliminarCliente.Location = new Point(745, 448);
            btnEliminarCliente.Name = "btnEliminarCliente";
            btnEliminarCliente.Size = new Size(96, 63);
            btnEliminarCliente.TabIndex = 24;
            btnEliminarCliente.Text = "Eliminar cliente";
            btnEliminarCliente.UseVisualStyleBackColor = true;
            btnEliminarCliente.Click += btnEliminarCliente_Click;
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.Anchor = AnchorStyles.Top;
            btnAgregarCliente.Location = new Point(59, 448);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(96, 63);
            btnAgregarCliente.TabIndex = 23;
            btnAgregarCliente.Text = "Nuevo cliente";
            btnAgregarCliente.UseVisualStyleBackColor = true;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.Anchor = AnchorStyles.Top;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(59, 86);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.Size = new Size(782, 321);
            dgvClientes.TabIndex = 22;
            dgvClientes.CellClick += dgvClientes_CellClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 603);
            Controls.Add(btnActualizar);
            Controls.Add(lblEliminarCliente);
            Controls.Add(txtEliminarCliente);
            Controls.Add(btnModificarCliente);
            Controls.Add(btnEliminarCliente);
            Controls.Add(btnAgregarCliente);
            Controls.Add(dgvClientes);
            Controls.Add(btnCerrar);
            Controls.Add(lblProductos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Clientes";
            Text = "Clientes";
            Load += Clientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblProductos;
        private Label btnCerrar;
        private Button btnActualizar;
        private Label lblEliminarCliente;
        private TextBox txtEliminarCliente;
        private Button btnModificarCliente;
        private Button btnEliminarCliente;
        private Button btnAgregarCliente;
        private DataGridView dgvClientes;
        private ContextMenuStrip contextMenuStrip1;
    }
}