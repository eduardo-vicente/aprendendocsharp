using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente gabriela = new Cliente();
            ContaCorrente contaGabriela = new ContaCorrente();
            contaGabriela.Depositar(200);


            gabriela.nome = "Gabriela";
            gabriela.cpf = "193.943.933-43";
            gabriela.profissao = "Programadora";


            @Console.WriteLine("Nome: "+ gabriela.nome+"\n"+"CPF: "+gabriela.cpf+"\n"+"Profissao: "+gabriela.profissao+"\n"+"Saldo: "+contaGabriela.saldo);
            Console.ReadLine();
        }
    }
}
