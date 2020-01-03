using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            cliente.nome = "Guilherme";
            cliente.cpf = "434.123.131-44";
            cliente.profissao = "Desenvolvedor";



            conta.Titular = cliente;
            conta.Agencia = 199;

            Console.WriteLine(conta.Titular.nome);
            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Saldo);
            Console.ReadLine();
        }
    }
}
