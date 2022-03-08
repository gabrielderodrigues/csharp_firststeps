using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtribuicaoDeVariaveis
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 6 - Atribução de Variáveis");

            int idade = 32;
            int idadeGabriel = idade;

            idade = 20;

            Console.WriteLine(idadeGabriel);

            Console.ReadLine();
        }
    }
}
