using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorInvestido = 1000;

            Console.WriteLine("Executando projeto 11 - calcula poupanca");

            for (int contadorMes = 1; contadorMes <=12; contadorMes++)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Apos " + contadorMes + " meses voce tera R$" + valorInvestido);
            }

            Console.ReadLine();
        }
    }
}
