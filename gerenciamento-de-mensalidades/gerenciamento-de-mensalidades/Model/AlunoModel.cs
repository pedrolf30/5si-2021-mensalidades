using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using gerenciamento_de_mensalidades.Connection;
using gerenciamento_de_mensalidades.Enum;

namespace gerenciamento_de_mensalidades.Model
{
    public class AlunoModel : UsuarioModel
    {
        private Int32 idAluno;
        private String nome;
        private Int32 ra;
        private DateTime dataNascimento;
        private String cpf;
        private String cursoMatriculado;
        private String contato;

        public AlunoModel() { }

        public AlunoModel(int ra)
        {
            this.ra = ra;
        }

        public AlunoModel(int idUsuario, int ra)
        {
            IdUsuario = idUsuario;
            this.ra = ra;
        }

        public AlunoModel(string nome, int ra, DateTime dataNascimento, string cpf, string cursoMatriculado, string contato)
        {
            this.nome = nome;
            this.ra = ra;
            this.dataNascimento = dataNascimento;
            this.cpf = cpf;
            this.cursoMatriculado = cursoMatriculado;
            this.contato = contato;
        }

        public AlunoModel(int idUsuario, string nome, int ra, DateTime dataNascimento, string cpf, string cursoMatriculado, string contato)
        {
            IdUsuario = idUsuario;
            this.nome = nome;
            this.ra = ra;
            this.dataNascimento = dataNascimento;
            this.cpf = cpf;
            this.cursoMatriculado = cursoMatriculado;
            this.contato = contato;
        }

        public int IdAluno { get => idAluno; set => idAluno = value; }
        public string Nome { get => nome; set => nome = value; }
        public int RA { get => ra; set => ra = value; }
        public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }
        public string CPF { get => cpf; set => cpf = value; }
        public string CursoMatriculado { get => cursoMatriculado; set => cursoMatriculado = value; }
        public string Contato { get => contato; set => contato = value; }

        public List<AlunoModel> ListarAlunos(String pesquisa, String curso)
        {
            List<AlunoModel> alunos = new List<AlunoModel>();

            MySqlConnection con = DbConnection.getConnection();
            String query = "SELECT * FROM tb_alunos";

            query += pesquisa == "" && (curso == "Todos os Cursos" || curso == "") ? "" : " WHERE ";

            query += pesquisa != "" ? "nome_completo LIKE ?nome_completo OR RA LIKE ?RA" : "";

            query += pesquisa != "" && (curso != "Todos os Cursos" && curso != "") ? " AND " : "";

            query += curso != "Todos os Cursos" && curso != "" ? "curso_matriculado = ?curso_matriculado" : "";

            query += " ORDER BY nome_completo";

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);

                if (pesquisa != "")
                {
                    cmd.Parameters.Add("?nome_completo", MySqlDbType.VarChar).Value = "%" + pesquisa + "%";
                    cmd.Parameters.Add("?RA", MySqlDbType.VarChar).Value = "%" + pesquisa + "%";
                }

                if (curso != "Todos os Cursos" && curso != "")
                    cmd.Parameters.Add("?curso_matriculado", MySqlDbType.VarChar).Value = curso;

                MySqlDataReader mysqlDR = cmd.ExecuteReader();

                if (mysqlDR != null)
                    while (mysqlDR.Read())
                    {
                        AlunoModel aluno = new AlunoModel();
                        aluno.IdAluno = Convert.ToInt32(mysqlDR["id_aluno"]);
                        aluno.Nome = mysqlDR["nome_completo"].ToString();
                        aluno.RA = Convert.ToInt32(mysqlDR["RA"]);
                        aluno.DataNascimento = Convert.ToDateTime(mysqlDR["data_nascimento"]);
                        aluno.CPF = mysqlDR["CPF"].ToString();
                        aluno.CursoMatriculado = mysqlDR["curso_matriculado"].ToString();
                        aluno.Contato = mysqlDR["contato"].ToString();
                        aluno.TipoUsuario = TipoUsuario.Aluno;
                        aluno.IdUsuario = mysqlDR["id_usuario"] != DBNull.Value ? Convert.ToInt32(mysqlDR["id_usuario"]) : 0;
                        alunos.Add(aluno);
                    }

                return alunos;
            }
            catch (Exception e)
            {
                MessageBox.Show("Falha ao listar alunos, tente novamente mais tarde\n"+e, "Erro na conexão com o servidor",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return alunos;
            }
            finally
            {
                con.Close();
            }
        }

        public AlunoModel BuscarAlunoPorRA()
        {
            AlunoModel aluno = new AlunoModel();

            MySqlConnection con = DbConnection.getConnection();
            String query = "SELECT * FROM tb_alunos WHERE RA = ?RA";

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.Add("?RA", MySqlDbType.Int32).Value = RA;

                MySqlDataReader mysqlDR = cmd.ExecuteReader();

                if (mysqlDR.Read())
                {
                    aluno.IdAluno = Convert.ToInt32(mysqlDR["id_aluno"]);
                    aluno.Nome = mysqlDR["nome_completo"].ToString();
                    aluno.RA = Convert.ToInt32(mysqlDR["RA"]);
                    aluno.DataNascimento = Convert.ToDateTime(mysqlDR["data_nascimento"]);
                    aluno.CPF = mysqlDR["CPF"].ToString();
                    aluno.CursoMatriculado = mysqlDR["curso_matriculado"].ToString();
                    aluno.Contato = mysqlDR["contato"].ToString();
                    aluno.TipoUsuario = TipoUsuario.Aluno;
                    aluno.IdUsuario = mysqlDR["id_usuario"] != DBNull.Value ? Convert.ToInt32(mysqlDR["id_usuario"]) : 0;
                    return aluno;
                }
                else
                {
                    aluno.TipoUsuario = TipoUsuario.Undefined;
                    return aluno;
                }
            }
            catch
            {
                MessageBox.Show("Falha ao buscar aluno, tente novamente mais tarde", "Erro de busca",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                aluno.TipoUsuario = TipoUsuario.Undefined;
                return aluno;
            }
            finally
            {
                con.Close();
            }
        }

        public AlunoModel BuscarAlunoPorIdUsuario()
        {
            AlunoModel aluno = new AlunoModel();

            MySqlConnection con = DbConnection.getConnection();
            String query = "SELECT * FROM tb_alunos WHERE id_usuario = ?id_usuario";

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.Add("?id_usuario", MySqlDbType.Int32).Value = IdUsuario;

                MySqlDataReader mysqlDR = cmd.ExecuteReader();

                if (mysqlDR.Read())
                {
                    aluno.IdAluno = Convert.ToInt32(mysqlDR["id_aluno"]);
                    aluno.Nome = mysqlDR["nome_completo"].ToString();
                    aluno.RA = Convert.ToInt32(mysqlDR["RA"]);
                    aluno.DataNascimento = Convert.ToDateTime(mysqlDR["data_nascimento"]);
                    aluno.CPF = mysqlDR["CPF"].ToString();
                    aluno.CursoMatriculado = mysqlDR["curso_matriculado"].ToString();
                    aluno.Contato = mysqlDR["contato"].ToString();
                    aluno.TipoUsuario = TipoUsuario.Aluno;
                    return aluno;
                }
                else
                {
                    aluno.TipoUsuario = TipoUsuario.Undefined;
                    return aluno;
                }
            }
            catch
            {
                MessageBox.Show("Falha ao buscar aluno, tente novamente mais tarde", "Erro de busca",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                aluno.TipoUsuario = TipoUsuario.Undefined;
                return aluno;
            }
            finally
            {
                con.Close();
            }
        }

        public Boolean CadastrarAluno()
        {
            MySqlConnection con = DbConnection.getConnection();
            String query = "INSERT INTO tb_alunos(nome_completo, RA, data_nascimento, CPF, curso_matriculado, contato) " +
                           "VALUES (?nome_completo, ?RA, ?data_nascimento, ?CPF, ?curso_matriculado, ?contato)";

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.Add("?nome_completo", MySqlDbType.VarChar).Value = Nome;
                cmd.Parameters.Add("?RA", MySqlDbType.Int32).Value = RA;
                cmd.Parameters.Add("?data_nascimento", MySqlDbType.Date).Value = DataNascimento.Date;
                cmd.Parameters.Add("?CPF", MySqlDbType.VarChar).Value = CPF;
                cmd.Parameters.Add("?curso_matriculado", MySqlDbType.VarChar).Value = CursoMatriculado;
                cmd.Parameters.Add("?contato", MySqlDbType.VarChar).Value = Contato;
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                return true;
            }
            catch
            {
                MessageBox.Show("Não foi possível finalizar o seu cadastro, tente novamente mais tarde", "Erro ao cadastrar",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public Boolean AtualizarAluno()
        {
            MySqlConnection con = DbConnection.getConnection();
            String query = "UPDATE tb_alunos SET nome_completo = ?nome_completo, RA = ?RA, data_nascimento = ?data_nascimento, CPF = ?CPF, " +
                           "curso_matriculado = ?curso_matriculado, contato = ?contato WHERE id_usuario = ?id_usuario";

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.Add("?nome_completo", MySqlDbType.VarChar).Value = Nome;
                cmd.Parameters.Add("?RA", MySqlDbType.Int32).Value = RA;
                cmd.Parameters.Add("?data_nascimento", MySqlDbType.Date).Value = DataNascimento.Date;
                cmd.Parameters.Add("?CPF", MySqlDbType.VarChar).Value = CPF;
                cmd.Parameters.Add("?curso_matriculado", MySqlDbType.VarChar).Value = CursoMatriculado;
                cmd.Parameters.Add("?contato", MySqlDbType.VarChar).Value = Contato;
                cmd.Parameters.Add("?id_usuario", MySqlDbType.Int32).Value = IdUsuario;
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                return true;
            }
            catch
            {
                MessageBox.Show("Não foi possível editar o aluno, tente novamente mais tarde", "Erro ao editar",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public Boolean ExcluirAluno()
        {
            MySqlConnection con = DbConnection.getConnection();
            String query = "DELETE FROM tb_alunos WHERE RA = ?RA";

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.Add("?RA", MySqlDbType.Int32).Value = RA;
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                return true;
            }
            catch
            {
                MessageBox.Show("Não foi possível excluir o aluno, tente novamente mais tarde", "Erro ao excluir aluno",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public Boolean VincularUsuarioAluno()
        {
            MySqlConnection con = DbConnection.getConnection();
            String query = "UPDATE tb_alunos SET id_usuario = ?id_usuario WHERE RA = ?RA";

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.Add("?id_usuario", MySqlDbType.Int32).Value = IdUsuario;
                cmd.Parameters.Add("?RA", MySqlDbType.Int32).Value = RA;
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                return true;
            }
            catch
            {
                MessageBox.Show("Não foi possível vincular o aluno com RA '" + RA + "' a conta de usuário", "Erro ao vincular",
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
