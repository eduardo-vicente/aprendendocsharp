using System;

namespace _07_ByteBank
{
    class ContaCorrente
    {

        public static double TaxaOperacao { get; private set; }

        public static int TotalContasCriadas { get; private set; }

        public Cliente Titular { get; set; }

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

        public ContaCorrente(int agencia, int numero)
        {
            if (agencia <= 0)
            {
                throw new ArgumentException("Erro de argumento. A agencia tem que ser maior que 0.", nameof(agencia));
            }
            if(numero <= 0)
            {
                throw new ArgumentException("Erro de argumento. O numero tem que ser maior que 0.", nameof(numero));
            }

            Agencia = agencia;
            Numero = numero;
            TaxaOperacao = 30 / TotalContasCriadas;
            TotalContasCriadas++;
        }

        public bool Sacar(double valor)
        {

            if (this._saldo < valor)
            {
                return false;
            }

            this._saldo -= valor;
            return true;

        }

        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this._saldo < valor)
            {
                return false;
            }

            this._saldo -= valor;
            contaDestino.Depositar(valor);
            return true;


        }

    }

}