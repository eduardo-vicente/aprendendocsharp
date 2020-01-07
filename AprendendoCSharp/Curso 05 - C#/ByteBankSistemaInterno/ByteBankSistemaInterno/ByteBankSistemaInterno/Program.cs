
using _07_ByteBank;
using ByteBankRH.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankSistemaInterno
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente conta = new ContaCorrente(123123, 1111);
            Designer desi = new Designer("111.111.113-33");

            Console.WriteLine(conta.Agencia);
            Console.WriteLine(desi.CPF);

            Console.ReadLine();
        }
    }
}
