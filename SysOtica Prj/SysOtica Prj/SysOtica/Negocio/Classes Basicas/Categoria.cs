﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Negocio.Classes_Basicas
{
    public class Categoria
    {
        private int ct_id;
        private String ct_nome;

        public Categoria(int ct_id, string ct_nome)
        {
            this.ct_id = ct_id;
            this.ct_nome = ct_nome;
        }

        public Categoria()
        {
           
                
            // TODO: Complete member initialization
        }


        public int Ct_id
        {
            get
            {
                return ct_id;
            }

            set
            {
                ct_id = value;
            }
        }

        public string Ct_nome
        {
            get
            {
                return ct_nome;
            }

            set
            {
                ct_nome = value;
            }
        }
    }
}
