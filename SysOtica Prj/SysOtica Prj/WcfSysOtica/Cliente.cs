using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfSysOtica
{
    [DataContract]
    public class Cliente
    {
        [DataMember]
        public int cl_id { get; set; }
        [DataMember]
        public String cl_nome { get; set; }
        [DataMember]
        public DateTime cl_datanascimento { get; set; }
        [DataMember]
        public String cl_cpf { get; set; }
        [DataMember]
        public String cl_rg { get; set; }
        [DataMember]
        public String cl_telefone { get; set; }
        [DataMember]
        public String cl_celular { get; set; }
        [DataMember]
        public String cl_telefone2 { get; set; }
        [DataMember]
        public String cl_cep { get; set; }
        [DataMember]
        public String cl_endereco { get; set; }
        [DataMember]
        public String cl_numero { get; set; }
        [DataMember]
        public String cl_bairro { get; set; }
        [DataMember]
        public String cl_cidade { get; set; }
        [DataMember]
        public String cl_email { get; set; }
        [DataMember]
        public String cl_nomepai { get; set; }
        [DataMember]
        public String cl_nomemae { get; set; }
        [DataMember]
        public String cl_profissao { get; set; }
        [DataMember]
        public String cl_observacoes { get; set; }
        [DataMember]
        public String cl_uf { get; set; }
    }
}
