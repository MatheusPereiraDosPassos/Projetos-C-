using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaCapturandoTeclado
{
    class Program
    {
        static void Main(string[] args)
        {
            string NomePessoa;
            string SobreNome;

            Console.WriteLine("Digite seu Nome:");

            NomePessoa = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("Seu Sobrenome : ");

            SobreNome = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Olá  " + NomePessoa + " " +  SobreNome);

            Console.ReadKey();

        }
    }
}
