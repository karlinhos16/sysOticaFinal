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
    public class ReceitaControlador
    {
        ReceitaDados ControladorReceita = new ReceitaDados();


        public void VerificaPreenchimento(Receita receita)
        {
           
            if (String.IsNullOrEmpty(Convert.ToDateTime(receita.Rc_data).ToString()))
            {
                 throw new CampoVazioException("Campo data da Receita Vazio");
                
            }
            if (String.IsNullOrEmpty(receita.Rc_nomemedico))
            {
                throw new CampoVazioException("Campo nome do médico Vazio");
            }
            if (String.IsNullOrEmpty(receita.Rc_observacoes))
            {
                throw new CampoVazioException("Campo observação vazio");
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
