using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaracteresETextos
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e textos");

            char primeiraLetra = 'a';
            // "" para textos e "" para caracteres
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura Cursos de Tecnologia " + 2022;
            Console.WriteLine(titulo);

            string[] cursosProgramacao = { ".NET", "Java", "Javascript", "Typescript" };
            Console.WriteLine(cursosProgramacao.Count());

            Console.ReadLine();
        }
    }
}
