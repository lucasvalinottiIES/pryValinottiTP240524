using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryValinottiTP240524
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void cmdRegistrarse_Click(object sender, EventArgs e)
        {
            clsUsuario usuario = new clsUsuario();
            usuario.Nombre = txtUsuario.Text;
            usuario.Perfil = cbPerfil.Text;
            usuario.Password = txtPassword.Text;
            if (usuario.registrarUsuario(usuario))
            {
                frmReportes frm = new frmReportes(usuario.Nombre);
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
        }
    }
}
