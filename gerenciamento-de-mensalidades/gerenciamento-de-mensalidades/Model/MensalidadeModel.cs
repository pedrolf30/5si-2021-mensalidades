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
    class MensalidadeModel
    {
        private Int32 idMensalidade;
        private Double valor;
        private String mesMensalidade;
        private DateTime dataVencimento;
        private Boolean pago;
        private DateTime? dataPagamento;

        public int IdMensalidade { get => idMensalidade; set => idMensalidade = value; }
        public double Valor { get => valor; set => valor = value; }
        public string MesMensalidade { get => mesMensalidade; set => mesMensalidade = value; }
        public DateTime DataVencimento { get => dataVencimento; set => dataVencimento = value; }
        public bool Pago { get => pago; set => pago = value; }
        public DateTime? DataPagamento { get => dataPagamento; set => dataPagamento = value; }

        public static List<MensalidadeModel> ListarMensalidadesAluno(String statusData, String statusPagamento, Int32 idAluno)
        {
            List<MensalidadeModel> mensalidadesAluno = new List<MensalidadeModel>();

            MySqlConnection con = DbConnection.getConnection();
            String query = "SELECT * FROM tb_mensalidades WHERE id_aluno = ?id_aluno ORDER BY data_vencimento DESC";

            if (statusData == "Mais antigas" && statusPagamento == "Todas")
            {
                query = "SELECT * FROM tb_mensalidades WHERE id_aluno = ?id_aluno ORDER BY data_vencimento";
            }
            else if(statusData == "Mais recentes" && statusPagamento == "Pagas")
            {
                query = "SELECT * FROM tb_mensalidades WHERE id_aluno = ?id_aluno AND pago = 1 ORDER BY data_vencimento DESC";
            }
            else if (statusData == "Mais antigas" && statusPagamento == "Pagas")
            {
                query = "SELECT * FROM tb_mensalidades WHERE id_aluno = ?id_aluno AND pago = 1 ORDER BY data_vencimento";
            }
            else if (statusData == "Mais recentes" && statusPagamento == "Não Pagas")
            {
                query = "SELECT * FROM tb_mensalidades WHERE id_aluno = ?id_aluno AND pago = 0 ORDER BY data_vencimento DESC";
            }
            else if (statusData == "Mais antigas" && statusPagamento == "Não Pagas")
            {
                query = "SELECT * FROM tb_mensalidades WHERE id_aluno = ?id_aluno AND pago = 0 ORDER BY data_vencimento";
            }


            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.Add("?id_aluno", MySqlDbType.Int32).Value = idAluno;

                MySqlDataReader mysqlDR = cmd.ExecuteReader();

                if (mysqlDR != null)
                    while (mysqlDR.Read())
                    {
                        MensalidadeModel mensalidade = new MensalidadeModel();
                        mensalidade.IdMensalidade = Convert.ToInt32(mysqlDR["id_mensalidade"]);
                        mensalidade.Valor = Convert.ToDouble(mysqlDR["valor"]);
                        mensalidade.MesMensalidade = mysqlDR["mes_mensalidade"].ToString();
                        mensalidade.DataVencimento = Convert.ToDateTime(mysqlDR["data_vencimento"]);
                        mensalidade.Pago = Convert.ToInt32(mysqlDR["pago"]) == 1 ? true : false;

                        if (mysqlDR["data_pagamento"] != DBNull.Value)
                        {
                            mensalidade.DataPagamento = Convert.ToDateTime(mysqlDR["data_pagamento"]);
                        }

                        mensalidadesAluno.Add(mensalidade);
                    }

                return mensalidadesAluno;
            }
            catch
            {
                MessageBox.Show("Falha ao listar mensalidades do aluno, tente novamente mais tarde", "Erro na conexão com o servidor",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return mensalidadesAluno;
            }
            finally
            {
                con.Close();
            }
        }

        public static Int32 BuscarTotalMensalidadesAtrasadasAluno(Int32 idAluno)
        {
            MySqlConnection con = DbConnection.getConnection();
            String query = "SELECT COUNT(*) AS TotalMensalidadesAtrasadas FROM tb_mensalidades WHERE id_aluno = ?id_aluno AND NOW() > data_vencimento AND pago = 0";

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.Add("?id_aluno", MySqlDbType.Int32).Value = idAluno;

                MySqlDataReader mysqlDR = cmd.ExecuteReader();

                if (mysqlDR.Read())
                {
                    return Convert.ToInt32(mysqlDR["TotalMensalidadesAtrasadas"]);
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                MessageBox.Show("Falha buscar o total de mensalidades atrasadas, tente novamente mais tarde", "Erro na conexão com o servidor",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            finally
            {
                con.Close();
            }
        }

        public static Double BuscarValorTotalDividasAluno(Int32 idAluno)
        {
            MySqlConnection con = DbConnection.getConnection();
            String query = "SELECT SUM(valor) AS ValorTotalDividas FROM tb_mensalidades WHERE id_aluno = ?id_aluno AND NOW() > data_vencimento AND pago = 0";

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.Add("?id_aluno", MySqlDbType.Int32).Value = idAluno;

                MySqlDataReader mysqlDR = cmd.ExecuteReader();

                if (mysqlDR.Read())
                {
                    return Convert.ToDouble(mysqlDR["ValorTotalDividas"]);
                }
                else
                {
                    return 0.00;
                }
            }
            catch
            {
                MessageBox.Show("Falha buscar o valor total de dividas, tente novamente mais tarde", "Erro na conexão com o servidor",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0.00;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
