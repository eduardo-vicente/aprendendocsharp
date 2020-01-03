using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaGabriela = new ContaCorrente();
            contaGabriela.agencia = 198;
            contaGabriela.numero = 90059;
            contaGabriela.titular = "Gabriela";
            contaGabriela.saldo = 100;

            Console.WriteLine(contaGabriela);
            Console.ReadLine();

        }
    }
}
