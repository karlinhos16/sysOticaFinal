using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Negocio.Classes_Basicas
{
    public class ProdutoVenda
    {
        private Venda venda;
        private List<Produto> listaproduto;

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
    }
}
