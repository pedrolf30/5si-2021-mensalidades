using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gerenciamento_de_mensalidades.Controller;
using gerenciamento_de_mensalidades.Model;

namespace gerenciamento_de_mensalidades.View.Aluno
{
    public partial class CadastroAluno : Form
    {
        UsuarioModel currentUser;
        public CadastroAluno(UsuarioModel usuario)
        {
            InitializeComponent();
            currentUser = usuario;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
