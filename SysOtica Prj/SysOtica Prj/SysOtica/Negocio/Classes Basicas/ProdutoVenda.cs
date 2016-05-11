using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Negocio.Classes_Basicas
{
    public class ProdutoVenda
    {
        private List<Produto> listaproduto;
        private Venda venda;

        public List<Produto> Listaproduto
        {
            get
            {
                return listaproduto;
            }

            set
            {
                listaproduto = value;
            }
        }

        public Venda Venda
        {
            get
            {
                return venda;
            }

            set
            {
                venda = value;
            }
        }
    }
}

