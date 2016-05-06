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
    public class FornecedorControlador
    {
        FornecedoresDados forn = new FornecedoresDados();

        public void VerificaPreenchimento(Fornecedor fr)
        {
            if (String.IsNullOrEmpty(fr.Fr_bairro)) { throw new CampoVazioException("Campo Bairro Vazio"); }
            if (String.IsNullOrEmpty(fr.Fr_celularrepresentante)) { throw new CampoVazioException("Campo Celular Representante Vazio"); }
            if (String.IsNullOrEmpty(fr.Fr_cep)) { throw new CampoVazioException("Campo CEP Vazio"); }
            if (String.IsNullOrEmpty(fr.Fr_cidade)) { throw new CampoVazioException("Campo Cidade Vazio"); }
            if (String.IsNullOrEmpty(fr.Fr_cnpj)) { throw new CampoVazioException("Campo CNPJ Vazio"); }
            if (String.IsNullOrEmpty(fr.Fr_contato)) { throw new CampoVazioException("Campo Contato Vazio"); }
            if (String.IsNullOrEmpty(fr.Fr_email)) { throw new CampoVazioException("Campo E-mail Vazio"); }
            if (String.IsNullOrEmpty(fr.Fr_endereco)) { throw new CampoVazioException("Campo Endereço Vazio"); }
            if (String.IsNullOrEmpty(fr.Fr_fantasia)) { throw new CampoVazioException("Campo Nome Fantasia Vazio"); }
            if (String.IsNullOrEmpty(fr.Fr_fax)) { throw new CampoVazioException("Campo Fax Vazio"); }
            if (String.IsNullOrEmpty(fr.Fr_inscricaoestadual)) { throw new CampoVazioException("Campo Inscrição Estadual Vazio"); }
            if (String.IsNullOrEmpty(fr.Fr_nomerepresentante)) { throw new CampoVazioException("Campo Nome Representante Vazio"); }
            if (String.IsNullOrEmpty(fr.Fr_observacoes)) { throw new CampoVazioException("Campo Observações Vazio"); }
            if (String.IsNullOrEmpty(fr.Fr_razaosocial)) { throw new CampoVazioException("Campo Razão Social Vazio"); }
            if (String.IsNullOrEmpty(fr.Fr_telefone)) { throw new CampoVazioException("Campo Telefone Vazio"); }
            if (String.IsNullOrEmpty(fr.Fr_telefonerepresentante)) { throw new CampoVazioException("Campo Telefone Representante Vazio"); }
            if (String.IsNullOrEmpty(fr.Fr_uf)) { throw new CampoVazioException("Campo UF Vazio"); }

        }


        public void ValidarGuid(Fornecedor fr)
        {
            if (fr == null)
            {
                throw new GuidVazioException("Int vazio ou inválido");
            }

        }

    }
}
