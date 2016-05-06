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
        private String pr_categoria;
        private string pr_unidade;
        private String pr_grife;
        private decimal pr_valor;
        private int pr_qtd;
        private int pr_estoqueminimo;       
        private List<ProdutoFornecedor> items_pf;
        private List<ProdutoVenda> pv_id;
    

        public Produto(int pr_id, string pr_descricao, string pr_categoria, string pr_unidade, string pr_grife, decimal pr_valor, int pr_qtd, int pr_estoqueminimo, int fr_id, List<ProdutoFornecedor> items_pf, List<ProdutoVenda> pv_id )
        {
            this.Pr_id = pr_id;
            this.Pr_descricao = pr_descricao;           
            this.pr_categoria = pr_categoria;
            this.pr_unidade = pr_unidade;
            this.Pr_grife = pr_grife;
            this.Pr_valor = pr_valor;
            this.Pr_qtd = pr_qtd;
            this.Pr_estoqueminimo = pr_estoqueminimo;                    
            this.items_pf = new List<ProdutoFornecedor>();
            this.Pv_id = new List<ProdutoVenda>();          
        }

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
     

        public string Pr_Categoria
        {
            get
            {
                return pr_categoria;
            }

            set
            {
                pr_categoria = value;
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

        public List<ProdutoFornecedor> Items_pf
        {
            get
            {
                return items_pf;
            }

            set
            {
                items_pf = value;
            }
        }

        public List<ProdutoVenda> Pv_id
        {
            get
            {
                return pv_id;
            }

            set
            {
                pv_id = value;
            }
        }
    
    }
}
