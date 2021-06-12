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

        public SolicitacaoModel(int idSolicitacao)
        {
            this.idSolicitacao = idSolicitacao;
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

        public SolicitacaoModel(int idSolicitacao, FuncionarioModel funcionario, string status, string resposta)
        {
            this.idSolicitacao = idSolicitacao;
            this.funcionario = funcionario;
            this.status = status;
            this.resposta = resposta;
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

        public List<SolicitacaoModel> ListarSolicitacoes(String pesquisa, String status, Boolean minhasSolicitacoes)
        {
            List<SolicitacaoModel> solicitacoes = new List<SolicitacaoModel>();

            MySqlConnection con = DbConnection.getConnection();
            String query = "SELECT * FROM view_solicitacoes";

            query += pesquisa == "" && (status == "Todas" || status == "") && !minhasSolicitacoes ? "" : " WHERE ";

            query += pesquisa != "" ? "nome_aluno LIKE '%" + pesquisa + "%'" : "";

            query += pesquisa != "" && (status != "Todas" && status != "") ? " AND " : "";

            query += status == "Pendentes" ? "status = 'Pendente'" : "";
            query += status == "Aprovadas" ? "status = 'Aprovado'" : "";
            query += status == "Rejeitadas"? "status = 'Rejeitado'" : "";

            query += pesquisa != "" && minhasSolicitacoes || (status != "Todas" && status != "") && minhasSolicitacoes ? " AND " : "";

            query += minhasSolicitacoes ? "id_funcionario = ?id_funcionario" : "";

            query += " ORDER BY data_solicitacao DESC";

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);

                if (minhasSolicitacoes)
                    cmd.Parameters.Add("?id_funcionario", MySqlDbType.Int32).Value = Funcionario.IdFuncionario;

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
                        solicitacao.Aluno.CursoMatriculado = mysqlDR["curso_matriculado"].ToString();
                        solicitacao.Aluno.Contato = mysqlDR["aluno_contato"].ToString();

                        solicitacao.Funcionario = new FuncionarioModel();
                        solicitacao.Funcionario.Nome = mysqlDR["nome_funcionario"] != DBNull.Value ? mysqlDR["nome_funcionario"].ToString() : null;

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
                cmd.Parameters.Add("?data_solicitacao", MySqlDbType.DateTime).Value = DataSolicitacao;
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

        public Boolean ResponderSolicitacao()
        {
            MySqlConnection con = DbConnection.getConnection();
            String query = "UPDATE tb_solicitacoes SET status = ?status, resposta = ?resposta, id_funcionario = ?id_funcionario WHERE id_solicitacao = ?id_solicitacao";

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.Add("?status", MySqlDbType.VarChar).Value = Status;
                cmd.Parameters.Add("?resposta", MySqlDbType.VarChar).Value = Resposta;
                cmd.Parameters.Add("?id_funcionario", MySqlDbType.Int32).Value = Funcionario.IdFuncionario;
                cmd.Parameters.Add("?id_solicitacao", MySqlDbType.Int32).Value = IdSolicitacao;
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                return true;
            }
            catch
            {
                MessageBox.Show("Não foi possível responder à solicitação, tente novamente mais tarde", "Erro ao responder solicitação",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public Boolean ExcluirSolicitacao()
        {
            MySqlConnection con = DbConnection.getConnection();
            String query = "DELETE FROM tb_solicitacoes WHERE id_solicitacao = ?id_solicitacao";

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.Add("?id_solicitacao", MySqlDbType.Int32).Value = IdSolicitacao;
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                return true;
            }
            catch
            {
                MessageBox.Show("Não foi possível excluir a solicitação, tente novamente mais tarde", "Erro ao excluir solicitação",
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
