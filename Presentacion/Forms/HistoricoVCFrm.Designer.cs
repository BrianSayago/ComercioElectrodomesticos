namespace Presentacion.Forms
{
    partial class HistoricoVCFrm
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
            dgvHistoricoVC = new DataGridView();
            lblTitulo = new Label();
            dtpFechaInicio = new DateTimePicker();
            dtpFechaFin = new DateTimePicker();
            lblFechaInicio = new Label();
            lblFechaFin = new Label();
            btnFiltrar = new Button();
            btnLimpiarFiltro = new Button();
            btnActualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHistoricoVC).BeginInit();
            SuspendLayout();
            // 
            // dgvHistoricoVC
            // 
            dgvHistoricoVC.AllowUserToAddRows = false;
            dgvHistoricoVC.AllowUserToDeleteRows = false;
            dgvHistoricoVC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvHistoricoVC.BackgroundColor = SystemColors.ControlLight;
            dgvHistoricoVC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistoricoVC.Location = new Point(80, 127);
            dgvHistoricoVC.Name = "dgvHistoricoVC";
            dgvHistoricoVC.ReadOnly = true;
            dgvHistoricoVC.RowHeadersVisible = false;
            dgvHistoricoVC.Size = new Size(786, 421);
            dgvHistoricoVC.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Yu Gothic", 12F, FontStyle.Bold | FontStyle.Underline);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(365, 22);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(274, 21);
            lblTitulo.TabIndex = 27;
            lblTitulo.Text = "HISTORICO VENTAS Y COMPRAS";
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Location = new Point(80, 98);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(235, 23);
            dtpFechaInicio.TabIndex = 28;
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Location = new Point(331, 98);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(232, 23);
            dtpFechaFin.TabIndex = 29;
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechaInicio.ForeColor = Color.White;
            lblFechaInicio.Location = new Point(80, 75);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(111, 20);
            lblFechaInicio.TabIndex = 30;
            lblFechaInicio.Text = "Fecha de inicio:";
            // 
            // lblFechaFin
            // 
            lblFechaFin.AutoSize = true;
            lblFechaFin.Font = new Font("Segoe UI", 11.25F);
            lblFechaFin.ForeColor = Color.White;
            lblFechaFin.Location = new Point(331, 75);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(92, 20);
            lblFechaFin.TabIndex = 31;
            lblFechaFin.Text = "Fecha de fin:";
            // 
            // btnFiltrar
            // 
            btnFiltrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFiltrar.Location = new Point(626, 95);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(117, 25);
            btnFiltrar.TabIndex = 32;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // btnLimpiarFiltro
            // 
            btnLimpiarFiltro.Location = new Point(749, 95);
            btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            btnLimpiarFiltro.Size = new Size(117, 25);
            btnLimpiarFiltro.TabIndex = 33;
            btnLimpiarFiltro.Text = "Limpiar filtro";
            btnLimpiarFiltro.UseVisualStyleBackColor = true;
            btnLimpiarFiltro.Click += btnLimpiarFiltro_Click;
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
            btnActualizar.Location = new Point(377, 555);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(216, 55);
            btnActualizar.TabIndex = 34;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // HistoricoVCFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 61, 116);
            ClientSize = new Size(954, 622);
            Controls.Add(btnActualizar);
            Controls.Add(btnLimpiarFiltro);
            Controls.Add(btnFiltrar);
            Controls.Add(lblFechaFin);
            Controls.Add(lblFechaInicio);
            Controls.Add(dtpFechaFin);
            Controls.Add(dtpFechaInicio);
            Controls.Add(lblTitulo);
            Controls.Add(dgvHistoricoVC);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "HistoricoVCFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Historico ventas y compras";
            Load += HistoricoVCFrm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistoricoVC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvHistoricoVC;
        private Label lblTitulo;
        private DateTimePicker dtpFechaInicio;
        private DateTimePicker dtpFechaFin;
        private Label lblFechaInicio;
        private Label lblFechaFin;
        private Button btnFiltrar;
        private Button btnLimpiarFiltro;
        private Button btnActualizar;
    }
}