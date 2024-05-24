namespace pryValinottiTP240524
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void cmdRegistrarse_Click(object sender, EventArgs e)
        {
            frmRegistro frm = new frmRegistro();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void cmdIniciar_Click(object sender, EventArgs e)
        {
            clsUsuario usuario = new clsUsuario();
            bool estadoConexion = usuario.ValidarUsuario(txtUsuario.Text, txtPassword.Text);
            if (estadoConexion)
            {
                usuario.RegistroLogInicioSesion();
                frmReportes frm = new frmReportes(txtUsuario.Text);
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
        }
    }
}
