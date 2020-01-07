using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _07_ByteBank;


namespace ByteBankSistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(1323, 5441);

            Console.WriteLine(conta.Numero);
            Console.ReadLine();
        }
    }
}
