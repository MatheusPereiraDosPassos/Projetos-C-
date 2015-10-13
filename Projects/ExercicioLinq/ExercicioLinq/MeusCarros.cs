using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLinq
{
    class MeusCarros : Carro
    {
        List<Carro> carros = new List<Carro>();

        public void Adicionar()
        {
            carros.Add(new Carro() { Ano = 2015, Cor = "Amarelo", Marca = "Honda", Modelo = "Civic" }); ;
            carros.Add(new Carro() { Ano = 2005, Cor = "Prata", Marca = "Renault", Modelo = "Sandeiro" }); ;
            carros.Add(new Carro() { Ano = 2014, Cor = "Preto", Marca = "Chevrolet", Modelo = "Agile LTZ" }); ;
            carros.Add(new Carro() { Ano = 2013, Cor = "Vermelho", Marca = "Nissan", Modelo = "Hillux" }); ;
            carros.Add(new Carro() { Ano = 2012, Cor = "Branco", Marca = "Citroen", Modelo = "C4 Pallas" }); ;
            carros.Add(new Carro() { Ano = 2009, Cor = "Azul", Marca = "Lamborghini", Modelo = "Lamborghini Aventador" }); ;
            carros.Add(new Carro() { Ano = 2012, Cor = "Cinza", Marca = "Fiat", Modelo = "Fiat Uno" }); ;
        }

        public void imprimir()
        {
            foreach (Carro c in carros)
            {
                Console.WriteLine("MARCA : " + c.Marca + " " + "MODELO: " + c.Modelo + " " + "COR: " + c.Cor + " " + "ANO:" + c.Ano);
            }
        }

        public void ConsultarMarca()
        {
            var Marca =
                 (from Carro in carros
                 where Carro.Marca == "Lamborghini" && Carro.Modelo == "Lamborghini Aventador"
                 select Carro).ToList();

            foreach (Carro c in Marca)
            {
                Console.WriteLine("MARCA : " + c.Marca + " " + "MODELO: " + c.Modelo + " " + "COR: " + c.Cor + " " + "ANO:" + c.Ano);

            }
        }
    }
}

