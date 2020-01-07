using System;

namespace _07_ByteBank
{

    /// <summary>
    /// Esta classe define uma Conta Corrente do banco ByteBank
    /// </summary>


    public class ContaCorrente
    {
        /// <summary>
        /// Calcula a taxa de operacao do banco.
        /// </summary>
        public static double TaxaOperacao { get; private set; }



        public static int TotalContasCriadas { get; private set; }

        public Cliente Titular { get; set; }

        public int ContadorSaquesNaoPerimitidos { get; private set; }
        public int ContadorTransferenciasNaoPermitidas { get; private set; }

        public int Numero { get; }
        public int Agencia { get; }


        private double _saldo = 100;
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }


        /// <summary>
        /// Cria uma instancia de Conta Corrente com os argumentos utilizados.
        /// </summary>
        /// <param name="agencia">Representa o valor da propriedade <see cref="Agencia"/> e deve possuir um valor maior que zero.</param>
        /// <param name="numero">Representa o valor da propriedade <see cref="Numero"/> e deve possuir um valor maior que zero.</param>
        public ContaCorrente(int agencia, int numero)
        {
            if (agencia <= 0)
            {
                throw new ArgumentException("Erro de argumento. A agencia tem que ser maior que 0.", nameof(agencia));
            }
            if (numero <= 0)
            {
                throw new ArgumentException("Erro de argumento. O numero tem que ser maior que 0.", nameof(numero));
            }

            Agencia = agencia;
            Numero = numero;

            TotalContasCriadas++;
            TaxaOperacao = 30 / TotalContasCriadas;
        }


        /// <summary>
        /// Realiza o saque e atualiza o valor das propriedades <see cref="Saldo"/>
        /// </summary>
        /// <exception cref="ArgumentException">Exceção lançada quando um valor negativo é utilizado no argumento <paramref name="valor"/></exception>
        /// <exception cref="SaldoInsuficienteException">Exceção lançada quando o valor de <paramref name="valor"/> é menor que o <see cref="Saldo"/></exception>
        /// <param name="valor"> Representa o valor a ser sacado, deve ser maior que 0 e menor que o <see cref="Saldo"/></param>
        /// 

        public void Sacar(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Erro de argumento. Valor de saque não pode ser negativo.", nameof(valor));
            }
            if (_saldo < valor)
            {
                ContadorSaquesNaoPerimitidos++;
                throw new SaldoInsuficienteException(Saldo, valor);

            }

            _saldo -= valor;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="valor"></param>
        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public void Transferir(double valor, ContaCorrente contaDestino)
        {

            if (valor < 0)
            {
                throw new ArgumentException("Erro de argumento. Valor de transferencia não pode ser negativo.", nameof(valor));
            }
            try
            {
                Sacar(valor);
            }
            catch (SaldoInsuficienteException ex)
            {
                ContadorTransferenciasNaoPermitidas++;
                throw new OperacaoFinanceiraException("Operacao nao realizada", ex);
            }

            contaDestino.Depositar(valor);

        }

    }

}