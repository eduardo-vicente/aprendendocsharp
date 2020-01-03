

namespace _06_ByteBank
{
    class ContaCorrente
    {

        private Cliente titular;

        public Cliente Titular
        {
            get; set;
        }

        private int agencia;

        public int Agencia
        {
            get; set;
        }

        private int numero;

        public int Numero
        {
            get; set;
        }

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