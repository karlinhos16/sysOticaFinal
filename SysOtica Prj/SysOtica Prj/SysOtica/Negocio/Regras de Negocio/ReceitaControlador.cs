using SysOtica.Conexao;
using SysOtica.Negocio.Classes_Basicas;
using SysOtica.Negocio.Excecoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysOtica.Negocio.Regras_de_Negocio
{
    public class ReceitaControlador
    {
        ReceitaDados ControladorReceita = new ReceitaDados();
        string caracteres = "^[ a-zA-Z]+$";


        public void VerificaPreenchimento(Receita receita)
        {

            if (String.IsNullOrEmpty(receita.Rc_nomemedico))
            {
                throw new CampoVazioException("campo medico vazio");
            }
            if (String.IsNullOrEmpty(receita.Rc_observacoes))
            {
                throw new CampoVazioException("campo observacoes vazio");
            }
            
        }

        public void validaCampos(Receita receita)
        {
            if (receita.Rc_nomemedico.Length < 5 || (!Regex.IsMatch(receita.Rc_nomemedico, caracteres)))
            {
                throw new CampoVazioException("O campo nome do médico não pode conter números e não poder ter menos que 5 caracteres");
            }
            if (receita.Rc_observacoes.Length < 10 || (!Regex.IsMatch(receita.Rc_observacoes, caracteres)))
            {
                throw new CampoVazioException("O campo observações não pode conter números e não pode ter menos que 10 caracteres");
            }

        }



         
            public void ValidarGuid(Receita receita)
            {

                if (receita == null)
                {
                    throw new GuidVazioException("Int vazio ou inválido");
                }

            }
    }
}
