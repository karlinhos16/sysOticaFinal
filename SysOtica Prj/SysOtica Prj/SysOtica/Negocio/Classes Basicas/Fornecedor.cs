using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Negocio.Classes_Basicas
{
    public class Fornecedor
    {
        private int fr_id;
        private String fr_razaosocial;
        private String fr_inscricaoestadual;
        private String fr_fantasia;
        private String fr_endereco;
        private String fr_cidade;
        private String fr_uf;
        private String fr_bairro;
        private String fr_cep;
        private String fr_contato;
        private String fr_telefone;
        private String fr_fax;
        private String fr_email;
        private String fr_nomerepresentante;
        private String fr_telefonerepresentante;
        private String fr_celularrepresentante;
        private String fr_observacoes;
        private String fr_cnpj;
        private List<ProdutoFornecedor> pf_id;

        public Fornecedor(int fr_id, string fr_razaosocial, string fr_inscricaoestadual, string fr_fantasia, string fr_endereco, string fr_cidade, string fr_uf, string fr_bairro, string fr_cep, string fr_contato, string fr_telefone, string fr_fax, string fr_email, string fr_nomerepresentante, string fr_telefonerepresentante, string fr_celularrepresentante, string fr_observacoes, string fr_cnpj, List<ProdutoFornecedor> pf_id)
        {
            this.fr_id = fr_id;
            this.fr_razaosocial = fr_razaosocial;
            this.fr_inscricaoestadual = fr_inscricaoestadual;
            this.fr_fantasia = fr_fantasia;
            this.fr_endereco = fr_endereco;
            this.fr_cidade = fr_cidade;
            this.fr_uf = fr_uf;
            this.fr_bairro = fr_bairro;
            this.fr_cep = fr_cep;
            this.fr_contato = fr_contato;
            this.fr_telefone = fr_telefone;
            this.fr_fax = fr_fax;
            this.fr_email = fr_email;
            this.fr_nomerepresentante = fr_nomerepresentante;
            this.fr_telefonerepresentante = fr_telefonerepresentante;
            this.fr_celularrepresentante = fr_celularrepresentante;
            this.fr_observacoes = fr_observacoes;
            this.fr_cnpj = fr_cnpj;
            this.pf_id = new List<ProdutoFornecedor>();
        }

        public Fornecedor()
        {
        }

        public int Fr_id
        {
            get
            {
                return fr_id;
            }

            set
            {
                fr_id = value;
            }
        }

        public string Fr_razaosocial
        {
            get
            {
                return fr_razaosocial;
            }

            set
            {
                fr_razaosocial = value;
            }
        }

        public string Fr_inscricaoestadual
        {
            get
            {
                return fr_inscricaoestadual;
            }

            set
            {
                fr_inscricaoestadual = value;
            }
        }

        public string Fr_fantasia
        {
            get
            {
                return fr_fantasia;
            }

            set
            {
                fr_fantasia = value;
            }
        }

        public string Fr_endereco
        {
            get
            {
                return fr_endereco;
            }

            set
            {
                fr_endereco = value;
            }
        }

        public string Fr_cidade
        {
            get
            {
                return fr_cidade;
            }

            set
            {
                fr_cidade = value;
            }
        }

        public string Fr_uf
        {
            get
            {
                return fr_uf;
            }

            set
            {
                fr_uf = value;
            }
        }

        public string Fr_bairro
        {
            get
            {
                return fr_bairro;
            }

            set
            {
                fr_bairro = value;
            }
        }

        public string Fr_cep
        {
            get
            {
                return fr_cep;
            }

            set
            {
                fr_cep = value;
            }
        }

        public string Fr_contato
        {
            get
            {
                return fr_contato;
            }

            set
            {
                fr_contato = value;
            }
        }

        public string Fr_telefone
        {
            get
            {
                return fr_telefone;
            }

            set
            {
                fr_telefone = value;
            }
        }

        public string Fr_fax
        {
            get
            {
                return fr_fax;
            }

            set
            {
                fr_fax = value;
            }
        }

        public string Fr_email
        {
            get
            {
                return fr_email;
            }

            set
            {
                fr_email = value;
            }
        }

        public string Fr_nomerepresentante
        {
            get
            {
                return fr_nomerepresentante;
            }

            set
            {
                fr_nomerepresentante = value;
            }
        }

        public string Fr_telefonerepresentante
        {
            get
            {
                return fr_telefonerepresentante;
            }

            set
            {
                fr_telefonerepresentante = value;
            }
        }

        public string Fr_celularrepresentante
        {
            get
            {
                return fr_celularrepresentante;
            }

            set
            {
                fr_celularrepresentante = value;
            }
        }

        public string Fr_observacoes
        {
            get
            {
                return fr_observacoes;
            }

            set
            {
                fr_observacoes = value;
            }
        }

        public string Fr_cnpj
        {
            get
            {
                return fr_cnpj;
            }

            set
            {
                fr_cnpj = value;
            }
        }

        public List<ProdutoFornecedor> Pf_id
        {
            get
            {
                return pf_id;
            }

            set
            {
                pf_id = value;
            }
        }
    }
}
