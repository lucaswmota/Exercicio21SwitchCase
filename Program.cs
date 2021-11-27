using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio21SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Escolha uma das opções: " +
                "\n (A) - Assalariado." +
                "\n (C) - Comissionado." +
                "\n (H) - Horista.");
            string tipo = Console.ReadLine().ToUpper();

            switch (tipo)
            {
                case "A":
                    Console.WriteLine("Informe o valor do salario: ");
                    double salario = double.Parse(Console.ReadLine());

                    Console.WriteLine("Informe o valor do desconto referente a impostos.");
                    double imposto = double.Parse(Console.ReadLine());

                    salario -= (imposto / 100) * salario;

                    Console.WriteLine("O Valor do salario com desconto de " + imposto + " % é de: " + salario.ToString("C"));
                    break;

                case "C":
                    Console.WriteLine("Informe o salario do funcionario");
                    salario = double.Parse(Console.ReadLine());

                    Console.WriteLine("Informe o valor da venda realizada pelo funcionario: ");
                    double venda = double.Parse(Console.ReadLine());

                    Console.WriteLine("Informe a porcentagem de comissão: ");
                    double comissao = double.Parse(Console.ReadLine());

                    salario += (comissao / 100) * venda;

                    Console.WriteLine("O Salario final com comissão é de: " + salario.ToString("C"));
                    break;

                case "H":
                    Console.WriteLine("Informe a quantidade de horas realizada pelo funcionario: ");
                    double horas = double.Parse(Console.ReadLine());

                    Console.WriteLine("Informe o valor da hora: ");
                    double valorHora = double.Parse(Console.ReadLine());

                    salario = horas * valorHora;

                    Console.WriteLine("O Salario do funcionario baseado nas horas é de: " + salario.ToString("C"));
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
