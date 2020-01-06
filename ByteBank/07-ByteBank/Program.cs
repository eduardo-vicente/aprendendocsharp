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
                    Metodo();
                }
                catch (DivideByZeroException erro)
                {
                    Console.WriteLine("Nao eh possivel divisao por 0");
                }
                catch (Exception erro)
                {
                    Console.WriteLine(erro.Message);
                    Console.WriteLine(erro.StackTrace);
                    Console.WriteLine("Aconteceu um erro!");
                }
               
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
                Console.WriteLine("O resultado da divisao de 10 por " + divisor + " é " + resultado);
            }

            private static int Dividir(int numero, int divisor)
            {
                try
                {//se acontece uma excecao, o bloco try nao eh executado e o bloco catch nao retorna nada, precisamos fazer algo para que o catch retorne algo -> throw (controle de fluxo)
                    return numero / divisor;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Exceção com numero igual " + numero + " e divisor igual " + divisor);
                    throw;
                }
                
            }
        }
    }
}

