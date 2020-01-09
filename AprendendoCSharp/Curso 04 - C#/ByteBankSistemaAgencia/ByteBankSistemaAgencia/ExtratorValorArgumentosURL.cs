using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankSistemaAgencia
{
    public class ExtratorValorArgumentosURL
    {
        public string URL { get; }

        private readonly string _argumentos;

        public ExtratorValorArgumentosURL(string url)
        {
            if (String.IsNullOrEmpty(url))
            {
                throw new ArgumentException("O argumento URL não pode ser nulo ou vazio", nameof(url));
            }

            URL = url;

            int indiceInterrogacao = url.IndexOf('?');
            _argumentos = URL.Substring(indiceInterrogacao + 1);

        }

        // moedaOrigem=real&moedaDestino=dolar
        public string GetValor(string nomeParametro)
        {
                return " ";
        }
    }
}
