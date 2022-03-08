using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionais
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 7 - Condicionais");

            int idadeJoao = 18;

            if (idadeJoao.Equals(18)) 
            {
                Console.WriteLine("João possui 18 anos");
            } 
            else
            {
                Console.WriteLine("João não possui 18 anos");
            }

            Console.ReadLine();
        }
    }
}
