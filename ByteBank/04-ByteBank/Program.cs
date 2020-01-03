using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaBruno = new ContaCorrente();

            contaBruno.titular = "Bruno";
            bool resultadoSaque = contaBruno.Sacar(50);
            Console.WriteLine(contaBruno.titular);
            Console.WriteLine(contaBruno.saldo);
            Console.WriteLine(resultadoSaque);


            contaBruno.Depositar(550);
            Console.WriteLine(contaBruno.saldo);


            ContaCorrente contaGabriela = new ContaCorrente();

            contaGabriela.titular = "Gabriela";
            

            Console.WriteLine("Conta do bruno: " + contaBruno.saldo);
            Console.WriteLine("Conta da gabriela: " + contaGabriela.saldo);




            bool resultadoTransferencia = contaGabriela.Transferir(100, contaBruno);
            Console.WriteLine("Conta do bruno: " + contaBruno.saldo);
            Console.WriteLine("Conta da gabriela: " + contaGabriela.saldo);

            Console.WriteLine("Resultado transferencia: " + resultadoTransferencia);

            Console.ReadLine();
        }
    }
}
