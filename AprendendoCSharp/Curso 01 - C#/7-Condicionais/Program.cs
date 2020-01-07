using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7");

            int idadeJoao = 16;
            int quantidadePessoas = 2;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("João possui idade para entrar");
            }

            else
            {
                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("João não possui idade para entrar, mas está acompanhado");
                }
                else
                {
                    Console.WriteLine("Joao nao possui idade para entrar e nao esta acompanhado");
                };

            }

            Console.ReadLine();
        }
    }
}
