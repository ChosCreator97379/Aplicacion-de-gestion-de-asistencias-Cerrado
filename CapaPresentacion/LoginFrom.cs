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
    public partial class LoginFrom : Form
    {
        public string Usuario { get; private set; }
        public string Contraseña { get; private set; }

        public LoginFrom()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click_Click(object sender, EventArgs e)
        {
            
            Usuario = textBox1.Text;
            Contraseña = textBox2.Text;

            
            if (ValidarAcceso(Usuario, Contraseña))
            {
                MessageBox.Show("Acceso concedido");
                this.DialogResult = DialogResult.OK;  
                this.Close();  
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }

        private void btnCancelar_Click_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();  
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private bool ValidarAcceso(string usuario, string contraseña)
        {
            
            return usuario == "admin" && contraseña == "1234";  
        }
    }
}
