using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoPoupancaUsandoFor
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 11 - Calculo Poupança usando For");

            double valorInvestido = 1000;

            for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
            {
                //valorInvestido = valorInvestido + valorInvestido * 0.0036;
                valorInvestido *= 1.0036;

                if (contadorMes == 1)
                {
                    Console.WriteLine("Após " + contadorMes + " mês, você terá R$" + valorInvestido);
                }
                else
                {
                    Console.WriteLine("Após " + contadorMes + " meses, você terá R$" + valorInvestido);
                }
            }

            Console.ReadLine();
        }
    }
}
