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
    public partial class Login : Form
    {
        public string Usuario { get; private set; }
        public string Contraseña { get; private set; }

        public Login()
        {
            InitializeComponent();
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
            Usuario = txtUsuario.Text;
            Contraseña = txtContraseña.Text;

            
            if (ValidarAcceso(Usuario, Contraseña))
            {
                
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private bool ValidarAcceso(string usuario, string contraseña)
        {
            
            return usuario == "admin" && contraseña == "1234"; 
        }
    }
}
