using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Negocio.Classes_Basicas
{
    public class ProdutoVenda
    {
        private int pv_id;
        private List<Produto> pr_id;
        private Venda vn_id;
        private DateTime pv_dtsaida;

        public ProdutoVenda()
        {
        }

        public int Pv_id
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

        public List<Produto> Pr_id1
        {
            get { return pr_id; }
            set { pr_id = value; }
        }

        public Venda Vn_id
        {
            get
            {
                return vn_id;
            }

            set
            {
                vn_id = value;
            }
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
    }
}
