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

        public Venda Venda
        {
            get { return venda; }
            set { venda = value; }
        }
        private Produto produto;


        public Produto Produto
        {
            get { return produto; }
            set { produto = value; }
        }

       
    }
}
