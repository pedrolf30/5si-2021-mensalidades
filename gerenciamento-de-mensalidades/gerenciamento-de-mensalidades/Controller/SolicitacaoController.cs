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
        public List<SolicitacaoModel> ListarSolicitacoes(String pesquisa, String status, Boolean minhasSolicitacoes, Int32 idFuncionario = 0)
        {
            SolicitacaoModel solicitacao = new SolicitacaoModel();
            solicitacao.Funcionario.IdFuncionario = idFuncionario;
            return solicitacao.ListarSolicitacoes(pesquisa, status, minhasSolicitacoes);
        }

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

        public Boolean ResponderSolicitacao(String status, String resposta, FuncionarioModel atendente, Int32 idSolicitacao)
        {
            SolicitacaoModel solicitacao = new SolicitacaoModel(idSolicitacao, atendente, status, resposta);
            return solicitacao.ResponderSolicitacao();
        }

        public Boolean ExcluirSolicitacao(Int32 idSolicitacao)
        {
            SolicitacaoModel solicitacao = new SolicitacaoModel(idSolicitacao);
            return solicitacao.ExcluirSolicitacao();
        }
    }
}
