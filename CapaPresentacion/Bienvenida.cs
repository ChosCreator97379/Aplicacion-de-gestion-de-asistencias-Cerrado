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
            Administrador Administrador_E_S = new Administrador();
            Administrador_E_S.Show();
        }
    }
}
