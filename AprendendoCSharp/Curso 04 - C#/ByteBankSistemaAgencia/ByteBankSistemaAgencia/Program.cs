using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _07_ByteBank;
using ByteBankRH.Funcionarios;
using Humanizer;

namespace ByteBankSistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataFimPagamento = new DateTime(2020,02,09);

            DateTime dataCorrente = DateTime.Now;

            TimeSpan diferenca = TimeSpan.FromMinutes(40);
                
                
                
                // dataFimPagamento - dataCorrente;

            string mensagem = "Vencimento em "
                              + TimeSpanHumanizeExtensions.Humanize(diferenca);
            
            Console.WriteLine(mensagem);

            Console.ReadLine();
        }


    }

}
