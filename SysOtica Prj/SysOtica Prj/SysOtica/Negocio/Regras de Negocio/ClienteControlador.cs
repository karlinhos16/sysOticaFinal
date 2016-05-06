using SysOtica.Conexao;
using SysOtica.Negocio.Classes_Basicas;
using SysOtica.Negocio.Excecoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SysOtica.Negocio.Regras_de_Negocio
{
    public class ClienteControlador
    {

        public void ValidarCamposVazios(Cliente c)
        {
            if (string.IsNullOrEmpty(c.Cl_nome))
            {
                throw new CampoVazioException("Nome vazio! Digite o nome...");
            }
            if (string.IsNullOrEmpty(c.Cl_cpf))
            {
                throw new CampoVazioException("CPF vazio! Digite o CPF...");
            }
            if (string.IsNullOrEmpty(c.Cl_rg))
            {
                throw new CampoVazioException("RG vazio! Digite o RG...");
            }
            if (string.IsNullOrEmpty(c.Cl_telefone))
            {
                throw new CampoVazioException("Telefone vazio! Digite o telefone...");
            }
            if (string.IsNullOrEmpty(c.Cl_celular))
            {
                throw new CampoVazioException("Celular vazio! Digite o Celular...");
            }
            if (string.IsNullOrEmpty(c.Cl_telefone2))
            {
                throw new CampoVazioException("Telefone2 vazio! Digite o Telefone2...");
            }
            if (string.IsNullOrEmpty(c.Cl_cep))
            {
                throw new CampoVazioException("CEP vazio! Digite o CEP...");
            }
            if (string.IsNullOrEmpty(c.Cl_endereco))
            {
                throw new CampoVazioException("Endereço vazio! Digite o Endereço...");
            }
            if (string.IsNullOrEmpty(c.Cl_numero))
            {
                throw new CampoVazioException("Número vazio! Digite o Número...");
            }
            if (string.IsNullOrEmpty(c.Cl_bairro))
            {
                throw new CampoVazioException("Bairro vazio! Digite o Bairro...");
            }
            if (string.IsNullOrEmpty(c.Cl_cidade))
            {
                throw new CampoVazioException("Cidade vazio! Digite a Cidade...");
            }
            if (string.IsNullOrEmpty(c.Cl_uf))
            {
                throw new CampoVazioException("UF vazio! Digite o UF...");
            }
            if (string.IsNullOrEmpty(c.Cl_email))
            {
                throw new CampoVazioException("Email vazio! Digite o Email...");
            }
            if (string.IsNullOrEmpty(c.Cl_nomepai))
            {
                throw new CampoVazioException("Nome do Pai vazio! Digite o nome do Pai...");
            }

            if (string.IsNullOrEmpty(c.Cl_nomemae))
            {
                throw new CampoVazioException("Nome mãe vazio! Digite o Nome mãe...");
            }
            if (string.IsNullOrEmpty(c.Cl_profissao))
            {
                throw new CampoVazioException("Profissão vazio! Digite o Profissão...");
            }
            if (string.IsNullOrEmpty(c.Cl_observacoes))
            {
                throw new CampoVazioException("Observação vazio! Digite a observação...");
            }

        }

        public void ValidarGuid(Cliente c)
        {
            if (c == null)
            {
                throw new GuidVazioException("Int vazio ou inválido");
            }
        }

    }
}
