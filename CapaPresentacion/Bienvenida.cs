using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Bienvenida : Form
    {
        public Bienvenida()
        {
            InitializeComponent();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void registroDeEntradaYSalidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro_E_S Registro_E_S = new Registro_E_S();
            Registro_E_S.Show();
        }

        private void administradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario de login
            Login loginForm = new Login();

            // Mostrar el formulario de login como un cuadro de diálogo modal
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                // Si el acceso fue exitoso, abrir la ventana Administrador
                Administrador administradorForm = new Administrador();
                administradorForm.Show(); // Mostrar la ventana de lista de asistencia
            }
            else
            {
                // Si el acceso fue denegado o cancelado
                MessageBox.Show("Acceso denegado.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
