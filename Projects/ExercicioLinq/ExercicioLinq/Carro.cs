using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLinq
{
    class Carro
    {
       
        private string marca;

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        private int ano;

        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }
        private string cor;

        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }
        private string modelo;

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
    }
}
