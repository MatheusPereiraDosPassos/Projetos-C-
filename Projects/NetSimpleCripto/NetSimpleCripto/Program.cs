using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSimpleCripto
{
    class Program
    {
        static void Main(string[] args)
        {
            string palavra;
            Console.Write("\n Digite uma palavra : ");
            palavra = Console.ReadLine();
            string[] criptoTable = {"01", "02", "03", "04", "05", "06", "07", "08", "09",
                                     "10", "11", "12", "13", "14", "15","16","17","18","19",
                                     "20","21","22","23","24","25","26"};
            string letras = "abcdefghijlmnopqrstuvxwyz";

            //aplica a criptografia
            String palavraCripto = "";

            for (int i = 0; i < palavra.Length; i++)
            {
                palavraCripto += (letras.IndexOf(palavra[i].ToString().ToLower()) + 1).ToString().PadLeft(2, '0');

                
            }
            Console.WriteLine(palavraCripto);
            Console.ReadKey();
        }
    }
}
