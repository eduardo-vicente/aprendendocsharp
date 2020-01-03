using ByteBankRH.Funcionarios;
using ByteBankRH.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankRH
{
    class Program
    {
        static void Main(string[] args)
        {
            // CalcularBonificacao();
            UsarSistema();
            Console.ReadLine();
        }


        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteConta camila = new GerenteConta("326.985.628-89");
            camila.Nome = "Camila";
            camila.Senha = "444";

            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(camila, "444");
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Funcionario pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";

            Funcionario roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";

            Funcionario igor = new Auxiliar("981.198.778-53");
            igor.Nome = "Igor";

            Funcionario camila = new GerenteConta("326.985.628-89");
            camila.Nome = "Camila";

            Funcionario eduardo = new Desenvolvedor("406.976.038-33");
            eduardo.Nome = "Eduardo";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);
            gerenciadorBonificacao.Registrar(eduardo);

            Console.WriteLine("Total de bonificacoes do mês: " + gerenciadorBonificacao.GetTotalBonificacao());

        }

    }
}
//