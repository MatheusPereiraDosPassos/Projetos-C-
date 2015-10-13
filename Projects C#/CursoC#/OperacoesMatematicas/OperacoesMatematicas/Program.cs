using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacoesMatematicas
{
    class Program
    {
        static void Main(string[] args)
        {

            double numero1;
            double numero2;
            double total;

            Console.Write("Digite o número 1: ");
            
            numero1 = Convert.ToDouble ( Console.ReadLine() );

            Console.Write("Digite o número 2: ");

            numero2 = Convert.ToDouble(Console.ReadLine());

            total = numero1+numero2;
            Console.WriteLine("");

            Console.WriteLine("A soma dos números é : " + total);
            Console.ReadKey();
        }
    }
}
