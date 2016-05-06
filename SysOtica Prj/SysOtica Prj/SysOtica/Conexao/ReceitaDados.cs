using SysOtica.Negocio.Classes_Basicas;
using SysOtica.Negocio.Excecoes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Conexao
{
    public class ReceitaDados : IReceitaDados 
    {
        ConexaoBD conn = new ConexaoBD();

        public void inserirReceita(Receita receita, Cliente cli)
        {
            try
            {
                //abrir a conexão
                conn.AbrirConexao();
                string sql = "INSERT INTO Receita (rc_historico, rc_lodesferico, rc_loeesferico,rc_podesferico, rc_poeesferico,rc_lodcilindrico,rc_loecilindrico, rc_podcilindrico ,rc_poecilindrico,rc_lodeixo,rc_loeeixo,rc_podeixo,rc_poeeixo,rc_lodaltura,rc_loealtura,rc_podaltura,rc_poealtura,rc_loddnp,rc_loednp, rc_poddnp,rc_poednp,rc_adicao,rc_nomemedico,rc_observacoes,rc_data,rc_dtvencimento, cl_id)    Values   (@rc_historico, @rc_lodesferico, @rc_loeesferico, @rc_podesferico, @rc_poeesferico, @rc_lodcilindrico, @rc_loecilindrico, @rc_podcilindrico ,@rc_poecilindrico, @rc_lodeixo, @rc_loeeixo, @rc_podeixo, @rc_poeeixo, @rc_lodaltura, @rc_loealtura, @rc_podaltura, @rc_poealtura,@rc_loddnp,@rc_loednp, @rc_poddnp,@rc_poednp,@rc_adicao,@rc_nomemedico,@rc_observacoes,@rc_data,@rc_dtvencimento, @cl_id)";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql,conn.cone);

                cmd.Parameters.Add("@rc_historico", SqlDbType.VarChar);
                cmd.Parameters["@rc_historico"].Value = receita.Rc_historico;

                cmd.Parameters.Add("@rc_lodesferico", SqlDbType.Decimal);
                cmd.Parameters["@rc_lodesferico"].Value = receita.Rc_lodesferico;

                cmd.Parameters.Add("@rc_loeesferico", SqlDbType.Decimal);
                cmd.Parameters["@rc_loeesferico"].Value = receita.Rc_loeesferico;

                cmd.Parameters.Add("@rc_podesferico", SqlDbType.Decimal);
                cmd.Parameters["@rc_podesferico"].Value = receita.Rc_podesferico;

                cmd.Parameters.Add("@rc_poeesferico", SqlDbType.Decimal);
                cmd.Parameters["@rc_poeesferico"].Value = receita.Rc_poeesferico;

                cmd.Parameters.Add("@rc_lodcilindrico", SqlDbType.Decimal);
                cmd.Parameters["@rc_lodcilindrico"].Value = receita.Rc_lodcilindrico;

                cmd.Parameters.Add("@rc_loecilindrico", SqlDbType.Decimal);
                cmd.Parameters["@rc_loecilindrico"].Value = receita.Rc_loecilindrico;

                cmd.Parameters.Add("@rc_podcilindrico", SqlDbType.Decimal);
                cmd.Parameters["@rc_podcilindrico"].Value = receita.Rc_podcilindrico;

                cmd.Parameters.Add("@rc_poecilindrico", SqlDbType.Decimal);
                cmd.Parameters["@rc_poecilindrico"].Value = receita.Rc_poecilindrico;

                cmd.Parameters.Add("@rc_lodeixo", SqlDbType.Decimal);
                cmd.Parameters["@rc_lodeixo"].Value = receita.Rc_lodeixo;

                cmd.Parameters.Add("@rc_loeeixo", SqlDbType.Decimal);
                cmd.Parameters["@rc_loeeixo"].Value = receita.Rc_loeeixo;

                cmd.Parameters.Add("@rc_podeixo", SqlDbType.Decimal);
                cmd.Parameters["@rc_podeixo"].Value = receita.Rc_podeixo;

                cmd.Parameters.Add("@rc_poeeixo", SqlDbType.Decimal);
                cmd.Parameters["@rc_poeeixo"].Value = receita.Rc_poeeixo;

                cmd.Parameters.Add("@rc_lodaltura", SqlDbType.Decimal);
                cmd.Parameters["@rc_lodaltura"].Value = receita.Rc_lodaltura;

                cmd.Parameters.Add("@rc_loealtura", SqlDbType.Decimal);
                cmd.Parameters["@rc_loealtura"].Value = receita.Rc_loealtura;

                cmd.Parameters.Add("@rc_podaltura", SqlDbType.Decimal);
                cmd.Parameters["@rc_podaltura"].Value = receita.Rc_podaltura;

                cmd.Parameters.Add("@rc_poealtura", SqlDbType.Decimal);
                cmd.Parameters["@rc_poealtura"].Value = receita.Rc_poealtura;

                cmd.Parameters.Add("@rc_loddnp", SqlDbType.Decimal);
                cmd.Parameters["@rc_loddnp"].Value = receita.Rc_loddnp;

                cmd.Parameters.Add("@rc_loednp", SqlDbType.Decimal);
                cmd.Parameters["@rc_loednp"].Value = receita.Rc_loednp;

                cmd.Parameters.Add("@rc_poddnp", SqlDbType.Decimal);
                cmd.Parameters["@rc_poddnp"].Value = receita.Rc_poddnp;

                cmd.Parameters.Add("@rc_poednp", SqlDbType.Decimal);
                cmd.Parameters["@rc_poednp"].Value = receita.Rc_poednp;

                cmd.Parameters.Add("@rc_adicao", SqlDbType.Decimal);
                cmd.Parameters["@rc_adicao"].Value = receita.Rc_adicao;

                cmd.Parameters.Add("@rc_nomemedico", SqlDbType.VarChar);
                cmd.Parameters["@rc_nomemedico"].Value = receita.Rc_nomemedico;

                cmd.Parameters.Add("@rc_observacoes", SqlDbType.VarChar);
                cmd.Parameters["@rc_observacoes"].Value = receita.Rc_observacoes;

                cmd.Parameters.Add("@rc_data", SqlDbType.Date);
                cmd.Parameters["@rc_data"].Value = receita.Rc_data;

                cmd.Parameters.Add("@rc_dtvencimento", SqlDbType.Date);
                cmd.Parameters["@rc_dtvencimento"].Value = receita.Rc_dtavalidade;

                cmd.Parameters.Add("@cl_id", SqlDbType.Int);
                cmd.Parameters["@cl_id"].Value = cli.Cl_id;
          

                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                conn.FecharConexao();
            
            }
            catch (SqlException e)
            {
                throw new BancoDeDadosException("Falha na comunicação com o banco de dados. \n" + e.Message);
            }


        }



        public void alterarReceita(Receita receita)
        {
            try
            {
                //abrir a conexão
                conn.AbrirConexao();
                string sql = "UPDATE Receita SET rc_historico = @rc_historico, rc_lodesferico = @rc_lodesferico, rc_loeesferico = @rc_loeesferico,rc_podesferico = @rc_podesferico, rc_poeesferico = @rc_poeesferico,rc_lodcilindrico = @rc_lodcilindrico,rc_loecilindrico = @rc_loecilindrico, rc_podcilindrico = @rc_podcilindrico ,rc_poecilindrico = @rc_poecilindrico,rc_lodeixo = @rc_lodeixo,rc_loeeixo = @rc_loeeixo,rc_podeixo = @rc_podeixo,rc_poeeixo = @rc_poeeixo,rc_lodaltura = @rc_lodaltura,rc_loealtura = @rc_loealtura,rc_podaltura = @rc_podaltura,rc_poealtura = @rc_poealtura,rc_loddnp = @rc_loddnp,rc_loednp = @rc_loednp, rc_poddnp = @rc_poddnp,rc_poednp = @rc_poednp,rc_adicao = @rc_adicao,rc_nomemedico = @c_nomemedico,rc_observacoes = @rc_observacoes,rc_data = @rc_data,rc_dtvencimento = @rc_dtvencimento  WHERE rc_id = @rc_id";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, conn.cone);

                cmd.Parameters.Add("@rc_id", SqlDbType.Int);
                cmd.Parameters["@rc_id"].Value = receita.Rc_id;

                cmd.Parameters.Add("@rc_historico", SqlDbType.VarChar);
                cmd.Parameters["@rc_historico"].Value = receita.Rc_historico;

                cmd.Parameters.Add("@rc_lodesferico", SqlDbType.Date);
                cmd.Parameters["@rc_lodesferico"].Value = receita.Rc_lodesferico;

                cmd.Parameters.Add("@rc_loeesferico", SqlDbType.VarChar);
                cmd.Parameters["@rc_loeesferico"].Value = receita.Rc_loeesferico;

                cmd.Parameters.Add("@rc_podesferico", SqlDbType.VarChar);
                cmd.Parameters["@rc_podesferico"].Value = receita.Rc_podesferico;

                cmd.Parameters.Add("@rc_poeesferico", SqlDbType.VarChar);
                cmd.Parameters["@rc_poeesferico"].Value = receita.Rc_poeesferico;

                cmd.Parameters.Add("@rc_lodcilindrico", SqlDbType.VarChar);
                cmd.Parameters["@rc_lodcilindrico"].Value = receita.Rc_lodcilindrico;

                cmd.Parameters.Add("@rc_loecilindrico", SqlDbType.VarChar);
                cmd.Parameters["@rc_loecilindrico"].Value = receita.Rc_loecilindrico;

                cmd.Parameters.Add("@rc_podcilindrico", SqlDbType.VarChar);
                cmd.Parameters["@rc_podcilindrico"].Value = receita.Rc_podcilindrico;

                cmd.Parameters.Add("@rc_poecilindrico", SqlDbType.VarChar);
                cmd.Parameters["@rc_poecilindrico"].Value = receita.Rc_poecilindrico;

                cmd.Parameters.Add("@rc_lodeixo", SqlDbType.VarChar);
                cmd.Parameters["@rc_lodeixo"].Value = receita.Rc_lodeixo;

                cmd.Parameters.Add("@rc_loeeixo", SqlDbType.VarChar);
                cmd.Parameters["@rc_loeeixo"].Value = receita.Rc_loeeixo;

                cmd.Parameters.Add("@rc_podeixo", SqlDbType.VarChar);
                cmd.Parameters["@rc_podeixo"].Value = receita.Rc_podeixo;

                cmd.Parameters.Add("@rc_poeeixo", SqlDbType.VarChar);
                cmd.Parameters["@rc_poeeixo"].Value = receita.Rc_poeeixo;

                cmd.Parameters.Add("@rc_lodaltura", SqlDbType.VarChar);
                cmd.Parameters["@rc_lodaltura"].Value = receita.Rc_lodaltura;

                cmd.Parameters.Add("@rc_loealtura", SqlDbType.VarChar);
                cmd.Parameters["@rc_loealtura"].Value = receita.Rc_loealtura;

                cmd.Parameters.Add("@rc_podaltura", SqlDbType.VarChar);
                cmd.Parameters["@rc_podaltura"].Value = receita.Rc_podaltura;

                cmd.Parameters.Add("@rc_poealtura", SqlDbType.VarChar);
                cmd.Parameters["@rc_poealtura"].Value = receita.Rc_poealtura;

                cmd.Parameters.Add("@rc_loddnp", SqlDbType.VarChar);
                cmd.Parameters["@rc_loddnp"].Value = receita.Rc_loddnp;

                cmd.Parameters.Add("@rc_loednp", SqlDbType.VarChar);
                cmd.Parameters["@rc_loednp"].Value = receita.Rc_loednp;

                cmd.Parameters.Add("@rc_poddnp", SqlDbType.VarChar);
                cmd.Parameters["@rc_poddnp"].Value = receita.Rc_poddnp;

                cmd.Parameters.Add("@rc_poednp", SqlDbType.VarChar);
                cmd.Parameters["@rc_poednp"].Value = receita.Rc_poednp;

                cmd.Parameters.Add("@rc_adicao", SqlDbType.VarChar);
                cmd.Parameters["@rc_adicao"].Value = receita.Rc_adicao;

                cmd.Parameters.Add("@rc_nomemedico", SqlDbType.VarChar);
                cmd.Parameters["@rc_nomemedico"].Value = receita.Rc_nomemedico;

                cmd.Parameters.Add("@rc_observacoes", SqlDbType.VarChar);
                cmd.Parameters["@rc_observacoes"].Value = receita.Rc_observacoes;

                cmd.Parameters.Add("@rc_data", SqlDbType.VarChar);
                cmd.Parameters["@rc_data"].Value = receita.Rc_data;

                cmd.Parameters.Add("@rc_dtvencimento", SqlDbType.VarChar);
                cmd.Parameters["@rc_dtvencimento"].Value = receita.Rc_dtavalidade;

                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                conn.AbrirConexao();
            }
            catch (SqlException e)
            {
                throw new BancoDeDadosException("Falha na comunicação com o banco de dados. \n" + e.Message);
            }


        }

        public void excluirreceita(Receita receita)
        {

            try
            {
                //abrir a conexão
                conn.AbrirConexao();
                string sql = "DELETE FROM Receita WHERE rc_id = @rc_id";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, conn.cone);
                cmd.Parameters.Add("@rc_id", SqlDbType.Int);
                cmd.Parameters["@rc_id"].Value = receita.Rc_id;
                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                conn.FecharConexao();

            }
             catch  (SqlException e)
            {
                throw new BancoDeDadosException("Falha na comunicação com o banco de dados. \n" + e.Message);
            }



        }

      
        public List<Receita> listaReceita()
        {
            string sql = " SELECT rc_id, rc_historico,    rc_lodesferico, rc_loeesferico,  rc_podesferico,  rc_poeesferico,  rc_lodcilindrico,           rc_loecilindrico,  rc_podcilindrico,     rc_poecilindrico," +
                      "           rc_lodeixo,             rc_loeeixo,     rc_podeixo,      rc_poeeixo,      rc_lodaltura,    rc_loealtura, rc_podaltura, rc_poealtura,      rc_loddnp,            rc_loednp,        rc_poddnp, " +
                      "           rc_poednp, rc_adicao,   rc_nomemedico,  rc_observacoes,  rc_data,         rc_dtvencimento FROM Receita";

            List<Receita> lista = new List<Receita>();
            Receita  receita;

            try
            {
                conn.AbrirConexao();
                SqlCommand cmd = new SqlCommand(sql, conn.cone);
                SqlDataReader retorno = cmd.ExecuteReader();

                while (retorno.Read())
                {
                    receita = new Receita();
                    receita.Rc_id = Convert.ToInt32(retorno.GetOrdinal("rc_id"));
                    receita.Rc_historico = retorno.GetString(retorno.GetOrdinal("rc_historico"));                                    
                    receita.Rc_lodesferico = retorno.GetDecimal(retorno.GetOrdinal("rc_lodesferico"));
                    receita.Rc_loeesferico = retorno.GetDecimal(retorno.GetOrdinal("rc_loeesferico"));                                   
                    receita.Rc_podesferico = retorno.GetDecimal(retorno.GetOrdinal("rc_podesferico"));
                    receita.Rc_poeesferico = retorno.GetDecimal(retorno.GetOrdinal("rc_poeesferico"));
                    receita.Rc_lodcilindrico = retorno.GetDecimal(retorno.GetOrdinal("rc_lodcilindrico"));
                    receita.Rc_loecilindrico = retorno.GetDecimal(retorno.GetOrdinal("rc_loecilindrico"));
                    receita.Rc_podcilindrico = retorno.GetDecimal(retorno.GetOrdinal("rc_podcilindrico"));
                    receita.Rc_poecilindrico = retorno.GetDecimal(retorno.GetOrdinal("rc_poecilindrico"));
                    receita.Rc_lodeixo = retorno.GetDecimal(retorno.GetOrdinal("rc_lodeixo"));
                    receita.Rc_loeeixo = retorno.GetDecimal(retorno.GetOrdinal("rc_loeeixo"));
                    receita.Rc_podeixo = retorno.GetDecimal(retorno.GetOrdinal("rc_podeixo")); ;
                    receita.Rc_poeeixo = retorno.GetDecimal(retorno.GetOrdinal("rc_poeeixo"));
                    receita.Rc_lodaltura = retorno.GetDecimal(retorno.GetOrdinal("rc_lodaltura"));
                    receita.Rc_loealtura = retorno.GetDecimal(retorno.GetOrdinal("rc_loealtura"));
                    receita.Rc_podaltura = retorno.GetDecimal(retorno.GetOrdinal("rc_podaltura"));
                    receita.Rc_poealtura = retorno.GetDecimal(retorno.GetOrdinal("rc_poealtura")); ;
                    receita.Rc_loddnp = retorno.GetDecimal(retorno.GetOrdinal("rc_loddnp"));
                    receita.Rc_loednp = retorno.GetDecimal(retorno.GetOrdinal("rc_loednp"));
                    receita.Rc_poddnp = retorno.GetDecimal(retorno.GetOrdinal("rc_poddnp"));
                    receita.Rc_poednp = retorno.GetDecimal(retorno.GetOrdinal("rc_poednp"));
                    receita.Rc_data = retorno.GetDateTime(retorno.GetOrdinal("rc_data"));
                    receita.Rc_adicao = retorno.GetDecimal(retorno.GetOrdinal("rc_adicao"));
                    receita.Rc_nomemedico = retorno.GetString(retorno.GetOrdinal("rc_nomemedico"));
                    receita.Rc_dtavalidade = retorno.GetDateTime(retorno.GetOrdinal("rc_dtvencimento"));
                    receita.Rc_observacoes = retorno.GetString(retorno.GetOrdinal("rc_observacoes"));



                    lista.Add(receita);
                }
                conn.FecharConexao();
                return lista;

            }
            catch (SqlException e)
            {
                throw new BancoDeDadosException("Falha na comunicação com o banco de dados. \n" + e.Message);
            }




        }

        public List<Receita> pesquisaReceita(string rc_nomemedico)
        {
            string sql = " SELECT rc_id, rc_historico,    rc_lodesferico, rc_loeesferico,  rc_podesferico,  rc_poeesferico,  rc_lodcilindrico,           rc_loecilindrico,  rc_podcilindrico,     rc_poecilindrico," +
                      "           rc_lodeixo,             rc_loeeixo,     rc_podeixo,      rc_poeeixo,      rc_lodaltura,    rc_loealtura, rc_podaltura, rc_poealtura,      rc_loddnp,            rc_loednp,        rc_poddnp, " +
                      "           rc_poednp, rc_adicao,   rc_nomemedico,  rc_observacoes,  rc_data,         rc_dtvalidade FROM Receita";

            if (rc_nomemedico != "")
            {
                sql += "WHERE rc_nomemedico LIKE @rc_nomemedico";
            }
            List<Receita> lista = new List<Receita>();
            Receita receita = new Receita();

            try
            {
                conn.AbrirConexao();
                SqlCommand cmd = new SqlCommand(sql, conn.cone);
                if (rc_nomemedico != "")
                {
                    cmd.Parameters.AddWithValue("@rc_nomemedico", "%" + rc_nomemedico + "%");
                }
                SqlDataReader retorno = cmd.ExecuteReader();
                while (retorno.Read())
                {

                    receita = new Receita();
                    receita.Rc_id = retorno.GetInt32(retorno.GetOrdinal("rc_id"));
                    //Receita.Rc_historico = retorno.GetDateTime(retorno.GetOrdinal("rc_historico"));
                    receita.Rc_lodesferico = retorno.GetDecimal(retorno.GetOrdinal("rc_lodesferico"));
                    receita.Rc_loeesferico = retorno.GetDecimal(retorno.GetOrdinal("rc_loeesferico"));
                    receita.Rc_podesferico = retorno.GetDecimal(retorno.GetOrdinal("rc_podesferico"));
                    receita.Rc_poeesferico = retorno.GetDecimal(retorno.GetOrdinal("rc_poeesferico"));
                    receita.Rc_lodcilindrico = retorno.GetDecimal(retorno.GetOrdinal("rc_lodcilindrico"));
                    receita.Rc_loecilindrico = retorno.GetDecimal(retorno.GetOrdinal("rc_loecilindrico"));
                    receita.Rc_podcilindrico = retorno.GetDecimal(retorno.GetOrdinal("rc_podcilindrico"));
                    receita.Rc_poecilindrico = retorno.GetDecimal(retorno.GetOrdinal("rc_poecilindrico"));
                    receita.Rc_lodeixo = retorno.GetDecimal(retorno.GetOrdinal("rc_lodeixo"));
                    receita.Rc_loeeixo = retorno.GetDecimal(retorno.GetOrdinal("rc_loeeixo"));
                    receita.Rc_podeixo = retorno.GetDecimal(retorno.GetOrdinal("rc_podeixo")); ;
                    receita.Rc_poeeixo = retorno.GetDecimal(retorno.GetOrdinal("rc_poeeixo"));
                    receita.Rc_lodaltura = retorno.GetDecimal(retorno.GetOrdinal("rc_lodaltura"));
                    receita.Rc_loealtura = retorno.GetDecimal(retorno.GetOrdinal("rc_loealtura"));
                    receita.Rc_podaltura = retorno.GetDecimal(retorno.GetOrdinal("rc_podaltura"));
                    receita.Rc_poealtura = retorno.GetDecimal(retorno.GetOrdinal("rc_poealtura")); ;
                    receita.Rc_loddnp = retorno.GetDecimal(retorno.GetOrdinal("rc_loddnp"));
                    receita.Rc_loednp = retorno.GetDecimal(retorno.GetOrdinal("rc_loednp"));
                    receita.Rc_poddnp = retorno.GetDecimal(retorno.GetOrdinal("rc_poddnp"));
                    receita.Rc_poednp = retorno.GetDecimal(retorno.GetOrdinal("rc_poednp"));
                    receita.Rc_data = retorno.GetDateTime(retorno.GetOrdinal("rc_data"));
                    receita.Rc_adicao = retorno.GetDecimal(retorno.GetOrdinal("rc_adicao"));
                    receita.Rc_nomemedico = retorno.GetString(retorno.GetOrdinal("rc_nomemedico"));
                    receita.Rc_observacoes = retorno.GetString(retorno.GetOrdinal("rc_observacoes"));

                    lista.Add(receita);
                }
                conn.FecharConexao();
                return lista;

            }
            catch (SqlException e)
            {
                throw new BancoDeDadosException("Falha na comunicação com o banco de dados. \n" + e.Message);
            }

        }




        public bool verificaduplicidade(Receita receita)
        {
            throw new NotImplementedException();
        }


 

        }
    }
