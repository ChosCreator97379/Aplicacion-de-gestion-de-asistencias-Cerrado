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
            textBox1 = new TextBox();
            button1 = new Button();
            listBox1 = new ListBox();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            button3 = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
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
            dataGridView1.Location = new Point(33, 99);
            dataGridView1.Margin = new Padding(7, 6, 7, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1295, 371);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(241, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(615, 41);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(884, 39);
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
            listBox1.Location = new Point(33, 40);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(188, 36);
            listBox1.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(1199, 39);
            button2.Name = "button2";
            button2.Size = new Size(129, 39);
            button2.TabIndex = 6;
            button2.Text = "Cerrar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(55, 40);
            button4.Name = "button4";
            button4.Size = new Size(129, 43);
            button4.TabIndex = 8;
            button4.Text = "Añadir";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(50, 40);
            button5.Name = "button5";
            button5.Size = new Size(129, 42);
            button5.TabIndex = 9;
            button5.Text = "Editar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(listBox1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(12, 257);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1347, 479);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(button5);
            groupBox2.Location = new Point(12, 43);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(677, 208);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Editar";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox5);
            groupBox3.Controls.Add(textBox6);
            groupBox3.Controls.Add(textBox7);
            groupBox3.Controls.Add(button4);
            groupBox3.Location = new Point(695, 43);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(664, 208);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Añadir";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(241, 40);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(355, 41);
            textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(241, 134);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(355, 41);
            textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(241, 87);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(355, 41);
            textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(244, 89);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(355, 41);
            textBox5.TabIndex = 15;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(244, 136);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(355, 41);
            textBox6.TabIndex = 14;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(244, 42);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(355, 41);
            textBox7.TabIndex = 13;
            // 
            // button3
            // 
            button3.Location = new Point(1041, 40);
            button3.Name = "button3";
            button3.Size = new Size(132, 40);
            button3.TabIndex = 7;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            // 
            // Administrador
            // 
            AutoScaleDimensions = new SizeF(17F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1371, 748);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
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
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem administradorToolStripMenuItem;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button button1;
        private ListBox listBox1;
        private Button button2;
        private Button button4;
        private Button button5;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button button3;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
    }
}