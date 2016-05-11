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
    public class VendaDados : IVendaDados
    {
        ConexaoBD conn = new ConexaoBD();

        public void inserir(Venda v)
        {

            try
            {
                conn.AbrirConexao();
                string sql = "INSERT INTO venda (cl_id, vn_valor, vn_valortotal, vn_desconto, vn_formapagamento ) VALUES ( @cl_id, @vn_valor, @vn_valortotal, @vn_desconto, @vn_formapagamento)";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, conn.cone);

                cmd.Parameters.Add("@cl_id", SqlDbType.Int);
                cmd.Parameters["@cl_id"].Value = v.Cliente;

                cmd.Parameters.Add("@vn_valor", SqlDbType.Decimal);
                cmd.Parameters["@vn_valor"].Value = v.Vn_valor;

                cmd.Parameters.Add("@vn_valortotal", SqlDbType.Decimal);
                cmd.Parameters["@vn_valortotal"].Value = v.Vn_valortotal;

                cmd.Parameters.Add("@vn_desconto", SqlDbType.Decimal);
                cmd.Parameters["@vn_desconto"].Value = v.Vn_desconto;

                cmd.Parameters.Add("@vn_formapagamento", SqlDbType.VarChar);
                cmd.Parameters["@vn_formapagamento"].Value = v.Vn_formapagamento;


                //foreach (ProdutoVenda pv in v.)
                //{
                //    ConexaoBD conn2 = new ConexaoBD();
                //    conn2.AbrirConexao();

                //    string sqlprodutovenda = "INSERT INTO produtofornecedor(=) Values ( =)";
                //    SqlCommand cmd2 = new SqlCommand(sqlprodutovenda, conn.cone);


                //    cmd.Parameters.Add("vn_id", SqlDbType.Int);
                //    cmd.Parameters["vn_id"].Value = pv.Venda.Vn_id;

                //    cmd2.ExecuteNonQuery();
                //    cmd2.Dispose();

                //    conn2.FecharConexao();
                //}


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

        //public void alterarVenda(Venda v)
        //{

        //    try
        //    {
        //        //abrir a conexão
        //        conn.AbrirConexao();
        //        string sql = "UPDATE Cliente SET  cl_nome = @cl_nome, cl_datanascimento = @cl_datanascimento, cl_cpf	= @cl_cpf, cl_rg = @cl_rg, cl_telefone = @cl_telefone, cl_celular = @cl_celular, cl_telefone2 = @cl_telefone2, cl_cep = @cl_cep, cl_endereco = @cl_endereco, cl_numero = @cl_numero, cl_bairro	= @cl_bairro, cl_cidade = @cl_cidade, cl_uf = @cl_uf, cl_email = @cl_email, cl_nomepai = @cl_nomepai, cl_nomemae = @cl_nomemae, cl_profissao = @cl_profissao, cl_observacoes = @cl_observacoes WHERE cl_id = @cl_id;";
        //        //instrucao a ser executada
        //        SqlCommand cmd = new SqlCommand(sql, conn.cone);

        //        cmd.Parameters.Add("@cl_id", SqlDbType.Int);
        //        cmd.Parameters["@cl_id"].Value = c.Cl_id;

        //        cmd.Parameters.Add("@cl_nome", SqlDbType.VarChar);
        //        cmd.Parameters["@cl_nome"].Value = c.Cl_nome;

        //        cmd.Parameters.Add("@cl_datanascimento", SqlDbType.Date);
        //        cmd.Parameters["@cl_datanascimento"].Value = c.Cl_datanascimento;

        //        cmd.Parameters.Add("@cl_cpf", SqlDbType.VarChar);
        //        cmd.Parameters["@cl_cpf"].Value = c.Cl_cpf;

        //        cmd.Parameters.Add("@cl_rg", SqlDbType.VarChar);
        //        cmd.Parameters["@cl_rg"].Value = c.Cl_rg;

        //        cmd.Parameters.Add("@cl_telefone", SqlDbType.VarChar);
        //        cmd.Parameters["@cl_telefone"].Value = c.Cl_telefone;

        //        cmd.Parameters.Add("@cl_celular", SqlDbType.VarChar);
        //        cmd.Parameters["@cl_celular"].Value = c.Cl_celular;

        //        cmd.Parameters.Add("@cl_telefone2", SqlDbType.VarChar);
        //        cmd.Parameters["@cl_telefone2"].Value = c.Cl_telefone2;

        //        cmd.Parameters.Add("@cl_cep", SqlDbType.VarChar);
        //        cmd.Parameters["@cl_cep"].Value = c.Cl_cep;

        //        cmd.Parameters.Add("@cl_endereco", SqlDbType.VarChar);
        //        cmd.Parameters["@cl_endereco"].Value = c.Cl_endereco;

        //        cmd.Parameters.Add("@cl_numero", SqlDbType.VarChar);
        //        cmd.Parameters["@cl_numero"].Value = c.Cl_numero;

        //        cmd.Parameters.Add("@cl_bairro", SqlDbType.VarChar);
        //        cmd.Parameters["@cl_bairro"].Value = c.Cl_bairro;

        //        cmd.Parameters.Add("@cl_cidade", SqlDbType.VarChar);
        //        cmd.Parameters["@cl_cidade"].Value = c.Cl_cidade;

        //        cmd.Parameters.Add("@cl_uf", SqlDbType.VarChar);
        //        cmd.Parameters["@cl_uf"].Value = c.Cl_uf;

        //        cmd.Parameters.Add("@cl_email", SqlDbType.VarChar);
        //        cmd.Parameters["@cl_email"].Value = c.Cl_email;

        //        cmd.Parameters.Add("@cl_nomepai", SqlDbType.VarChar);
        //        cmd.Parameters["@cl_nomepai"].Value = c.Cl_nomepai;

        //        cmd.Parameters.Add("@cl_nomemae", SqlDbType.VarChar);
        //        cmd.Parameters["@cl_nomemae"].Value = c.Cl_nomemae;

        //        cmd.Parameters.Add("@cl_profissao", SqlDbType.VarChar);
        //        cmd.Parameters["@cl_profissao"].Value = c.Cl_profissao;

        //        cmd.Parameters.Add("@cl_observacoes", SqlDbType.VarChar);
        //        cmd.Parameters["@cl_observacoes"].Value = c.Cl_observacoes;

        //        //executando a instrucao 
        //        cmd.ExecuteNonQuery();
        //        //liberando a memoria 
        //        cmd.Dispose();
        //        //fechando a conexao
        //        conn.FecharConexao();


        //    }
        //    catch (SqlException e)
        //    {
        //        throw new BancoDeDadosException("Falha na comunicação com o banco de dados. \n" + e.Message);
        //    }

        //}
        //public void excluirVenda(Venda v)
        //{
        //    try {

        //        //abrir a conexão
        //            conn.AbrirConexao();
        //            string sql = "DELETE FROM Cliente WHERE cl_id = @cl_id";
        //            //instrucao a ser executada
        //            SqlCommand cmd = new SqlCommand(sql,conn.cone);
        //            cmd.Parameters.Add("@cl_id", SqlDbType.Int);
        //            cmd.Parameters["@cl_id"].Value = c.Cl_id;
        //            //executando a instrucao 
        //            cmd.ExecuteNonQuery();
        //            //liberando a memoria 
        //            cmd.Dispose();
        //            //fechando a conexao
        //            conn.FecharConexao();
        //}
        //    catch (SqlException e)
        //    {
        //        throw new BancoDeDadosException("Falha na comunicação com o banco de dados. \n" + e.Message);
        //    }
        //}
        public List<Venda> listarVenda()
        {
            string sql = "SELECT  vn_id , cl_id , vn_valor , vn_valortotal , vn_desconto , vn_formapagamento  FROM  venda";
            List<Venda> lista = new List<Venda>();
            Venda v;
            try
            {
                conn.AbrirConexao();
                SqlCommand cmd = new SqlCommand(sql, conn.cone);
                SqlDataReader retorno = cmd.ExecuteReader();

                while (retorno.Read())
                {
                    v = new Venda();
                    v.Vn_id = retorno.GetInt32(retorno.GetOrdinal("vn_id"));
                    v.Vn_valor = retorno.GetDecimal(retorno.GetOrdinal("vn_valor"));
                    v.Vn_valortotal = retorno.GetDecimal(retorno.GetOrdinal("vn_valortotal"));
                    v.Vn_desconto = retorno.GetDecimal(retorno.GetOrdinal("vn_desconto"));
                    v.Vn_formapagamento = retorno.GetString(retorno.GetOrdinal("vn_formapagamento"));
                    lista.Add(v);
                }
                conn.FecharConexao();
                return lista;

            }
            catch (SqlException e)
            {
                throw new BancoDeDadosException("Falha na comunicação com o banco de dados. \n" + e.Message);
            }
        }

        //public List<Venda> pesquisarVenda(int CodigoVenda)
        //{
        //    string sql = "SELECT  cl_id, cl_nome,cl_datanascimento,cl_cpf,cl_rg, cl_telefone,cl_celular, cl_telefone2,cl_cep,cl_endereco,cl_numero, cl_bairro,cl_cidade, cl_uf,cl_email,cl_nomepai,cl_nomemae, cl_profissao, cl_observacoes FROM Cliente";
        //    if (CodigoVenda != null)
        //    {
        //        sql += "WHERE cl_nome ILIKE @cl_nome";
        //    }
        //    List<Venda> lista = new List<Venda>();
        //    Venda v = new Venda();

        //    try
        //    {
        //        conn.AbrirConexao();
        //        SqlCommand cmd = new SqlCommand(sql, conn.cone);
        //        if (CodigoVenda != null)
        //        {
        //            cmd.Parameters.AddWithValue("@cl_nome", "%" + CodigoVenda + "%");
        //        }
        //        SqlDataReader retorno = cmd.ExecuteReader();
        //        while (retorno.Read())
        //        {
        //            v = new Venda();
        //            v.CodigoVenda = retorno.GetInt32(retorno.GetOrdinal("cl_id"));
        //            v.Cl_nome = retorno.GetString(retorno.GetOrdinal("cl_nome"));
        //            v.Cl_datanascimento = retorno.GetDateTime(retorno.GetOrdinal("cl_dtnascimento"));
        //            v.Cl_cpf = retorno.GetString(retorno.GetOrdinal("cl_cpf"));
        //            v.Cl_rg = retorno.GetString(retorno.GetOrdinal("cl_rg"));
        //            v.Cl_telefone = retorno.GetString(retorno.GetOrdinal("cl_telefone"));
        //            v.Cl_celular = retorno.GetString(retorno.GetOrdinal("cl_celular"));
        //            v.Cl_telefone2 = retorno.GetString(retorno.GetOrdinal("cl_telefone2"));
        //            v.Cl_cep = retorno.GetString(retorno.GetOrdinal("cl_cep"));
        //            v.Cl_endereco = retorno.GetString(retorno.GetOrdinal("cl_endereco"));
        //            v.Cl_numero = retorno.GetString(retorno.GetOrdinal("cl_numero"));
        //            v.Cl_bairro = retorno.GetString(retorno.GetOrdinal("cl_bairro"));
        //            v.Cl_cidade = retorno.GetString(retorno.GetOrdinal("cl_cidade"));
        //            v.Cl_uf = retorno.GetString(retorno.GetOrdinal("cl_uf"));
        //            v.Cl_email = retorno.GetString(retorno.GetOrdinal("cl_email"));
        //            v.Cl_nomepai = retorno.GetString(retorno.GetOrdinal("cl_nomepai"));
        //            v.Cl_nomemae = retorno.GetString(retorno.GetOrdinal("cl_nomemae"));
        //            v.Cl_profissao = retorno.GetString(retorno.GetOrdinal("cl_profissao"));
        //            v.Cl_observacoes = retorno.GetString(retorno.GetOrdinal("cl_observacoes"));
        //            lista.Add(v);
        //        }
        //        return lista;
        //    }
        //    catch (SqlException e)
        //    {
        //        throw new BancoDeDadosException("Falha na comunicação com o banco de dados. \n" + e.Message);
        //    }
        //}



    }
}
