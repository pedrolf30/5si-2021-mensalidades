using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gerenciamento_de_mensalidades.Enum;
using gerenciamento_de_mensalidades.Connection;
using MySql.Data.MySqlClient;

namespace gerenciamento_de_mensalidades.Model
{
    class SolicitacaoModel
    {
        private Int32 idSolicitacao;
        private AlunoModel aluno;
        private FuncionarioModel funcionario;
        private String categoria;
        private String descricao;
        private DateTime dataSolicitacao;
        private String status;
        private String resposta;

        public SolicitacaoModel()
        {
            this.aluno = new AlunoModel();
            this.funcionario = new FuncionarioModel();
        }

        public SolicitacaoModel(int idAluno, string categoria, string descricao, DateTime dataSolicitacao, string status)
        {
            this.aluno = new AlunoModel();
            this.aluno.IdAluno = idAluno;
            this.categoria = categoria;
            this.descricao = descricao;
            this.dataSolicitacao = dataSolicitacao;
            this.status = status;
        }

        public int IdSolicitacao { get => idSolicitacao; set => idSolicitacao = value; }
        public AlunoModel Aluno { get => aluno; set => aluno = value; }
        internal FuncionarioModel Funcionario { get => funcionario; set => funcionario = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public DateTime DataSolicitacao { get => dataSolicitacao; set => dataSolicitacao = value; }
        public string Status { get => status; set => status = value; }
        public string Resposta { get => resposta; set => resposta = value; }

        public List<SolicitacaoModel> ListarSolicitacoesAluno(String status)
        {
            List<SolicitacaoModel> solicitacoes = new List<SolicitacaoModel>();

            MySqlConnection con = DbConnection.getConnection();
            String query = "SELECT * FROM view_solicitacoes WHERE id_aluno = ?id_aluno ORDER BY data_solicitacao DESC";

            if (status == "Pendentes")
            {
                query = "SELECT * FROM view_solicitacoes WHERE id_aluno = ?id_aluno AND status = 'Pendente' ORDER BY data_solicitacao DESC";
            }
            else if (status == "Aprovadas")
            {
                query = "SELECT * FROM view_solicitacoes WHERE id_aluno = ?id_aluno AND status = 'Aprovado' ORDER BY data_solicitacao DESC";
            }
            else if (status == "Rejeitadas")
            {
                query = "SELECT * FROM view_solicitacoes WHERE id_aluno = ?id_aluno AND status = 'Rejeitado' ORDER BY data_solicitacao DESC";
            }

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.Add("?id_aluno", MySqlDbType.Int32).Value = Aluno.IdAluno;

                MySqlDataReader mysqlDR = cmd.ExecuteReader();

                if (mysqlDR != null)
                    while (mysqlDR.Read())
                    {
                        SolicitacaoModel solicitacao = new SolicitacaoModel();
                        solicitacao.Categoria = mysqlDR["categoria"].ToString();
                        solicitacao.Descricao = mysqlDR["descricao"].ToString();
                        solicitacao.DataSolicitacao = Convert.ToDateTime(mysqlDR["data_solicitacao"]);
                        solicitacao.Status = mysqlDR["status"].ToString();
                        solicitacao.Resposta = mysqlDR["resposta"] != DBNull.Value ? mysqlDR["resposta"].ToString() : null;

                        solicitacao.Funcionario = new FuncionarioModel();
                        solicitacao.Funcionario.Nome = mysqlDR["nome_funcionario"] != DBNull.Value ? mysqlDR["nome_funcionario"].ToString() : null;

                        solicitacoes.Add(solicitacao);
                    }

                return solicitacoes;
            }
            catch
            {
                MessageBox.Show("Falha ao listar solicitações do aluno, tente novamente mais tarde", "Erro na conexão com o servidor",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return solicitacoes;
            }
            finally
            {
                con.Close();
            }
        }

        public List<SolicitacaoModel> ListarSolicitacoes()
        {
            List<SolicitacaoModel> solicitacoes = new List<SolicitacaoModel>();

            MySqlConnection con = DbConnection.getConnection();
            String query = "SELECT * FROM tb_solicitacoes WHERE id_aluno = ?id_aluno";

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);


                MySqlDataReader mysqlDR = cmd.ExecuteReader();

                if (mysqlDR != null)
                    while (mysqlDR.Read())
                    {
                        SolicitacaoModel solicitacao = new SolicitacaoModel();
                        solicitacao.IdSolicitacao = Convert.ToInt32(mysqlDR["id_solicitacao"]);
                        solicitacao.Categoria = mysqlDR["categoria"].ToString();
                        solicitacao.Descricao = mysqlDR["descricao"].ToString();
                        solicitacao.DataSolicitacao = Convert.ToDateTime(mysqlDR["data_solicitacao"]);
                        solicitacao.Status = mysqlDR["status"].ToString();
                        solicitacao.Resposta = mysqlDR["resposta"].ToString();

                        solicitacao.Aluno = new AlunoModel();
                        solicitacao.Aluno.IdAluno = Convert.ToInt32(mysqlDR["id_aluno"]);
                        solicitacao.Aluno.Nome = mysqlDR["nome_aluno"].ToString();
                        solicitacao.Aluno.RA = Convert.ToInt32(mysqlDR["RA"]);
                        solicitacao.Aluno.DataNascimento = Convert.ToDateTime(mysqlDR["aluno_nascimento"]);
                        solicitacao.Aluno.CPF = mysqlDR["aluno_CPF"].ToString();
                        solicitacao.Aluno.CursoMatriculado = mysqlDR["curso_matriculado"].ToString();
                        solicitacao.Aluno.Contato = mysqlDR["aluno_contato"].ToString();

                        solicitacao.Funcionario = new FuncionarioModel();
                        solicitacao.Funcionario.IdFuncionario = mysqlDR["id_funcionario"] != DBNull.Value ? Convert.ToInt32(mysqlDR["id_funcionario"]) : 0;
                        solicitacao.Funcionario.Nome = mysqlDR["nome_funcionario"].ToString();
                        solicitacao.Funcionario.CPF = mysqlDR["funcionario_CPF"].ToString();
                        solicitacao.Funcionario.Contato = mysqlDR["funcionario_contato"].ToString();

                        if (mysqlDR["funcionario_nascimento"] != DBNull.Value)
                            solicitacao.Funcionario.DataNascimento = Convert.ToDateTime(mysqlDR["funcionario_nascimento"]);

                        solicitacoes.Add(solicitacao);
                    }

                return solicitacoes;
            }
            catch
            {
                MessageBox.Show("Falha ao listar solicitações, tente novamente mais tarde", "Erro na conexão com o servidor",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return solicitacoes;
            }
            finally
            {
                con.Close();
            }
        }

        public Boolean EnviarSolicitacao()
        {
            MySqlConnection con = DbConnection.getConnection();
            String query = "INSERT INTO tb_solicitacoes(id_aluno, categoria, descricao, data_solicitacao, status) " +
                           "VALUES (?id_aluno, ?categoria, ?descricao, ?data_solicitacao, ?status)";

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.Add("?id_aluno", MySqlDbType.Int32).Value = Aluno.IdAluno;
                cmd.Parameters.Add("?categoria", MySqlDbType.VarChar).Value = Categoria;
                cmd.Parameters.Add("?descricao", MySqlDbType.VarChar).Value = Descricao;
                cmd.Parameters.Add("?data_solicitacao", MySqlDbType.Date).Value = DataSolicitacao;
                cmd.Parameters.Add("?status", MySqlDbType.VarChar).Value = Status;
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                return true;
            }
            catch
            {
                MessageBox.Show("Não foi possível finalizar a solicitação, tente novamente mais tarde", "Erro ao enviar solicitação",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
