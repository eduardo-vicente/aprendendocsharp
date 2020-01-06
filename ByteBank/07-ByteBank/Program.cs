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
                catch (NullReferenceException erro)
                {
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
                //o bloco do try pode lancar um erro
                //se tem bloco try/catch, a excecao nao eh propagada para os outros metodos
                try
                {
                    int resultado = Dividir(10, divisor);
                    Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
                }

                catch(DivideByZeroException erro)
                {
                    Console.WriteLine(erro.Message);
                    Console.WriteLine(erro.StackTrace);
                    Console.WriteLine("Não é possivel fazer uma divisão por 0!");
                }
                
            }

            private static int Dividir(int numero, int divisor)
            {
                ContaCorrente contaCorrente = null;
                Console.WriteLine(contaCorrente.Saldo);
                return numero / divisor;
            }
        }
    }
}

