using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplosDeTres
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto Multiplo de Três");

            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}
