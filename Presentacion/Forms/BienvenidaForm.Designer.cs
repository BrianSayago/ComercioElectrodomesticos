namespace Presentacion
{
    partial class BienvenidaForm
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
            panel1 = new Panel();
            lblEH = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            lblWelcome = new Label();
            lblUsername = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            progressBar1 = new ProgressBar();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(42, 61, 116);
            panel1.Controls.Add(lblEH);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 100);
            panel1.TabIndex = 0;
            // 
            // lblEH
            // 
            lblEH.AutoSize = true;
            lblEH.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEH.ForeColor = Color.White;
            lblEH.Location = new Point(143, 30);
            lblEH.Name = "lblEH";
            lblEH.Size = new Size(154, 32);
            lblEH.TabIndex = 2;
            lblEH.Text = "ElectroHouse";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Logo_restaurante_marino;
            pictureBox2.Location = new Point(0, -31);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(137, 159);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.view_modern_air_fryer_with_food;
            pictureBox1.Location = new Point(0, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(321, 424);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.FromArgb(0, 100, 180);
            lblWelcome.Location = new Point(327, 103);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(278, 72);
            lblWelcome.TabIndex = 3;
            lblWelcome.Text = "WELCOME";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.DarkGray;
            lblUsername.Location = new Point(340, 175);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(136, 37);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "Username";
            // 
            // timer1
            // 
            timer1.Interval = 30;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 30;
            timer2.Tick += timer2_Tick;
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.FromArgb(42, 61, 116);
            progressBar1.ForeColor = Color.FromArgb(42, 61, 116);
            progressBar1.Location = new Point(327, 460);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(661, 28);
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 5;
            // 
            // BienvenidaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 47, 66);
            ClientSize = new Size(1000, 500);
            Controls.Add(progressBar1);
            Controls.Add(panel1);
            Controls.Add(lblUsername);
            Controls.Add(lblWelcome);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BienvenidaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BienvenidaForm";
            Load += BienvenidaForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lblEH;
        private Label lblWelcome;
        private Label lblUsername;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private ProgressBar progressBar1;
    }
}