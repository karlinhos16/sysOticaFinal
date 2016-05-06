using SysOtica.Conexao;
using SysOtica.Negocio.Classes_Basicas;
using SysOtica.Negocio.Excecoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Negocio.Regras_de_Negocio
{
    public class ProdutoControlador
    {
        ProdutoDados controladorproduto = new ProdutoDados();



        public void verificaPreenchimento(Produto p)
        {

            if (String.IsNullOrEmpty(p.Pr_descricao))
            {
                throw new CampoVazioException("Campo vazio!");
            }
            if (p.Pr_qtd.Equals(""))
            {
                throw new CampoVazioException("Campo quantidade vazio!");
            }

            if (p.Pr_unidade.Equals(""))
            {

                throw new CampoVazioException("Campo unidade não selecionado!");
            }

            if (p.Pr_Categoria.Equals(""))
            {
                throw new CampoVazioException("Campo categoria não selecionado!");
            }
            if (p.Pr_grife.Equals(""))
            {
                throw new CampoVazioException("Campo grife não selecionado!");
            }

            if (p.Pr_valor.Equals(""))
            {
                throw new CampoVazioException("Campo Valor vazio!");
            }
            if (p.Pr_estoqueminimo.Equals(""))
            {
                throw new CampoVazioException("Campo  Estoque vazio!");
            }

        }

        public void ValidarGuid(Produto p)
        {
            if (p == null)
            {
                throw new GuidVazioException("Int vazio ou inválido");
            }

        }

    }
}
