namespace CapaPresentacion
{
    public partial class Bienvenida : Form
    {
        public Bienvenida()
        {
            InitializeComponent();
        }

        private void Bienvenida_Load(object sender, EventArgs e)
        {

        }

        private void registroDeEntradasYSalidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro_E_S Registro_E_S = new Registro_E_S();
            Registro_E_S.Show();
        }

        private void listaDeAsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            LoginFrom loginForm = new LoginFrom();

            
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
               
                Administrador administrador = new Administrador();
                administrador.Show(); 
            }
            else
            {
                
                MessageBox.Show("Acceso denegado.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void administracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        
        }
    }
}
