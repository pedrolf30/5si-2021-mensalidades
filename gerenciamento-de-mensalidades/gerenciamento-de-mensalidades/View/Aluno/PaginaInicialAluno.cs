using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gerenciamento_de_mensalidades.View.Aluno
{
    public partial class PaginaInicialAluno : Form
    {
        public PaginaInicialAluno()
        {
            InitializeComponent();
        }

        private void btnMeuPerfil_Click(object sender, EventArgs e)
        {
            PerfilAluno perfilAluno = new PerfilAluno();
            perfilAluno.Show();
            this.Visible = false;
        }

        private void btnMinhasMensalidades_Click(object sender, EventArgs e)
        {
            MensalidadesAluno mensalidadesAluno = new MensalidadesAluno();
            mensalidadesAluno.Show();
            this.Visible = false;
        }

        private void btnSolicitacoes_Click(object sender, EventArgs e)
        {
            SolicitacoesAluno solicitacoesAluno = new SolicitacoesAluno();
            solicitacoesAluno.Show();
            this.Visible = false;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Login sairParaLogin = new Login();
            sairParaLogin.Show();
            this.Visible = false;
        }
    }
}
