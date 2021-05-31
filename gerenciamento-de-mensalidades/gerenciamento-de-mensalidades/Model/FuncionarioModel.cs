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
    public class FuncionarioModel : UsuarioModel
    {
        private Int32 idFuncionario;
        private String nome;
        private DateTime? dataNascimento;
        private String cpf;
        private String contato;

        public FuncionarioModel() { }

        public FuncionarioModel(int idUsuario)
        {
            IdUsuario = idUsuario;
        }

        public FuncionarioModel(int idUsuario, string nome, DateTime dataNascimento, string cpf, string contato)
        {
            IdUsuario = idUsuario;
            this.nome = nome;
            this.dataNascimento = dataNascimento;
            this.cpf = cpf;
            this.contato = contato;
        }

        public int IdFuncionario { get => idFuncionario; set => idFuncionario = value; }
        public string Nome { get => nome; set => nome = value; }
        public DateTime? DataNascimento { get => dataNascimento; set => dataNascimento = value; }
        public string CPF { get => cpf; set => cpf = value; }
        public string Contato { get => contato; set => contato = value; }

        public FuncionarioModel BuscarFuncionario()
        {
            FuncionarioModel funcionario = new FuncionarioModel();

            MySqlConnection con = DbConnection.getConnection();
            String query = "SELECT * FROM tb_funcionarios WHERE id_usuario = ?id_usuario";

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.Add("?id_usuario", MySqlDbType.Int32).Value = IdUsuario;

                MySqlDataReader mysqlDR = cmd.ExecuteReader();

                if (mysqlDR.Read())
                {
                    funcionario.IdFuncionario = Convert.ToInt32(mysqlDR["id_funcionario"]);
                    funcionario.Nome = mysqlDR["nome_completo"].ToString();
                    funcionario.DataNascimento = Convert.ToDateTime(mysqlDR["data_nascimento"]);
                    funcionario.CPF = mysqlDR["CPF"].ToString();
                    funcionario.Contato = mysqlDR["contato"].ToString();
                    funcionario.TipoUsuario = TipoUsuario.Funcionario;
                    return funcionario;
                }
                else
                {
                    funcionario.TipoUsuario = TipoUsuario.Undefined;
                    return funcionario;
                }
            }
            catch
            {
                MessageBox.Show("Falha ao selecionar funcionário, tente novamente mais tarde", "Erro ao selecionar",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                funcionario.TipoUsuario = TipoUsuario.Undefined;
                return funcionario;
            }
            finally
            {
                con.Close();
            }
        }

        public Boolean CadastrarFuncionario()
        {
            MySqlConnection con = DbConnection.getConnection();
            String query = "INSERT INTO tb_funcionarios(nome_completo, data_nascimento, CPF, contato, id_usuario) " +
                           "VALUES (?nome_completo, ?data_nascimento, ?CPF, ?contato, ?id_usuario)";

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.Add("?nome_completo", MySqlDbType.VarChar).Value = Nome;
                cmd.Parameters.Add("?data_nascimento", MySqlDbType.Date).Value = DataNascimento.Value.Date;
                cmd.Parameters.Add("?CPF", MySqlDbType.VarChar).Value = CPF;
                cmd.Parameters.Add("?contato", MySqlDbType.VarChar).Value = Contato;
                cmd.Parameters.Add("?id_usuario", MySqlDbType.Int32).Value = IdUsuario;
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

        public Boolean AtualizarFuncionario()
        {
            MySqlConnection con = DbConnection.getConnection();
            String query = "UPDATE tb_funcionarios SET nome_completo = ?nome_completo, data_nascimento = ?data_nascimento, CPF = ?CPF, contato = ?contato WHERE id_usuario = ?id_usuario";

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.Add("?nome_completo", MySqlDbType.VarChar).Value = Nome;
                cmd.Parameters.Add("?data_nascimento", MySqlDbType.Date).Value = DataNascimento.Value.Date;
                cmd.Parameters.Add("?CPF", MySqlDbType.VarChar).Value = CPF;
                cmd.Parameters.Add("?contato", MySqlDbType.VarChar).Value = Contato;
                cmd.Parameters.Add("?id_usuario", MySqlDbType.Int32).Value = IdUsuario;
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                return true;
            }
            catch
            {
                MessageBox.Show("Não foi possível editar o funcionário, tente novamente mais tarde", "Erro ao editar",
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
