using System;
using System.Globalization;
using System.Threading;

namespace Milhas_aereas
{
    class Program
    {
        static void Main(string[] args)


        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Opçoes das empresas parceiras");
            Console.WriteLine("1 - Tudo Azul");
            Console.WriteLine("2 - Latm Pass");
            Console.WriteLine("3 - Smiles");
            Console.WriteLine("4 - Tap and Go");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("*** quantidade minima de 1.000 milhas***");
            Console.WriteLine("selecione uma opção: ");
            var opcao = short.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1: CotacaoAzul(); break;
                case 3: CotacaoSmiles(); break;
                case 2: CoatacaoLatam(); break;
                case 4: CotacaoTap(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;

            }

        }

        static void CotacaoAzul()
        {
            Console.Clear();
            var valorMilhaAzul = 0.02;
            Console.WriteLine("digite a quantidade de milhas:");
            var quantidadeMilhas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            VerificaQuantidade(quantidadeMilhas, valorMilhaAzul);


        }

        static void CotacaoSmiles()
        {
            Console.Clear();
            var valorMilhaSmiles = 0.0139;
            Console.WriteLine("digite a quantidade de milhas");
            var quantidadeMilhas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            VerificaQuantidade(quantidadeMilhas, valorMilhaSmiles);

        }

        static void CoatacaoLatam()
        {
            Console.Clear();
            var valorMilhaLatam = 0.015;
            Console.WriteLine("digite a quantidade de milhas");
            var quantidadeMilhas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            VerificaQuantidade(quantidadeMilhas, valorMilhaLatam);
        }

        static void CotacaoTap()
        {
            Console.Clear();
            var valorMilhaTap = 0.023;
            Console.WriteLine("digite a quantidade de milhas");
            var quantidadeMilhas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            VerificaQuantidade(quantidadeMilhas, valorMilhaTap);


        }

        static void VerificaQuantidade(double quantidadeMilhas, double valorMilhas)
        {
            if (quantidadeMilhas < 1000)
            {
                Console.WriteLine("operação invalida");
                Thread.Sleep(3500);
                Menu();
            }
            else
            {
                var valorCotacao = valorMilhas * quantidadeMilhas;

                Console.WriteLine($"valor da cotação: {valorCotacao.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))} reais");
            }

        }
    }

}



