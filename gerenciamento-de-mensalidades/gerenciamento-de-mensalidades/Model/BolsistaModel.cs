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
    class BolsistaModel : AlunoModel
    {
        private Int32 idBolsista;
        private String desconto;

        public BolsistaModel() { }

        public BolsistaModel(int idAluno)
        {
            IdAluno = idAluno;
        }

        public BolsistaModel(int idAluno, string desconto)
        {
            IdAluno = idAluno;
            this.desconto = desconto;
        }

        public int IdBolsista { get => idBolsista; set => idBolsista = value; }
        public string Desconto { get => desconto; set => desconto = value; }

        public Boolean VerificarSeEhBolsista()
        {
            MySqlConnection con = DbConnection.getConnection();
            String query = "SELECT * FROM tb_bolsistas WHERE id_aluno = ?id_aluno";

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.Add("?id_aluno", MySqlDbType.Int32).Value = IdAluno;

                MySqlDataReader mysqlDR = cmd.ExecuteReader();

                return mysqlDR.Read();
            }
            catch
            {
                MessageBox.Show("Falha na conexão com o servidor, tente novamente mais tarde", "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public String BuscarBolsaDesconto()
        {
            MySqlConnection con = DbConnection.getConnection();
            String query = "SELECT * FROM tb_bolsistas WHERE id_aluno = ?id_aluno";

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.Add("?id_aluno", MySqlDbType.Int32).Value = IdAluno;

                MySqlDataReader mysqlDR = cmd.ExecuteReader();

                if (mysqlDR.Read())
                {
                    return mysqlDR["desconto"].ToString();
                }
                else
                {
                    return "";
                }
            }
            catch
            {
                MessageBox.Show("Falha na conexão com o servidor, tente novamente mais tarde", "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
            finally
            {
                con.Close();
            }
        }

        public Boolean CadastrarBolsa()
        {
            MySqlConnection con = DbConnection.getConnection();
            String query = "INSERT INTO tb_bolsistas(id_aluno, desconto) VALUES (?id_aluno, ?desconto)";

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.Add("?id_aluno", MySqlDbType.Int32).Value = IdAluno;
                cmd.Parameters.Add("?desconto", MySqlDbType.VarChar).Value = Desconto;
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                return true;
            }
            catch
            {
                MessageBox.Show("Não foi possível cadastrar a bolsa, tente novamente mais tarde", "Erro ao cadastrar bolsa",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public Boolean AtualizarBolsa()
        {
            MySqlConnection con = DbConnection.getConnection();
            String query = "UPDATE tb_bolsistas SET desconto = ?desconto WHERE id_aluno = ?id_aluno";

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.Add("?desconto", MySqlDbType.VarChar).Value = Desconto;
                cmd.Parameters.Add("?id_aluno", MySqlDbType.Int32).Value = IdAluno;
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                return true;
            }
            catch
            {
                MessageBox.Show("Não foi possível atualizar a bolsa, tente novamente mais tarde", "Erro ao atualizar bolsa",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public Boolean RemoverBolsa()
        {
            MySqlConnection con = DbConnection.getConnection();
            String query = "DELETE FROM tb_bolsistas WHERE id_aluno = ?id_aluno";

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.Add("?id_aluno", MySqlDbType.Int32).Value = IdAluno;
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                return true;
            }
            catch
            {
                MessageBox.Show("Não foi possível remover a bolsa, tente novamente mais tarde", "Erro ao remover bolsa",
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
