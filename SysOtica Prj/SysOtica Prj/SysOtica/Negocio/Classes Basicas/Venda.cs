using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Negocio.Classes_Basicas
{
    public class Venda
    {
        private int vn_id;
        private Cliente cliente;
        private decimal vn_valor;
        private decimal vn_valortotal;
        private decimal vn_desconto;
        private String vn_formapagamento;
        private List<Receita> listareceita;
        private List<ProdutoVenda> listaprodutovenda;





        public List<Receita> Listareceita
        {
            get { return listareceita; }
            set { listareceita = value; }
        }
        public List<ProdutoVenda> Listaprodutovenda
        {
            get { return listaprodutovenda; }
            set { listaprodutovenda = value; }
        }

        public int Vn_id
        {
            get { return vn_id; }
            set { vn_id = value; }
        }

        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public decimal Vn_valor
        {
            get { return vn_valor; }
            set { vn_valor = value; }
        }

        public decimal Vn_valortotal
        {
            get { return vn_valortotal; }
            set { vn_valortotal = value; }
        }

        public decimal Vn_desconto
        {
            get { return vn_desconto; }
            set { vn_desconto = value; }
        }

        public String Vn_formapagamento
        {
            get { return vn_formapagamento; }
            set { vn_formapagamento = value; }
        }



    }
}