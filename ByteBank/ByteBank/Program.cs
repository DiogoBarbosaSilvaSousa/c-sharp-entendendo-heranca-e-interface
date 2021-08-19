using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularBonificacao();

            Console.ReadLine();

        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("981.198.778-53");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";
            
            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total de bonificações do mês: " + gerenciadorBonificacao.GetTotalBonificacao());

        }


        public static void TestResult()
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            // Start - Conta
            Auxiliar carlos = new Auxiliar("546.897.987-26");

            carlos.Nome = "Carlos";

            Console.WriteLine("Antigo salário do " + carlos.Nome + " " + carlos.Salario);
            carlos.AumentarSalario();
            Console.WriteLine("Novo salário do " + carlos.Nome + " " + carlos.Salario);

            gerenciador.Registrar(carlos);

            Console.WriteLine("");

            // End - Conta

            // Start - Conta
            Diretor roberta = new Diretor("123.546.897-20");

            roberta.Nome = "Roberta";

            gerenciador.Registrar(roberta);

            Console.WriteLine("");
            // End - Conta

            Console.WriteLine("********************* Conta " + carlos.Nome + " *****************************");
            Console.WriteLine("Nome: " + carlos.Nome);
            Console.WriteLine("CPF: " + carlos.CPF);
            Console.WriteLine("Salário: " + carlos.Salario);
            Console.WriteLine("Bonificação: " + carlos.GetBonificacao());
            Console.WriteLine("");

            Console.WriteLine("********************* Conta " + roberta.Nome + " *****************************");
            Console.WriteLine("Nome: " + roberta.Nome);
            Console.WriteLine("CPF: " + roberta.CPF);
            Console.WriteLine("Salário: " + roberta.Salario);
            Console.WriteLine("Bonificação: " + roberta.GetBonificacao());
            Console.WriteLine("");

            Console.WriteLine("**************************************************");

            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());
            Console.WriteLine("Total de funcionários: " + Funcionario.TotalDeFuncionarios);
            Console.WriteLine("");
        }
    }
}
