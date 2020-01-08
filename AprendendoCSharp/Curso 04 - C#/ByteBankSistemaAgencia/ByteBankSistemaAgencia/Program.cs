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
            string url = "pagina?moedaOrigem=real&moedaDestino=dolar";


            string textoVazio = "";
            string textoNulo = null;
            string textoQualquer = "asfasfdasdfsa";

            Console.WriteLine(string.IsNullOrEmpty(textoVazio));
            Console.WriteLine(string.IsNullOrEmpty(textoNulo));
            Console.WriteLine(string.IsNullOrEmpty(textoQualquer));

            Console.ReadLine();

        }


    }

}
