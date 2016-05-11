using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Negocio.Classes_Basicas
{
    public class Produto
    {

        private int pr_id;
        private String pr_descricao;
        private string pr_unidade;
        private String pr_grife;
        private decimal pr_valor;
        private int pr_qtd;
        private int pr_estoqueminimo;
        private List<Categoria> categoria;
        private ProdutoFornecedor produtoFornecedor;
        private DateTime pr_dtentrada;



        public Produto()
        {
        }

        public int Pr_id
        {
            get
            {
                return pr_id;
            }

            set
            {
                pr_id = value;
            }
        }

        public string Pr_descricao
        {
            get
            {
                return pr_descricao;
            }

            set
            {
                pr_descricao = value;
            }
        }

        public string Pr_unidade
        {
            get
            {
                return pr_unidade;
            }

            set
            {
                pr_unidade = value;
            }
        }


        public string Pr_grife
        {
            get
            {
                return pr_grife;
            }

            set
            {
                pr_grife = value;
            }
        }

        public decimal Pr_valor
        {
            get
            {
                return pr_valor;
            }

            set
            {
                pr_valor = value;
            }
        }

        public int Pr_qtd
        {
            get
            {
                return pr_qtd;
            }

            set
            {
                pr_qtd = value;
            }
        }

        public int Pr_estoqueminimo
        {
            get
            {
                return pr_estoqueminimo;
            }

            set
            {
                pr_estoqueminimo = value;
            }
        }

        public ProdutoFornecedor ProdutoFornecedor
        {
            get
            {
                return produtoFornecedor;
            }

            set
            {
                produtoFornecedor = value;
            }
        }

        public List<Categoria> Categoria
        {
            get
            {
                return categoria;
            }

            set
            {
                categoria = value;
            }
        }

        public DateTime Pr_dtentrada
        {
            get
            {
                return pr_dtentrada;
            }

            set
            {
                pr_dtentrada = value;
            }
        }
    }
}
