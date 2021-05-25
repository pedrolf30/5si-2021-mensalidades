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
    public class UsuarioModel
    {
        private Int32 idUsuario;
        private String email;
        private String senha;
        private TipoUsuario tipoUsuario;
        private Boolean ativo;

        public UsuarioModel() { }

        public UsuarioModel(int idUsuario)
        {
            this.idUsuario = idUsuario;
        }

        public UsuarioModel(string email, string senha)
        {
            this.email = email;
            this.senha = senha;
        }

        public UsuarioModel(int idUsuario, string email, bool ativo)
        {
            this.idUsuario = idUsuario;
            this.email = email;
            this.ativo = ativo;
        }

        public UsuarioModel(string email, string senha, TipoUsuario tipoUsuario, bool ativo)
        {
            this.email = email;
            this.senha = senha;
            this.tipoUsuario = tipoUsuario;
            this.ativo = ativo;
        }

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Email { get => email; set => email = value; }
        public string Senha { get => senha; set => senha = value; }
        public bool Ativo { get => ativo; set => ativo = value; }
        internal TipoUsuario TipoUsuario { get => tipoUsuario; set => tipoUsuario = value; }

        public UsuarioModel FazerLogin()
        {
            UsuarioModel usuario = new UsuarioModel();

            MySqlConnection con = DbConnection.getConnection();
            String query = "SELECT * FROM tb_usuarios WHERE email = ?email AND senha = ?senha";

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.Add("?email", MySqlDbType.VarChar).Value = Email;
                cmd.Parameters.Add("?senha", MySqlDbType.VarChar).Value = Senha;

                MySqlDataReader mysqlDR = cmd.ExecuteReader();

                if (mysqlDR.Read())
                {
                    usuario.IdUsuario = Convert.ToInt32(mysqlDR["id_usuario"]);
                    usuario.Email = mysqlDR["email"].ToString();
                    usuario.Senha = mysqlDR["senha"].ToString();
                    usuario.Ativo = Convert.ToInt32(mysqlDR["ativo"]) == 1 ? true : false;
                    usuario.TipoUsuario = usuario.Ativo ? (TipoUsuario) Convert.ToInt32(mysqlDR["id_tipo_usuario"]) : TipoUsuario.Deactivated;
                    return usuario;
                }
                else
                {
                    usuario.TipoUsuario = TipoUsuario.Undefined;
                    return usuario;
                }
            }
            catch
            {
                MessageBox.Show("Falha na conexão com o servidor, tente novamente mais tarde", "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usuario.TipoUsuario = TipoUsuario.Undefined;
                return usuario;
            }
            finally
            {
                con.Close();
            }
        }

        public List<UsuarioModel> ListarUsuarios()
        {
            List<UsuarioModel> usuarios = new List<UsuarioModel>();

            MySqlConnection con = DbConnection.getConnection();
            String query = "SELECT * FROM tb_usuarios WHERE id_tipo_usuario != 1 ORDER BY id_tipo_usuario, id_usuario";

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);

                MySqlDataReader mysqlDR = cmd.ExecuteReader();

                if (mysqlDR != null)
                    while (mysqlDR.Read())
                    {
                        UsuarioModel usuario = new UsuarioModel();
                        usuario.IdUsuario = Convert.ToInt32(mysqlDR["id_usuario"]);
                        usuario.Email = mysqlDR["email"].ToString();
                        usuario.Senha = mysqlDR["senha"].ToString();
                        usuario.Ativo = Convert.ToInt32(mysqlDR["ativo"]) == 1 ? true : false;
                        usuario.TipoUsuario = (TipoUsuario) Convert.ToInt32(mysqlDR["id_tipo_usuario"]);
                        usuarios.Add(usuario);
                    }

                return usuarios;
            }
            catch
            {
                MessageBox.Show("Falha ao listar usuários, tente novamente mais tarde", "Erro na conexão com o servidor",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return usuarios;
            }
            finally
            {
                con.Close();
            }
        }

        public Int32 CadastrarUsuario()
        {
            MySqlConnection con = DbConnection.getConnection();
            String query = "INSERT INTO tb_usuarios(email, senha, id_tipo_usuario, ativo) VALUES (?email, ?senha, ?id_tipo_usuario, ?ativo)";

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.Add("?email", MySqlDbType.VarChar).Value = Email;
                cmd.Parameters.Add("?senha", MySqlDbType.VarChar).Value = Senha;
                cmd.Parameters.Add("?id_tipo_usuario", MySqlDbType.Int32).Value = (int) TipoUsuario;
                cmd.Parameters.Add("?ativo", MySqlDbType.Int32).Value = Ativo ? 1 : 0;
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                return FazerLogin().IdUsuario;
            }
            catch
            {
                MessageBox.Show("Não foi possível finalizar o seu cadastro, tente novamente mais tarde", "Erro ao cadastrar",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            finally
            {
                con.Close();
            }
        }

        public Boolean AtualizarUsuario()
        {
            MySqlConnection con = DbConnection.getConnection();
            String query = "UPDATE tb_usuarios SET email = ?email, ativo = ?ativo WHERE id_usuario = ?id_usuario";

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.Add("?email", MySqlDbType.VarChar).Value = Email;
                cmd.Parameters.Add("?ativo", MySqlDbType.Int32).Value = Ativo ? 1 : 0;
                cmd.Parameters.Add("?id_usuario", MySqlDbType.Int32).Value = IdUsuario;
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                return true;
            }
            catch
            {
                MessageBox.Show("Não foi possível editar o usuário, tente novamente mais tarde", "Erro ao editar",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public Boolean ExcluirUsuario()
        {
            MySqlConnection con = DbConnection.getConnection();
            String query = "DELETE FROM tb_usuarios WHERE id_usuario = ?id_usuario";

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.Add("?id_usuario", MySqlDbType.Int32).Value = IdUsuario;
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                return true;
            }
            catch
            {
                MessageBox.Show("Não foi possível excluir o usuário, tente novamente mais tarde", "Erro ao excluir",
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
