namespace Presentacion.Forms
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            MenuVertical = new Panel();
            btnDocs = new Button();
            btnHistorial = new Button();
            btnCompras = new Button();
            btnProveedores = new Button();
            btnClientes = new Button();
            btnVentas = new Button();
            btnProductos = new Button();
            pictureBox2 = new PictureBox();
            BarraTitulo = new Panel();
            btnHome = new PictureBox();
            iconRestore = new PictureBox();
            iconMin = new PictureBox();
            iconMax = new PictureBox();
            iconCerrar = new PictureBox();
            btnSlide = new PictureBox();
            pictureBox1 = new PictureBox();
            panelContenedor = new Panel();
            lblDate = new Label();
            lblClock = new Label();
            timerSlide = new System.Windows.Forms.Timer(components);
            timerClock = new System.Windows.Forms.Timer(components);
            timerFecha = new System.Windows.Forms.Timer(components);
            MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconRestore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSlide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelContenedor.SuspendLayout();
            SuspendLayout();
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = Color.FromArgb(42, 61, 116);
            MenuVertical.Controls.Add(btnDocs);
            MenuVertical.Controls.Add(btnHistorial);
            MenuVertical.Controls.Add(btnCompras);
            MenuVertical.Controls.Add(btnProveedores);
            MenuVertical.Controls.Add(btnClientes);
            MenuVertical.Controls.Add(btnVentas);
            MenuVertical.Controls.Add(btnProductos);
            MenuVertical.Controls.Add(pictureBox2);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.Location = new Point(0, 0);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(70, 657);
            MenuVertical.TabIndex = 0;
            // 
            // btnDocs
            // 
            btnDocs.FlatAppearance.BorderSize = 0;
            btnDocs.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnDocs.FlatStyle = FlatStyle.Flat;
            btnDocs.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDocs.ForeColor = Color.White;
            btnDocs.Image = Properties.Resources.documentos__2_;
            btnDocs.ImageAlign = ContentAlignment.MiddleLeft;
            btnDocs.Location = new Point(0, 449);
            btnDocs.Name = "btnDocs";
            btnDocs.Padding = new Padding(6, 0, 0, 0);
            btnDocs.Size = new Size(250, 45);
            btnDocs.TabIndex = 7;
            btnDocs.Text = "Documentos";
            btnDocs.UseVisualStyleBackColor = true;
            btnDocs.Click += btnDocs_Click;
            // 
            // btnHistorial
            // 
            btnHistorial.FlatAppearance.BorderSize = 0;
            btnHistorial.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnHistorial.FlatStyle = FlatStyle.Flat;
            btnHistorial.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHistorial.ForeColor = Color.White;
            btnHistorial.Image = Properties.Resources.historial_de_transacciones__1_;
            btnHistorial.ImageAlign = ContentAlignment.MiddleLeft;
            btnHistorial.Location = new Point(0, 398);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Padding = new Padding(8, 0, 0, 0);
            btnHistorial.Size = new Size(250, 45);
            btnHistorial.TabIndex = 6;
            btnHistorial.Text = "Historial";
            btnHistorial.UseVisualStyleBackColor = true;
            btnHistorial.Click += btnHistorial_Click;
            // 
            // btnCompras
            // 
            btnCompras.FlatAppearance.BorderSize = 0;
            btnCompras.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnCompras.FlatStyle = FlatStyle.Flat;
            btnCompras.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCompras.ForeColor = Color.White;
            btnCompras.Image = Properties.Resources.carrito_de_compras__1___1_;
            btnCompras.ImageAlign = ContentAlignment.MiddleLeft;
            btnCompras.Location = new Point(0, 347);
            btnCompras.Name = "btnCompras";
            btnCompras.Padding = new Padding(2, 0, 0, 0);
            btnCompras.Size = new Size(250, 45);
            btnCompras.TabIndex = 5;
            btnCompras.Text = "Compras";
            btnCompras.UseVisualStyleBackColor = true;
            btnCompras.Click += btnCompras_Click;
            // 
            // btnProveedores
            // 
            btnProveedores.FlatAppearance.BorderSize = 0;
            btnProveedores.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnProveedores.FlatStyle = FlatStyle.Flat;
            btnProveedores.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProveedores.ForeColor = Color.White;
            btnProveedores.Image = Properties.Resources.proveedor__2___1_;
            btnProveedores.ImageAlign = ContentAlignment.MiddleLeft;
            btnProveedores.Location = new Point(0, 296);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Padding = new Padding(6, 0, 0, 0);
            btnProveedores.Size = new Size(250, 45);
            btnProveedores.TabIndex = 4;
            btnProveedores.Text = "Proveedores";
            btnProveedores.UseVisualStyleBackColor = true;
            btnProveedores.Click += btnProveedores_Click;
            // 
            // btnClientes
            // 
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClientes.ForeColor = Color.White;
            btnClientes.Image = Properties.Resources.comentarios_de_los_clientes__2_;
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(0, 245);
            btnClientes.Name = "btnClientes";
            btnClientes.Padding = new Padding(8, 0, 0, 0);
            btnClientes.Size = new Size(250, 45);
            btnClientes.TabIndex = 3;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnVentas
            // 
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVentas.ForeColor = Color.White;
            btnVentas.Image = Properties.Resources.informe_de_venta__2_;
            btnVentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnVentas.Location = new Point(0, 194);
            btnVentas.Name = "btnVentas";
            btnVentas.Padding = new Padding(10, 0, 0, 0);
            btnVentas.Size = new Size(250, 45);
            btnVentas.TabIndex = 2;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnProductos
            // 
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProductos.ForeColor = Color.White;
            btnProductos.Image = Properties.Resources.nuevo_producto__1_;
            btnProductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductos.Location = new Point(0, 143);
            btnProductos.Name = "btnProductos";
            btnProductos.Padding = new Padding(6, 0, 0, 0);
            btnProductos.Size = new Size(250, 45);
            btnProductos.TabIndex = 1;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = Properties.Resources.Logo_restaurante_marino__2_;
            pictureBox2.Location = new Point(-134, -44);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(456, 211);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.FromArgb(42, 61, 116);
            BarraTitulo.Controls.Add(btnHome);
            BarraTitulo.Controls.Add(iconRestore);
            BarraTitulo.Controls.Add(iconMin);
            BarraTitulo.Controls.Add(iconMax);
            BarraTitulo.Controls.Add(iconCerrar);
            BarraTitulo.Controls.Add(btnSlide);
            BarraTitulo.Controls.Add(pictureBox1);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(70, 0);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(1074, 50);
            BarraTitulo.TabIndex = 1;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // btnHome
            // 
            btnHome.Image = Properties.Resources.casa__1_;
            btnHome.Location = new Point(46, 4);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(40, 40);
            btnHome.SizeMode = PictureBoxSizeMode.Zoom;
            btnHome.TabIndex = 6;
            btnHome.TabStop = false;
            btnHome.Click += btnHome_Click;
            // 
            // iconRestore
            // 
            iconRestore.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconRestore.Image = Properties.Resources.Restore_Down;
            iconRestore.Location = new Point(1006, 11);
            iconRestore.Name = "iconRestore";
            iconRestore.Size = new Size(25, 25);
            iconRestore.SizeMode = PictureBoxSizeMode.Zoom;
            iconRestore.TabIndex = 5;
            iconRestore.TabStop = false;
            iconRestore.Visible = false;
            iconRestore.Click += iconRestore_Click;
            // 
            // iconMin
            // 
            iconMin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconMin.Image = Properties.Resources.Subtract;
            iconMin.Location = new Point(975, 11);
            iconMin.Name = "iconMin";
            iconMin.Size = new Size(25, 25);
            iconMin.SizeMode = PictureBoxSizeMode.Zoom;
            iconMin.TabIndex = 4;
            iconMin.TabStop = false;
            iconMin.Click += iconMin_Click;
            // 
            // iconMax
            // 
            iconMax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconMax.Image = Properties.Resources.Full_Screen;
            iconMax.Location = new Point(1006, 11);
            iconMax.Name = "iconMax";
            iconMax.Size = new Size(25, 25);
            iconMax.SizeMode = PictureBoxSizeMode.Zoom;
            iconMax.TabIndex = 3;
            iconMax.TabStop = false;
            iconMax.Click += iconMax_Click;
            // 
            // iconCerrar
            // 
            iconCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconCerrar.Image = Properties.Resources.Close;
            iconCerrar.Location = new Point(1037, 11);
            iconCerrar.Name = "iconCerrar";
            iconCerrar.Size = new Size(25, 25);
            iconCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            iconCerrar.TabIndex = 2;
            iconCerrar.TabStop = false;
            iconCerrar.Click += iconCerrar_Click;
            // 
            // btnSlide
            // 
            btnSlide.Image = Properties.Resources.menu_desplegable;
            btnSlide.Location = new Point(10, 11);
            btnSlide.Name = "btnSlide";
            btnSlide.Size = new Size(30, 30);
            btnSlide.SizeMode = PictureBoxSizeMode.Zoom;
            btnSlide.TabIndex = 1;
            btnSlide.TabStop = false;
            btnSlide.Click += btnSlide_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(124, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelContenedor
            // 
            panelContenedor.Controls.Add(lblDate);
            panelContenedor.Controls.Add(lblClock);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(70, 50);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1074, 607);
            panelContenedor.TabIndex = 2;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.ForeColor = SystemColors.ActiveCaption;
            lblDate.Location = new Point(409, 297);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(254, 25);
            lblDate.TabIndex = 1;
            lblDate.Text = "viernes, 16 de agosto 2024.";
            // 
            // lblClock
            // 
            lblClock.AutoSize = true;
            lblClock.Font = new Font("Yu Gothic", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClock.ForeColor = SystemColors.ActiveBorder;
            lblClock.Location = new Point(385, 217);
            lblClock.Name = "lblClock";
            lblClock.Size = new Size(297, 82);
            lblClock.TabIndex = 0;
            lblClock.Text = "00:00:00";
            // 
            // timerSlide
            // 
            timerSlide.Tick += timerSlide_Tick;
            // 
            // timerClock
            // 
            timerClock.Interval = 1000;
            timerClock.Tick += timerClock_Tick;
            // 
            // timerFecha
            // 
            timerFecha.Interval = 1000;
            timerFecha.Tick += timerFecha_Tick;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 657);
            Controls.Add(panelContenedor);
            Controls.Add(BarraTitulo);
            Controls.Add(MenuVertical);
            Font = new Font("Segoe UI", 9.75F);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconRestore).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSlide).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelContenedor.ResumeLayout(false);
            panelContenedor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel MenuVertical;
        private Panel BarraTitulo;
        private PictureBox btnSlide;
        private PictureBox pictureBox1;
        private Panel panelContenedor;
        private PictureBox pictureBox2;
        private Button btnProductos;
        private Button btnHistorial;
        private Button btnCompras;
        private Button btnProveedores;
        private Button btnClientes;
        private Button btnVentas;
        private Button btnDocs;
        private PictureBox iconCerrar;
        private PictureBox iconMin;
        private PictureBox iconMax;
        private PictureBox iconRestore;
        private System.Windows.Forms.Timer timerSlide;
        private Label lblClock;
        private System.Windows.Forms.Timer timerClock;
        private Label lblDate;
        private System.Windows.Forms.Timer timerFecha;
        private PictureBox btnHome;
    }
}