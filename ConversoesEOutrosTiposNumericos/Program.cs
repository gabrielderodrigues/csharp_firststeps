using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversoesEOutrosTiposNumericos
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto");

            double salario;
            salario = 1200.50;

            int salarioEmInteiro;
            salarioEmInteiro = (int)salario;

            Console.WriteLine("Salário: " + salarioEmInteiro);

            long idade;
            idade = 13000000000;

            Console.Write("Idade: " + idade);

            short quantidadeProdutos;
            quantidadeProdutos = 150;

            Console.WriteLine("Quantidade: "  + quantidadeProdutos);

            Console.ReadLine();
        }
    }
}
