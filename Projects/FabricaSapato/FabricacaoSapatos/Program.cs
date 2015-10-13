using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricacaoSapatos
{
    class Program
    {
        static void Main(string[] args)
        {
            var sapato = new Sapato[]{
                new Sapato{numero=35,iDsapato=1},
                new Sapato{numero= 39, iDsapato=2},
                new Sapato{numero=42, iDsapato=2},
                new Sapato{numero=40, iDsapato=3},
                new Sapato{numero=38, iDsapato=3}
           };

            var minhafabrica = new Fabrica[]{
                new Fabrica{marca="Rainha", iDfabrica=1},
                new Fabrica{marca="AllStar", iDfabrica=2},
                new Fabrica{marca="Nike", iDfabrica=3}
            };

            var meupreco = new Precos[]{
                new Precos{preco=149.90,iDpreco=1},
                new Precos{preco=189.90, iDpreco=2},
                new Precos{preco=219.90, iDpreco=3}
            };

            var query = from s in sapato
                        join f in minhafabrica on s.iDsapato equals f.iDfabrica 
                        join p in meupreco on s.iDsapato equals p.iDpreco
                        select new { s.numero, f.marca , p.preco};
  
            foreach (var group in query)
            {
                Console.WriteLine("Minha fábrica tem o numero {0}, da marca {1} custa R${2}. ", group.numero, group.marca, group.preco);
            }
            Console.ReadKey();
        }
    }
}
