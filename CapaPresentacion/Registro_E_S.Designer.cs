namespace CapaPresentacion
{
    partial class Registro_E_S
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
            menuStrip1 = new MenuStrip();
            gestionPersonalToolStripMenuItem = new ToolStripMenuItem();
            listaDeEntradaYSalidaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { gestionPersonalToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1370, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // gestionPersonalToolStripMenuItem
            // 
            gestionPersonalToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listaDeEntradaYSalidaToolStripMenuItem });
            gestionPersonalToolStripMenuItem.Name = "gestionPersonalToolStripMenuItem";
            gestionPersonalToolStripMenuItem.Size = new Size(60, 20);
            gestionPersonalToolStripMenuItem.Text = "Archivo";
            gestionPersonalToolStripMenuItem.Click += gestionPersonalToolStripMenuItem_Click;
            // 
            // listaDeEntradaYSalidaToolStripMenuItem
            // 
            listaDeEntradaYSalidaToolStripMenuItem.Name = "listaDeEntradaYSalidaToolStripMenuItem";
            listaDeEntradaYSalidaToolStripMenuItem.Size = new Size(200, 22);
            listaDeEntradaYSalidaToolStripMenuItem.Text = "Lista de Entrada y Salida";
            // 
            // Registro_E_S
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1370, 749);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Registro_E_S";
            Text = "Registro_E_S";
            WindowState = FormWindowState.Maximized;
            Load += Registro_E_S_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem gestionPersonalToolStripMenuItem;
        private ToolStripMenuItem listaDeEntradaYSalidaToolStripMenuItem;
    }
}