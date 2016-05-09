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
        private DateTime pv_dtsaida;
        private Decimal pv_qtd;

        public ProdutoVenda()
        {
        }

        public DateTime Pv_dtsaida
        {
            get
            {
                return pv_dtsaida;
            }

            set
            {
                pv_dtsaida = value;
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

        public decimal Pv_qtd
        {
            get
            {
                return pv_qtd;
            }

            set
            {
                pv_qtd = value;
            }
        }
    }
}

