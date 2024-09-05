namespace CapaPresentacion
{
    partial class Administrador
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
            administradorToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            listBox1 = new ListBox();
            button2 = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { administradorToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(15, 4, 0, 4);
            menuStrip1.Size = new Size(1371, 27);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // administradorToolStripMenuItem
            // 
            administradorToolStripMenuItem.Name = "administradorToolStripMenuItem";
            administradorToolStripMenuItem.Size = new Size(95, 19);
            administradorToolStripMenuItem.Text = "Administrador";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(185, 256);
            dataGridView1.Margin = new Padding(7, 6, 7, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(999, 342);
            dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(480, 116);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(412, 32);
            label1.TabIndex = 2;
            label1.Text = "Lista de hora de entrada y salida";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(411, 187);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(602, 41);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(1055, 187);
            button1.Name = "button1";
            button1.Size = new Size(129, 40);
            button1.TabIndex = 4;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 32;
            listBox1.Items.AddRange(new object[] { "Buscar por:", "ID" });
            listBox1.Location = new Point(185, 192);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(198, 36);
            listBox1.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(1055, 633);
            button2.Name = "button2";
            button2.Size = new Size(129, 43);
            button2.TabIndex = 6;
            button2.Text = "Cerrar";
            button2.UseVisualStyleBackColor = true;
            // 
            // Administrador
            // 
            AutoScaleDimensions = new SizeF(17F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 748);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(7, 6, 7, 6);
            Name = "Administrador";
            Text = "Administrador";
            WindowState = FormWindowState.Maximized;
            Load += Administrador_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem administradorToolStripMenuItem;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private ListBox listBox1;
        private Button button2;
    }
}