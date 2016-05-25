using SysOtica.Negocio.Classes_Basicas;
using SysOtica.Negocio.Excecoes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                string sql = "INSERT INTO Venda (cl_id, vn_receita, vn_valortotal, vn_desconto, vn_formapagamento, vn_dtsaida ) VALUES ( @cl_id, @rc_id, @vn_valortotal, @vn_desconto, @vn_formapagamento, @vn_dtsaida) SELECT SCOPE_IDENTITY()";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, conn.cone);

                cmd.Parameters.Add("@cl_id", SqlDbType.Int);
                cmd.Parameters["@cl_id"].Value = v.Cliente.Cl_id;

                cmd.Parameters.Add("@vn_receita", SqlDbType.Int);
                cmd.Parameters["@vn_receita"].Value = v.Vn_receita;

                cmd.Parameters.Add("@vn_valortotal", SqlDbType.Decimal);
                cmd.Parameters["@vn_valortotal"].Value = v.Vn_valortotal;

                cmd.Parameters.Add("@vn_desconto", SqlDbType.Decimal);
                cmd.Parameters["@vn_desconto"].Value = v.Vn_desconto;

                cmd.Parameters.Add("@vn_formapagamento", SqlDbType.VarChar);
                cmd.Parameters["@vn_formapagamento"].Value = v.Vn_formapagamento;

                cmd.Parameters.Add("@vn_dtsaida", SqlDbType.Date);
                cmd.Parameters["@vn_dtsaida"].Value = v.Vn_dtsaida;


                Int32 vnId = Convert.ToInt32(cmd.ExecuteScalar());




                foreach (ProdutoVenda pv in v.Listaitens)
                {
                    ConexaoBD conn1 = new ConexaoBD();

                    conn1.AbrirConexao();

                    string sqlitens = "INSERT INTO Produtovenda (vn_id, pr_id,pv_qtd, pv_preco) VALUES ( @vn_id, @pr_id,@pv_qtd, @pv_preco)";
                    SqlCommand cmd1 = new SqlCommand(sqlitens, conn.cone);


                    cmd1.Parameters.Add("@pr_id", SqlDbType.Int);
                    cmd1.Parameters["@pr_id"].Value = pv.Produto.Pr_id;

                    cmd1.Parameters.Add("@pv_qtd", SqlDbType.Int);
                    cmd1.Parameters["@pv_qtd"].Value = pv.Pv_qtd;

                    cmd1.Parameters.Add("@pv_preco", SqlDbType.Decimal);
                    cmd1.Parameters["@pv_preco"].Value = pv.Pv_preco;

                    cmd1.Parameters.Add("@vn_id", SqlDbType.Int);
                    cmd1.Parameters["@vn_id"].Value = vnId;

                    //int recordsInserted = cmd.ExecuteNonQuery();
                    cmd1.ExecuteNonQuery();
                    cmd1.Dispose();
                    conn1.FecharConexao();

                }


                //liberando a memoria 
                cmd.Dispose();


                if (conn.State == System.Data.ConnectionState.Open)
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
