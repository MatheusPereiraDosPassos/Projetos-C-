using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro
{
    class Cliente : Pessoa {

        private Pessoa pessoa;

        public class Cliente(Pessoa pessoa, String nome , String cpf ){
            this.Pessoa = Pessoa;
        }

    }
}
