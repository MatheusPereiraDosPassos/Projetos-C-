using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro
{
    public abstract class  Pessoa
    {
        private String nome;

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private String cpf;

        public String Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
    }
}
