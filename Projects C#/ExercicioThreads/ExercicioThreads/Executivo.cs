using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioThreads
{
    class Executivo
    {
        public void Imprimir()
        {
            int contador = 0;
            for (int i = 0; i < 500; i++)
            {
                contador++;
                for (int j = i; j <= i; j++)
                {
                    Console.WriteLine("Olá");
                    Console.WriteLine("Threads!");
                }
            }
            Console.WriteLine(contador);
            Console.ReadKey();
        }
        public void ImprimeOla()
        {
            for (int i = 0; i < 500; i++)
            {
                Console.WriteLine("Olá");
            }
        }
        public void ImprimeThreads()
        {
            for (int i = 0; i < 500; i++)
            {
                Console.WriteLine("Threads!");
            }
            Console.ReadKey();
        }
    }
}
