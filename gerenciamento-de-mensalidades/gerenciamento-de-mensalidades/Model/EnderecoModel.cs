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
    class EnderecoModel
    {
        private Int32 idEndereco;
        private String rua;
        private Int32 numero;
        private String cep;
        private String bairro;
        private String cidade;
        private String estado;
        private String complemento;

        public EnderecoModel() { }

        public EnderecoModel(int idEndereco)
        {
            this.idEndereco = idEndereco;
        }

        public EnderecoModel(string rua, int numero, string cep, string bairro, string cidade, string estado, string complemento)
        {
            this.rua = rua;
            this.numero = numero;
            this.cep = cep;
            this.bairro = bairro;
            this.cidade = cidade;
            this.estado = estado;
            this.complemento = complemento;
        }

        public EnderecoModel(int idEndereco, string rua, int numero, string cep, string bairro, string cidade, string estado, string complemento)
        {
            this.idEndereco = idEndereco;
            this.rua = rua;
            this.numero = numero;
            this.cep = cep;
            this.bairro = bairro;
            this.cidade = cidade;
            this.estado = estado;
            this.complemento = complemento;
        }

        public int IdEndereco { get => idEndereco; set => idEndereco = value; }
        public string Rua { get => rua; set => rua = value; }
        public int Numero { get => numero; set => numero = value; }
        public string CEP { get => cep; set => cep = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Complemento { get => complemento; set => complemento = value; }

        public List<EnderecoModel> ListarEnderecosAluno(Int32 idAluno)
        {
            List<EnderecoModel> enderecos = new List<EnderecoModel>();

            MySqlConnection con = DbConnection.getConnection();
            String query = "SELECT * FROM tb_enderecos WHERE id_aluno = ?id_aluno";

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.Add("?id_aluno", MySqlDbType.Int32).Value = idAluno;

                MySqlDataReader mysqlDR = cmd.ExecuteReader();

                if (mysqlDR != null)
                    while (mysqlDR.Read())
                    {
                        EnderecoModel endereco = new EnderecoModel();
                        endereco.IdEndereco = Convert.ToInt32(mysqlDR["id_endereco"]);
                        endereco.Rua = mysqlDR["rua"].ToString();
                        endereco.Numero = Convert.ToInt32(mysqlDR["numero"]);
                        endereco.CEP = mysqlDR["cep"].ToString();
                        endereco.Bairro = mysqlDR["bairro"].ToString();
                        endereco.Cidade = mysqlDR["cidade"].ToString();
                        endereco.Estado = mysqlDR["estado"].ToString();
                        endereco.Complemento = mysqlDR["complemento"].ToString();
                        enderecos.Add(endereco);
                    }

                return enderecos;
            }
            catch
            {
                MessageBox.Show("Falha ao listar endereços, tente novamente mais tarde", "Erro na conexão com o servidor",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return enderecos;
            }
            finally
            {
                con.Close();
            }
        }

        public Boolean CadastrarEndereco(Int32 idAluno)
        {
            MySqlConnection con = DbConnection.getConnection();
            String query = "INSERT INTO tb_enderecos(id_aluno, rua, numero, cep, bairro, cidade, estado, complemento) " +
                            "VALUES (?id_aluno, ?rua, ?numero, ?cep, ?bairro, ?cidade, ?estado, ?complemento)";

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.Add("?id_aluno", MySqlDbType.Int32).Value = idAluno;
                cmd.Parameters.Add("?rua", MySqlDbType.VarChar).Value = Rua;
                cmd.Parameters.Add("?numero", MySqlDbType.Int32).Value = Numero;
                cmd.Parameters.Add("?cep", MySqlDbType.VarChar).Value = CEP;
                cmd.Parameters.Add("?bairro", MySqlDbType.VarChar).Value = Bairro;
                cmd.Parameters.Add("?cidade", MySqlDbType.VarChar).Value = Cidade;
                cmd.Parameters.Add("?estado", MySqlDbType.VarChar).Value = Estado;
                cmd.Parameters.Add("?complemento", MySqlDbType.VarChar).Value = Complemento;
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                return true;
            }
            catch
            {
                MessageBox.Show("Não foi possível adicionar, tente novamente mais tarde", "Erro ao adicionar",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public Boolean AtualizarEndereco()
        {
            MySqlConnection con = DbConnection.getConnection();
            String query = "UPDATE tb_enderecos SET rua = ?rua, numero = ?numero, cep = ?cep, bairro = ?bairro, cidade = ?cidade, " +
                           "estado = ?estado, complemento = ?complemento WHERE id_endereco = ?id_endereco";

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.Add("?rua", MySqlDbType.VarChar).Value = Rua;
                cmd.Parameters.Add("?numero", MySqlDbType.Int32).Value = Numero;
                cmd.Parameters.Add("?cep", MySqlDbType.VarChar).Value = CEP;
                cmd.Parameters.Add("?bairro", MySqlDbType.VarChar).Value = Bairro;
                cmd.Parameters.Add("?cidade", MySqlDbType.VarChar).Value = Cidade;
                cmd.Parameters.Add("?estado", MySqlDbType.VarChar).Value = Estado;
                cmd.Parameters.Add("?complemento", MySqlDbType.VarChar).Value = Complemento;
                cmd.Parameters.Add("?id_endereco", MySqlDbType.Int32).Value = IdEndereco;
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                return true;
            }
            catch
            {
                MessageBox.Show("Não foi possível editar o endereço, tente novamente mais tarde", "Erro ao editar",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public Boolean ExcluirEndereco()
        {
            MySqlConnection con = DbConnection.getConnection();
            String query = "DELETE FROM tb_enderecos WHERE id_endereco = ?id_endereco";

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.Add("?id_endereco", MySqlDbType.Int32).Value = IdEndereco;
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                return true;
            }
            catch
            {
                MessageBox.Show("Não foi possível excluir o endereço, tente novamente mais tarde", "Erro ao excluir",
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
