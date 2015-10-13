using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var carros = new Carro[]
            {
                new Carro{Modelo="i30", iDFabrica=1},
                new Carro{Modelo="HB20", iDFabrica=1},
                new Carro{Modelo="Fiesta", iDFabrica=2},
                new Carro{Modelo="Fox", iDFabrica=3},
                new Carro{Modelo="Gol", iDFabrica=3},
            };
            var minhafabrica = new Fabrica[]
            {
                new Fabrica{Nome="Hyundai", ID=1},
                new Fabrica{Nome="Ford", ID=2},
                new Fabrica{Nome="Volkswagen", ID=3}
            };

            var query = from c in carros
                        join f in minhafabrica on c.iDFabrica equals f.ID
                        select new { c.Modelo, f.Nome };

            foreach (var group in query)
            {
                Console.WriteLine("{0} vende {1}", group.Nome, group.Modelo);
            }
            Console.ReadKey();
        }
    }
}
