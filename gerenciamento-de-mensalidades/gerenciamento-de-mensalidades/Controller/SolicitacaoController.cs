using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gerenciamento_de_mensalidades.Model;

namespace gerenciamento_de_mensalidades.Controller
{
    class SolicitacaoController
    {
        public List<SolicitacaoModel> ListarSolicitacoesAluno(String status, Int32 idAluno)
        {
            SolicitacaoModel solicitacao = new SolicitacaoModel();
            solicitacao.Aluno.IdAluno = idAluno;
            return solicitacao.ListarSolicitacoesAluno(status);
        }

        public Boolean EnviarSolicitacao(Int32 idAluno, String categoria, String descricao, DateTime dataSolicitacao, String status)
        {
            SolicitacaoModel solicitacao = new SolicitacaoModel(idAluno, categoria, descricao, dataSolicitacao, status);
            return solicitacao.EnviarSolicitacao();
        }
    }
}
