using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaBruno = new ContaCorrente(889,1000);
            Console.WriteLine(ContaCorrente.TotalContasCriadas);
            
            ContaCorrente contaGabriela = new ContaCorrente(073, 8881);
            Console.WriteLine(ContaCorrente.TotalContasCriadas);


            Console.ReadLine();

        }
    }
}
