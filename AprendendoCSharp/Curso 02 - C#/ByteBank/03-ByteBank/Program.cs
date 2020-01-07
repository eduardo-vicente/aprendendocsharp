using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaGabriela = new ContaCorrente();

            contaGabriela.titular = "Gabriela";
            contaGabriela.agencia = 863;
            contaGabriela.numero = 863342;

            ContaCorrente contaGabrielaSouza = new ContaCorrente();

            contaGabrielaSouza.titular = "Gabriela Souza";
            contaGabrielaSouza.agencia = 863;
            contaGabrielaSouza.numero = 863342;

            Console.WriteLine(contaGabriela == contaGabrielaSouza);
            Console.ReadLine(); 
        }
    }
}
