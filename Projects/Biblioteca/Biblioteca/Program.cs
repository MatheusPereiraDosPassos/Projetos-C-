using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            var livros = new Livro[]{
                new Livro{nome="Abra a cabeça C#",Autor="Cristiano Araújo",idLivro=1},
                new Livro{nome="Aprendendo Java",Autor="Loiane Mello",idLivro=2},
                new Livro{nome="Um mundo mágico Angular.js", Autor="Cristiano Araújo",idLivro=1},
                new Livro{nome="Conhecendo PHP avançado", Autor="Tanembaum",idLivro=2},
                new Livro{nome="Nunca se esqueça das dicas em HTML",Autor="Pablo Silva",idLivro=3},
                new Livro{nome="Mate a linguagem COBOL com apenas 1 passo",Autor="Bruno Carcers",idLivro=4},
                new Livro{nome="Se esqueça do mal hábito",Autor="Xamebau",idLivro=5},
                new Livro{nome="Google um mundo diferente", Autor="Google",idLivro=6}
            };

            var acervos = new Acervo[]{
                new Acervo{nomeAcervo="Faculdade Senai Cimatec",idAcervo=1},
                new Acervo{nomeAcervo="Senai Dendezeiros",idAcervo=2},
                new Acervo{nomeAcervo="Lauro de Freitas",idAcervo=3},
                new Acervo{nomeAcervo="Piatã",idAcervo=4},
                new Acervo{nomeAcervo="Ribeirao",idAcervo=5},
                new Acervo{nomeAcervo="Amazonas",idAcervo=6}
            };

            var query = from l in livros
                join a in acervos on l.idLivro equals a.idAcervo
                orderby l.nome ascending
                select new {l.nome,l.Autor,a.nomeAcervo};

            foreach (var lista in query){
                Console.WriteLine("- {0} , {1} se encontra no acervo {2} .",lista.nome,lista.Autor,lista.nomeAcervo);
            }
            Console.ReadKey();

        }
    }
}
