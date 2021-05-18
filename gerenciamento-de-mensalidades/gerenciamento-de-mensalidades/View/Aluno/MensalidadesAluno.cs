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
    public partial class MensalidadesAluno : Form
    {
        public MensalidadesAluno()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            PaginaInicialAluno paginaInicialAluno = new PaginaInicialAluno();
            paginaInicialAluno.Show();
            this.Visible = false;
        }
    }
}
