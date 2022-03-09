using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatorial
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto Fatorial");

            int fatorial = 1;

            for (int i = 1; i < 11; i++)
            {
                fatorial *= 1;
                Console.WriteLine("Fatorial de " + i + " = " + fatorial);
            }

            Console.ReadLine();
        }
    }
}
