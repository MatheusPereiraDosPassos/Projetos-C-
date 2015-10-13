using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLinq
{
    class Program
    {
        public static void Main()
        {
            MeusCarros c = new MeusCarros();

            c.Adicionar();
           // c.imprimir();
            c.ConsultarMarca();
            Console.ReadKey();
        }
    }
}
