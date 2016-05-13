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
    public class CategoriaDados : ICategoriaDados
    {
        ConexaoBD conn = new ConexaoBD();


        public void inserir(Categoria c)
        {
            try
            {
                //abrir a conexão
                conn.AbrirConexao();
                string sql = "INSERT INTO Categoria (ct_nome, pr_id) values ( @ct_nome, pr_id)";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, conn.cone);

                cmd.Parameters.Add("@ct_nome", SqlDbType.VarChar);
                cmd.Parameters["@ct_nome"].Value = c.Ct_nome;

                cmd.Parameters.Add("@pr_id", SqlDbType.VarChar);
                cmd.Parameters["@pr_id"].Value = c.Produto.Pr_id;


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


            public List<Categoria> pesquisaCategoria()
            {
            List<Categoria> lista = new List<Categoria>();


            string sql = "Select ct_id, ct_nome from Categoria";
            try
            {
                conn.AbrirConexao();
                SqlCommand cmd = new SqlCommand(sql, conn.cone);
                SqlDataReader retorno = cmd.ExecuteReader();

                while (retorno.Read())
                {
                    Categoria cat = new Categoria();
                    cat.Ct_id = retorno.GetInt32(retorno.GetOrdinal("ct_id"));
                    cat.Ct_nome = retorno.GetString(retorno.GetOrdinal("ct_nome"));


                    lista.Add(cat);
                }
                conn.FecharConexao();
                return lista;

            }
            catch (SqlException e)
            {
                throw new BancoDeDadosException("Falha na comunicação com o banco de dados. \n" + e.Message);
            }


        }
        
    }
}
