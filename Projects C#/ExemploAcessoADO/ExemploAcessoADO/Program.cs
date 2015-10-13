using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploAcessoADO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome da categoria : ");
            String nome = Console.ReadLine();
            Inserir(nome);

            SqlConnection conn = new SqlConnection("Data Source=MATTHEW-PC;Initial Catalog=ControleEventos;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT ID,NOME FROM CATEGORIA",conn);
            conn.Open();
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read()){
                Console.WriteLine("Categoria: {0}",r["Nome"].ToString());
            }
            Console.ReadKey();
            conn.Close();

        }
        public static void Inserir(String nome)
        {
            SqlConnection conn = new SqlConnection("Data Source=MATTHEW-PC;Initial Catalog=ControleEventos;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("INSERT INTO Categoria (Nome) VALUES (@nomeCategoria)", conn);
            cmd.Parameters.AddWithValue("@nomeCategoria", nome);

            conn.Open();
            cmd.ExecuteNonQuery();
            Console.ReadKey();
            conn.Close();
        }
    }
}
