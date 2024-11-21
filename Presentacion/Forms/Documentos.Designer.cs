namespace Presentacion.Forms
{
    partial class Documentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Documentos));
            lblDocumentos = new Label();
            button1 = new Button();
            btnCerrar = new Label();
            pcbDocumentos = new PictureBox();
            pcbImportarArchivo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcbDocumentos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbImportarArchivo).BeginInit();
            SuspendLayout();
            // 
            // lblDocumentos
            // 
            lblDocumentos.Anchor = AnchorStyles.Top;
            lblDocumentos.AutoSize = true;
            lblDocumentos.Font = new Font("Segoe UI", 15F);
            lblDocumentos.Location = new Point(392, 9);
            lblDocumentos.Name = "lblDocumentos";
            lblDocumentos.Size = new Size(145, 28);
            lblDocumentos.TabIndex = 5;
            lblDocumentos.Text = "DOCUMENTOS";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.BackColor = Color.FromArgb(42, 61, 116);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(343, 546);
            button1.Name = "button1";
            button1.Size = new Size(250, 45);
            button1.TabIndex = 6;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = false;
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
            // pcbDocumentos
            // 
            pcbDocumentos.Image = Properties.Resources.carpeta;
            pcbDocumentos.Location = new Point(301, 232);
            pcbDocumentos.Name = "pcbDocumentos";
            pcbDocumentos.Size = new Size(100, 100);
            pcbDocumentos.SizeMode = PictureBoxSizeMode.Zoom;
            pcbDocumentos.TabIndex = 8;
            pcbDocumentos.TabStop = false;
            pcbDocumentos.Click += pcbDocumentos_Click;
            // 
            // pcbImportarArchivo
            // 
            pcbImportarArchivo.Image = Properties.Resources.descargar_archivo;
            pcbImportarArchivo.Location = new Point(533, 232);
            pcbImportarArchivo.Name = "pcbImportarArchivo";
            pcbImportarArchivo.Size = new Size(100, 100);
            pcbImportarArchivo.SizeMode = PictureBoxSizeMode.Zoom;
            pcbImportarArchivo.TabIndex = 9;
            pcbImportarArchivo.TabStop = false;
            // 
            // Documentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(901, 603);
            Controls.Add(pcbImportarArchivo);
            Controls.Add(pcbDocumentos);
            Controls.Add(btnCerrar);
            Controls.Add(button1);
            Controls.Add(lblDocumentos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Documentos";
            Text = "Documentos";
            ((System.ComponentModel.ISupportInitialize)pcbDocumentos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbImportarArchivo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblDocumentos;
        private Button button1;
        private Label btnCerrar;
        private PictureBox pcbDocumentos;
        private PictureBox pcbImportarArchivo;
    }
}