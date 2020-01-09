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

            
            string palavra = "moedaOrigem=real&moedaDestino=dolar";
            string nomeArgumento = "moedaDestino";

            int indicePalavra = palavra.IndexOf(nomeArgumento);

            Console.WriteLine(indicePalavra);

            Console.WriteLine("Tamanho da string nomeArgumento: " + nomeArgumento.Length);

            Console.WriteLine(palavra);
            Console.WriteLine(palavra.IndexOf(nomeArgumento));
            Console.WriteLine(palavra.Substring(indicePalavra));
            Console.WriteLine(palavra.Substring(indicePalavra + nomeArgumento.Length + 1));





            Console.ReadLine();


            // ------------------- Testando Null Or Empty
            //string textoVazio = "";
            //string textoNulo = null;
            //string textoQualquer = "asfasfdasdfsa";
            //Console.WriteLine(String.IsNullOrEmpty(textoVazio));
            //Console.WriteLine(String.IsNullOrEmpty(textoNulo));
            //Console.WriteLine(String.IsNullOrEmpty(textoQualquer));

            //Console.ReadLine();

        }


    }

}
