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
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            registroDeEntradasYSalidasToolStripMenuItem = new ToolStripMenuItem();
            listaDeAsistenciasToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(377, 125);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem });
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
            // Bienvenida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Bienvenida";
            Text = " ";
            WindowState = FormWindowState.Maximized;
            Load += Bienvenida_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem registroDeEntradasYSalidasToolStripMenuItem;
        private ToolStripMenuItem listaDeAsistenciasToolStripMenuItem;
    }
}
