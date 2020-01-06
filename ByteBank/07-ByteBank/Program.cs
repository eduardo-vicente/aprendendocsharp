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
                    ContaCorrente conta = new ContaCorrente(456, 5013);
                    conta.Depositar(50);
                    Console.WriteLine(conta.Saldo);
                    conta.Sacar(500);
                    Console.WriteLine(conta.Saldo);
                }
                catch (ArgumentException ex)
                {
                    if (ex.ParamName == "numero")
                    {

                    }
                    Console.WriteLine("Argumento com problema: " + ex.ParamName);
                    Console.WriteLine("Ocorreu uma excecao de argumento do tipo ArgumentException");
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                // Metodo();

                Console.WriteLine("Execucao finalizada. Tecle enter para sair");
                Console.ReadLine();
            }
            //Teste com a cadeia de chamada:
            //Metodo -> TestaDivisao -> Dividir
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

