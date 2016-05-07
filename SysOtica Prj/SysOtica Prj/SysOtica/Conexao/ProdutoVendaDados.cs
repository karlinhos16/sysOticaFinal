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
    public class ProdutoVendaDados
    {
        ConexaoBD conn = new ConexaoBD();


        public void inserir(ProdutoVenda pv)
        {
            try
            {
                conn.AbrirConexao();
                string sql = "INSERT INTO produtofornecedor(pv_dtsaida,pv_qtd, vn_id) Values (@pv_dtsaida,@pv_qtd, @vn_id)";

                SqlCommand cmd = new SqlCommand(sql, conn.cone);



                cmd.Parameters.Add("@pv_dtsaida", SqlDbType.Date);
                cmd.Parameters["@pv_dtsaida"].Value = pv.Pv_dtsaida;

                cmd.Parameters.Add("@pv_qtd", SqlDbType.Decimal);
                cmd.Parameters["@pv_qtd"].Value = pv.Pv_qtd;

                cmd.Parameters.Add("vn_id", SqlDbType.Int);
                cmd.Parameters["vn_id"].Value = pv.Venda.Vn_id;

                foreach (Produto p in pv.Listaproduto)
                {
                    ConexaoBD conn1 = new ConexaoBD();
                    conn1.AbrirConexao();

                    string sqlproduto = "INSERT INTO Produto (pr_descricao, pr_grife, pr_valor, pr_estoqueminimo, pr_categoria,  pr_qtd, pr_unidade) values ( @pr_descricao, @pr_grife, @pr_valor, @pr_estoqueminimo, @pr_categoria, @pr_qtd, @pr_unidade)";
                    SqlCommand cmd1 = new SqlCommand(sqlproduto, conn.cone);

                    cmd.Parameters.Add("@pr_id", SqlDbType.VarChar);
                    cmd.Parameters["@pr_id"].Value = p.Pr_id;

                    cmd1.ExecuteNonQuery();
                    cmd1.Dispose();

                    conn1.FecharConexao();

                }
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
    }
}
