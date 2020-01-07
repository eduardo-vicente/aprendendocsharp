using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _07_ByteBank;
using ByteBankRH.Funcionarios;

namespace ByteBankSistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(1323, 5441);

            new ContaCorrente(1232, 444);

            string nome = "Guilherme";

            Console.WriteLine(conta.Numero);

            Designer desi = new Designer("123.123.444-24");

            

            Console.WriteLine(desi.CPF);

            

            Console.ReadLine();
        }
    }
}
