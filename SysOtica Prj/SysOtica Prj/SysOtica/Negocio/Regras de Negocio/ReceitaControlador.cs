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
            /*if (receita.Rc_lodesferico.Equals("") || receita.Rc_loeesferico.Equals("") || receita.Rc_podesferico.Equals("") || receita.Rc_poeesferico.Equals(""))
            {
                throw new CampoVazioException("Campos Esfericos Vazios");
            }
            if (receita.Rc_lodcilindrico.Equals("") || receita.Rc_loecilindrico.Equals("") || receita.Rc_podcilindrico.Equals("") || receita.Rc_poecilindrico.Equals(""))
            {
                throw new CampoVazioException("Campos cilindricos Vazios");
            }
            if (receita.Rc_lodeixo.Equals("") || receita.Rc_loeeixo.Equals("") || receita.Rc_podeixo.Equals("") || receita.Rc_poeeixo.Equals(""))
            {
                throw new CampoVazioException("Campos eixos Vazios");
            }
            if (receita.Rc_lodaltura.Equals("") || receita.Rc_loealtura.Equals("") || receita.Rc_podaltura.Equals("") || receita.Rc_poealtura.Equals(""))
            {

                throw new CampoVazioException("Campos alturas Vazios");
            }*/

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
