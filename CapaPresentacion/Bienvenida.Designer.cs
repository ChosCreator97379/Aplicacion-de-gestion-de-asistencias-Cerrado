namespace CapaPresentacion
{
    partial class Bienvenida
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            registroDeEntradasYSalidasToolStripMenuItem = new ToolStripMenuItem();
            listaDeAsistenciasToolStripMenuItem = new ToolStripMenuItem();
            administracionToolStripMenuItem = new ToolStripMenuItem();
            listaDeAsistenciaToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveBorder;
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, administracionToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1370, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registroDeEntradasYSalidasToolStripMenuItem, listaDeAsistenciasToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // registroDeEntradasYSalidasToolStripMenuItem
            // 
            registroDeEntradasYSalidasToolStripMenuItem.Name = "registroDeEntradasYSalidasToolStripMenuItem";
            registroDeEntradasYSalidasToolStripMenuItem.Size = new Size(229, 22);
            registroDeEntradasYSalidasToolStripMenuItem.Text = "Registro de Entradas y Salidas";
            registroDeEntradasYSalidasToolStripMenuItem.Click += registroDeEntradasYSalidasToolStripMenuItem_Click;
            // 
            // listaDeAsistenciasToolStripMenuItem
            // 
            listaDeAsistenciasToolStripMenuItem.Name = "listaDeAsistenciasToolStripMenuItem";
            listaDeAsistenciasToolStripMenuItem.Size = new Size(229, 22);
            listaDeAsistenciasToolStripMenuItem.Text = "Lista de Asistencias";
            // 
            // administracionToolStripMenuItem
            // 
            administracionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listaDeAsistenciaToolStripMenuItem });
            administracionToolStripMenuItem.Name = "administracionToolStripMenuItem";
            administracionToolStripMenuItem.Size = new Size(95, 20);
            administracionToolStripMenuItem.Text = "Administrador";
            // 
            // listaDeAsistenciaToolStripMenuItem
            // 
            listaDeAsistenciaToolStripMenuItem.Name = "listaDeAsistenciaToolStripMenuItem";
            listaDeAsistenciaToolStripMenuItem.Size = new Size(180, 22);
            listaDeAsistenciaToolStripMenuItem.Text = "Lista de Asistencia";
            listaDeAsistenciaToolStripMenuItem.Click += listaDeAsistenciaToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(245, 121);
            label1.Name = "label1";
            label1.Size = new Size(862, 55);
            label1.TabIndex = 2;
            label1.Text = "Bienvenido al Software de Administacion";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.yu;
            pictureBox1.Location = new Point(546, 244);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(319, 307);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Bienvenida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1370, 749);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Bienvenida";
            Text = " ";
            WindowState = FormWindowState.Maximized;
            Load += Bienvenida_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem registroDeEntradasYSalidasToolStripMenuItem;
        private ToolStripMenuItem listaDeAsistenciasToolStripMenuItem;
        private Label label1;
        private PictureBox pictureBox1;
        private ToolStripMenuItem administracionToolStripMenuItem;
        private ToolStripMenuItem listaDeAsistenciaToolStripMenuItem;
    }
}
