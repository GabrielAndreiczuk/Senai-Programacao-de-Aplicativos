using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            float preco;
            int opcao, parcelas;

            Console.Write("--------------------- FORMA DE PAGAMENTO ---------------------\n\n");
            Console.Write("INFORME O NOME DO PRODUTO: ");
            nome = Console.ReadLine();
            Console.Write("INFORME O PRECO DO PRODUTO: ");
            preco = float.Parse(Console.ReadLine());
            Console.Write("\n[1] A VISTA (DINHEIRO OU PIX) [2] A VISTA (CARTAO DE CREDITO)");
            Console.Write("\n[3] PARCELADO (2 VEZES)       [4] PARCELADO (3 OU MAIS VEZES)");
            Console.Write("\nOPCAO ESCOLHIDA: ");
            opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    preco = (float)(preco * 0.85);
                    Console.Write($"\nVALOR FINAL: R${preco}");
                    break;
                case 2:
                    preco = (float)(preco * 0.9);
                    Console.Write($"\nVALOR FINAL: R${preco}");
                    break;
                case 3:
                    Console.Write($"\nVALOR FINAL: R${preco}");
                    Console.Write($"\n2X DE R${preco/2}");
                    break;
                case 4:
                    Console.Write("\nDESEJA PARCELAR EM QUANTAS VEZES?: ");
                    parcelas = int.Parse(Console.ReadLine());
                    if (parcelas >= 3)
                    {
                        preco = (float)(preco * 1.1);
                        Console.Write($"\nVALOR FINAL: R${preco}");
                        Console.Write($"\n{parcelas} X DE R${preco/parcelas}");
                    }
                    else
                    {
                        Console.Write("\nERRO! ESCOLHA SOMENTE ACIMA DE 3 PARCELAS!");
                    }
                    break;
                default:
                    Console.Write("\nOPCAO INVALIDA!");
                    break;
            }

            Console.WriteLine("\n\nPressione qualquer tecla para continuar. . .");
            Console.ReadKey();
        }
    }
}
