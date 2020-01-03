using ByteBankRH.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankRH.Sistemas
{
    public abstract class Autenticavel : Funcionario
    {
        public Autenticavel(double salario, string cpf) : base(3000, cpf)
        {
            Console.WriteLine("Criando FUNCIONARIO");
        }

        public string Senha { get; set; }

        public bool Autenticar (string senha)
        {
            return Senha == senha;
        }
    }
}
