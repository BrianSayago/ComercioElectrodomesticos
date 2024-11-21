namespace Presentacion.Forms
{
    partial class RegistroMovimientosFrm
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
            dgvMovimientos = new DataGridView();
            lblTitulo = new Label();
            btnActualizar = new Button();
            btnLimpiarFiltro = new Button();
            btnFiltrar = new Button();
            lblFechaFin = new Label();
            lblFechaInicio = new Label();
            dtpFechaFin = new DateTimePicker();
            dtpFechaInicio = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvMovimientos).BeginInit();
            SuspendLayout();
            // 
            // dgvMovimientos
            // 
            dgvMovimientos.AllowUserToAddRows = false;
            dgvMovimientos.AllowUserToDeleteRows = false;
            dgvMovimientos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvMovimientos.BackgroundColor = SystemColors.ControlLight;
            dgvMovimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMovimientos.Location = new Point(38, 119);
            dgvMovimientos.Name = "dgvMovimientos";
            dgvMovimientos.ReadOnly = true;
            dgvMovimientos.RowHeadersVisible = false;
            dgvMovimientos.Size = new Size(858, 413);
            dgvMovimientos.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Yu Gothic", 12F, FontStyle.Bold | FontStyle.Underline);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(374, 22);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(210, 21);
            lblTitulo.TabIndex = 27;
            lblTitulo.Text = "ULTIMOS MOVIMIENTOS";
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Bottom;
            btnActualizar.BackColor = Color.FromArgb(42, 55, 116);
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnActualizar.FlatStyle = FlatStyle.Popup;
            btnActualizar.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Image = Properties.Resources.Actualizar__1_;
            btnActualizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnActualizar.Location = new Point(374, 552);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(216, 51);
            btnActualizar.TabIndex = 28;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnLimpiarFiltro
            // 
            btnLimpiarFiltro.Location = new Point(779, 87);
            btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            btnLimpiarFiltro.Size = new Size(117, 26);
            btnLimpiarFiltro.TabIndex = 39;
            btnLimpiarFiltro.Text = "Limpiar filtro";
            btnLimpiarFiltro.UseVisualStyleBackColor = true;
            btnLimpiarFiltro.Click += btnLimpiarFiltro_Click;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFiltrar.Location = new Point(656, 88);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(117, 25);
            btnFiltrar.TabIndex = 38;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // lblFechaFin
            // 
            lblFechaFin.AutoSize = true;
            lblFechaFin.Font = new Font("Segoe UI", 11.25F);
            lblFechaFin.ForeColor = Color.White;
            lblFechaFin.Location = new Point(294, 68);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(92, 20);
            lblFechaFin.TabIndex = 37;
            lblFechaFin.Text = "Fecha de fin:";
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechaInicio.ForeColor = Color.White;
            lblFechaInicio.Location = new Point(38, 68);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(111, 20);
            lblFechaInicio.TabIndex = 36;
            lblFechaInicio.Text = "Fecha de inicio:";
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Location = new Point(294, 90);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(232, 23);
            dtpFechaFin.TabIndex = 35;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Location = new Point(38, 91);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(235, 23);
            dtpFechaInicio.TabIndex = 34;
            // 
            // RegistroMovimientosFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 61, 116);
            ClientSize = new Size(938, 615);
            Controls.Add(btnLimpiarFiltro);
            Controls.Add(btnFiltrar);
            Controls.Add(lblFechaFin);
            Controls.Add(lblFechaInicio);
            Controls.Add(dtpFechaFin);
            Controls.Add(dtpFechaInicio);
            Controls.Add(btnActualizar);
            Controls.Add(lblTitulo);
            Controls.Add(dgvMovimientos);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "RegistroMovimientosFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ultimos movimientos";
            Load += RegistroMovimientosFrm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMovimientos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMovimientos;
        private Label lblTitulo;
        private Button btnActualizar;
        private Button btnLimpiarFiltro;
        private Button btnFiltrar;
        private Label lblFechaFin;
        private Label lblFechaInicio;
        private DateTimePicker dtpFechaFin;
        private DateTimePicker dtpFechaInicio;
    }
}