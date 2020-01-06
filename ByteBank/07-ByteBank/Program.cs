using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    namespace ByteBank
    {
        class Program
        {
            static void Main(string[] args)
            {
                try
                {
                    ContaCorrente conta1 = new ContaCorrente(132, 1234);
                    ContaCorrente conta2 = new ContaCorrente(9913, 666);
                    conta1.Transferir(10000, conta2);

                }
                catch (OperacaoFinanceiraException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.StackTrace);

                    Console.WriteLine("Informações da INNER EXCEPTION (exceção interna):");

                    Console.WriteLine(e.InnerException.Message);
                    Console.WriteLine(e.InnerException.StackTrace);
                }
                Console.WriteLine("Execucao finalizada. Tecle enter para sair");
                Console.ReadLine();
            }
            private static void Metodo()
            {
                TestaDivisao(0);
            }

            private static void TestaDivisao(int divisor)
            {
                int resultado = Dividir(10, divisor);
                Console.WriteLine("Resultado da divisao de 10 por " + divisor + " é " + resultado);
            }

            private static int Dividir(int numero, int divisor)
            {
                //se acontece uma excecao, o bloco try nao eh executado e o bloco catch nao retorna nada, precisamos fazer algo para que o catch retorne algo -> throw (controle de fluxo)
                try
                {
                    return numero / divisor;
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Erro no calculo: " + ex.Message);
                    throw;
                }
            }
        }
    }
}

