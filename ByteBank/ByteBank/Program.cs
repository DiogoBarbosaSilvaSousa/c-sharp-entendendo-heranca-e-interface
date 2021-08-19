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
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            // Start - Conta
            Funcionario carlos = new Funcionario(2000, "546.897.987-26");

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

            Console.WriteLine("********************* Conta "+ carlos.Nome +" *****************************");
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

            Console.ReadLine();

        }
    }
}
