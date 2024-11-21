namespace Presentacion
{
    partial class Historial
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
            lblHistorial = new Label();
            btnCerrar = new Label();
            btnHistoricoVC = new Button();
            btnRegistroCambios = new Button();
            SuspendLayout();
            // 
            // lblHistorial
            // 
            lblHistorial.Anchor = AnchorStyles.Top;
            lblHistorial.AutoSize = true;
            lblHistorial.Font = new Font("Segoe UI", 15F);
            lblHistorial.Location = new Point(398, 9);
            lblHistorial.Name = "lblHistorial";
            lblHistorial.Size = new Size(105, 28);
            lblHistorial.TabIndex = 5;
            lblHistorial.Text = "HISTORIAL";
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
            btnCerrar.TabIndex = 8;
            btnCerrar.Text = "X";
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnHistoricoVC
            // 
            btnHistoricoVC.Anchor = AnchorStyles.Top;
            btnHistoricoVC.BackColor = Color.FromArgb(42, 61, 116);
            btnHistoricoVC.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold);
            btnHistoricoVC.ForeColor = Color.White;
            btnHistoricoVC.Location = new Point(252, 211);
            btnHistoricoVC.Name = "btnHistoricoVC";
            btnHistoricoVC.Size = new Size(161, 143);
            btnHistoricoVC.TabIndex = 9;
            btnHistoricoVC.Text = "Historico venta/compra";
            btnHistoricoVC.UseVisualStyleBackColor = false;
            btnHistoricoVC.Click += btnHistoricoVC_Click;
            // 
            // btnRegistroCambios
            // 
            btnRegistroCambios.Anchor = AnchorStyles.Top;
            btnRegistroCambios.BackColor = Color.FromArgb(42, 61, 116);
            btnRegistroCambios.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold);
            btnRegistroCambios.ForeColor = Color.White;
            btnRegistroCambios.Location = new Point(471, 211);
            btnRegistroCambios.Name = "btnRegistroCambios";
            btnRegistroCambios.Size = new Size(161, 143);
            btnRegistroCambios.TabIndex = 10;
            btnRegistroCambios.Text = "Registro de movimientos";
            btnRegistroCambios.UseVisualStyleBackColor = false;
            btnRegistroCambios.Click += btnRegistroCambios_Click;
            // 
            // Historial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 603);
            Controls.Add(btnRegistroCambios);
            Controls.Add(btnHistoricoVC);
            Controls.Add(btnCerrar);
            Controls.Add(lblHistorial);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Historial";
            Text = "Historial";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblHistorial;
        private Label btnCerrar;
        private Button btnHistoricoVC;
        private Button btnRegistroCambios;
    }
}