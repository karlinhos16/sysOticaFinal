﻿using SysOtica.Negocio.Classes_Basicas;
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
   public class ProdutoDados : IProdutoDados
    {      
        ConexaoBD conn = new ConexaoBD();


        public void inserirProduto(Produto p)
        {
            try
            {
                //abrir a conexão
                conn.AbrirConexao();
                string sql = "INSERT INTO Produto (pr_descricao, pr_grife, pr_valor, pr_estoqueminimo, pr_unidade, pr_dtentrada, fr_id, ct_id, pr_qtd) values ( @pr_descricao, @pr_grife, @pr_valor, @pr_estoqueminimo, @pr_unidade, @pr_dtentrada, @ct_id, @fr_id, @pr_qtd)";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, conn.cone);

                cmd.Parameters.Add("@pr_descricao", SqlDbType.VarChar);
                cmd.Parameters["@pr_descricao"].Value = p.Pr_descricao;

                cmd.Parameters.Add("@pr_unidade", SqlDbType.VarChar);
                cmd.Parameters["@pr_unidade"].Value = p.Pr_unidade;

                cmd.Parameters.Add("@pr_grife", SqlDbType.VarChar);
                cmd.Parameters["@pr_grife"].Value = p.Pr_grife;

                cmd.Parameters.Add("@pr_valor", SqlDbType.Decimal);
                cmd.Parameters["@pr_valor"].Value = p.Pr_valor;

                cmd.Parameters.Add("@pr_qtd", SqlDbType.Int);
                cmd.Parameters["@pr_qtd"].Value = p.Pr_qtd;

                cmd.Parameters.Add("@pr_estoqueminimo", SqlDbType.Int);
                cmd.Parameters["@pr_estoqueminimo"].Value = p.Pr_estoqueminimo;

                cmd.Parameters.Add("@pr_dtentrada", SqlDbType.Date);
                cmd.Parameters["@pr_dtentrada"].Value = p.Pr_dtentrada;

                cmd.Parameters.Add("@ct_id", SqlDbType.Int);
                cmd.Parameters["@ct_id"].Value = p.Categoria.Ct_id;

                cmd.Parameters.Add("@fr_id", SqlDbType.Int);
                cmd.Parameters["@fr_id"].Value = p.Fornecedor.Fr_id;



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
        public void alterarProduto(Produto p)
        {
            try
            {
                //abrir a conexão
                conn.AbrirConexao();
                string sql = "UPDATE Produto SET  pr_descricao = @pr_descricao, pr_grife = @pr_grife, pr_valor = @pr_valor,pr_qtd = @pr_qtd,pr_estoqueminimo = @pr_estoqueminimo, pr_unidade= @pr_unidade WHERE pr_id = @pr_id";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, conn.cone);

                cmd.Parameters.Add("@pr_id", SqlDbType.Int);
                cmd.Parameters["@pr_id"].Value = p.Pr_id;

                cmd.Parameters.Add("@pr_descricao", SqlDbType.VarChar);
                cmd.Parameters["@pr_descricao"].Value = p.Pr_descricao;

                cmd.Parameters.Add("@pr_unidade", SqlDbType.VarChar);
                cmd.Parameters["@pr_unidade"].Value = p.Pr_unidade;


                cmd.Parameters.Add("@pr_grife", SqlDbType.VarChar);
                cmd.Parameters["@pr_grife"].Value = p.Pr_grife;

                cmd.Parameters.Add("@pr_valor", SqlDbType.Decimal);
                cmd.Parameters["@pr_valor"].Value = p.Pr_valor;

                cmd.Parameters.Add("@pr_qtd", SqlDbType.Int);
                cmd.Parameters["@pr_qtd"].Value = p.Pr_qtd;


                cmd.Parameters.Add("@pr_estoqueminimo", SqlDbType.Int);
                cmd.Parameters["@pr_estoqueminimo"].Value = p.Pr_estoqueminimo;

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
        public void excluirProduto(Produto p)
        {

            try
            {
                //abrir a conexão
                conn.AbrirConexao();
                string sql = "DELETE Produto FROM Produto as p Inner Join Categoria as cat on cat.ct_id = p.ct_id Inner Join Fornecedor as f on f.fr_id = p.fr_id where p.pr_id = p.pr_id";
      

               // string sql = "Delete FROM produto Where pr_id = @pr_id in" +
               //    "(Select produto_fornecedor_fk FROM Produto) and (Select categoria_produto_fk FROM Produto)";


                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, conn.cone);
                cmd.Parameters.Add("@pr_id", SqlDbType.Int);
                cmd.Parameters["@pr_id"].Value = p.Pr_id;
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
        public List<Produto> listarProduto()
        {
            string sql = "SELECT p.pr_id, p.pr_descricao, p.pr_grife, p.pr_valor, p.pr_estoqueminimo, p.pr_qtd, cat.ct_id, f.fr_id FROM Produto as p Inner Join Categoria as cat on cat.ct_id = p.ct_id Inner Join Fornecedor as f on f.fr_id = p.fr_id";
            List<Produto> lista = new List<Produto>();
            Produto p;


            try
            {
                conn.AbrirConexao();
                SqlCommand cmd = new SqlCommand(sql, conn.cone);
                SqlDataReader retorno = cmd.ExecuteReader();

                while (retorno.Read())
                {
                    p = new Produto();
                    p.Pr_id = retorno.GetInt32(retorno.GetOrdinal("pr_id"));
                    p.Pr_descricao = retorno.GetString(retorno.GetOrdinal("pr_descricao"));
                    p.Pr_grife = retorno.GetString(retorno.GetOrdinal("pr_grife"));
                    p.Pr_valor = retorno.GetDecimal(retorno.GetOrdinal("pr_valor"));
                    p.Pr_estoqueminimo = retorno.GetInt32(retorno.GetOrdinal("pr_estoqueminimo"));
                    p.Pr_qtd = retorno.GetInt32(retorno.GetOrdinal("pr_qtd"));
                    p.Categoria.Ct_id = retorno.GetInt32(retorno.GetOrdinal("ct_id"));
                    p.Fornecedor.Fr_id = retorno.GetInt32(retorno.GetOrdinal("fr_id"));

                    lista.Add(p);
                }
                conn.FecharConexao();
                return lista;

            }
           catch (SqlException e)
            {
                throw new BancoDeDadosException("Falha na comunicação com o banco de dados. \n" + e.Message);
            }
        }
        public List<Produto> pesquisarProduto(string pr_descricao)
        {
            string sql = "SELECT p.pr_id, p.pr_descricao, p.pr_grife, p.pr_valor, p.pr_estoqueminimo, p.pr_qtd, cat.ct_id, f.fr_id FROM Produto as p Inner Join Categoria as cat on cat.ct_id = p.ct_id Inner Join Fornecedor as f on f.fr_id = p.fr_id where pr_descricao LIKE @pr_descricao + '%'";

            //"SELECT pr_id, pr_descricao, pr_grife, pr_valor, pr_estoqueminimo, pr_qtd " +
              //           "FROM Produto where pr_descricao LIKE @pr_descricao + '%'";



            List<Produto> lista = new List<Produto>();
            Produto p;

            if (pr_descricao != "")
            {

                try
                {
                    conn.AbrirConexao();
                    SqlCommand cmd = new SqlCommand(sql, this.conn.cone);
                    cmd.Parameters.Add("@pr_descricao", SqlDbType.VarChar, 50).Value = pr_descricao;

                    SqlDataReader retorno = cmd.ExecuteReader();

                    while (retorno.Read())
                    {
                        p = new Produto();
                        p.Pr_id = retorno.GetInt32(retorno.GetOrdinal("pr_id"));
                        p.Pr_descricao = retorno.GetString(retorno.GetOrdinal("pr_descricao"));
                        p.Pr_grife = retorno.GetString(retorno.GetOrdinal("pr_grife"));
                        p.Pr_valor = retorno.GetDecimal(retorno.GetOrdinal("pr_valor"));
                        p.Pr_estoqueminimo = retorno.GetInt32(retorno.GetOrdinal("pr_estoqueminimo"));
                        p.Pr_qtd = retorno.GetInt32(retorno.GetOrdinal("pr_qtd"));
                        p.Categoria.Ct_id = retorno.GetInt32(retorno.GetOrdinal("ct_id"));
                        p.Fornecedor.Fr_id = retorno.GetInt32(retorno.GetOrdinal("fr_id"));

                        lista.Add(p);
                    }


                }
                catch (SqlException e)
                {
                    throw new BancoDeDadosException("Falha na comunicação com o banco de dados. \n" + e.Message);
                }
            }
            conn.FecharConexao();
            return lista;
        }

    }
}
