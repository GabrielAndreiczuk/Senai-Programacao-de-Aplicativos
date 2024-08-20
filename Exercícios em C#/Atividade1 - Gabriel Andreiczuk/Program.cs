using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float R1, R2, R3;
            float RT;
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("CALCULO DE RESISTENCIA");
                Console.WriteLine("[1] RESSITENCIA EM SERIE");
                Console.WriteLine("[2] RESISTENCIA EM PARALELO");
                Console.WriteLine("[0] SAIR");
                Console.Write("OPCAO ESCOLHIDA: ");
                opcao = int.Parse(Console.ReadLine());
                switch(opcao)
                {
                    case 0:
                        Console.WriteLine();
                        break;
                    case 1:
                        Console.Clear();
                        Console.WriteLine("===== CASO NAO TENHA O VALOR DA RESISTENCIA DIGITE 0 =====");
                        Console.Write("INFORME O VALOR DA RESISTENCIA 1(R1): ");
                        R1 = float.Parse(Console.ReadLine());
                        if (R1 == 0)
                        {
                            R1 = calc_resistencia();
                        }
                        Console.Write("INFORME O VALOR DA RESISTENCIA 2(R2): ");
                        R2 = float.Parse(Console.ReadLine());
                        if (R2 == 0)
                        {
                            R2 = calc_resistencia();
                        }
                        Console.Write("INFORME O VALOR DA RESISTENCIA 3(R3): ");
                        R3 = float.Parse(Console.ReadLine());
                        if (R3 == 0)
                        {
                            R3 = calc_resistencia();
                        }
                        RT = R1 + R2 + R3;
                        Console.WriteLine("VALOR DA RESISTENCIA TOTAL: " + RT);
                        Console.Write("\nPressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("===== CASO NAO TENHA O VALOR DA RESISTENCIA DIGITE 0 =====");
                        Console.Write("INFORME O VALOR DA RESISTENCIA 1(R1): ");
                        R1 = float.Parse(Console.ReadLine());
                        if (R1 == 0)
                        {
                            R1 = calc_resistencia();
                        }
                        Console.Write("INFORME O VALOR DA RESISTENCIA 2(R2): ");
                        R2 = float.Parse(Console.ReadLine());
                        if (R2 == 0)
                        {
                            R2 = calc_resistencia();
                        }
                        Console.Write("INFORME O VALOR DA RESISTENCIA 3(R3): ");
                        R3 = float.Parse(Console.ReadLine());
                        if (R3 == 0)
                        {
                            R3 = calc_resistencia();
                        }
                        RT = 1 / (1 / R1 + 1 / R2 + 1 / R3);
                        Console.WriteLine("VALOR DA RESISTENCIA TOTAL: " + RT);
                        Console.Write("\nPressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                    default: 
                        Console.WriteLine("OPCAO INVALIDA!");
                        Console.Write("\nPressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                }            
            } while (opcao != 0);
        }
        static float calc_resistencia()
        {
            float V, I;
            Console.WriteLine("INFORME A TENSAO: ");
            V = float.Parse(Console.ReadLine());
            Console.WriteLine("INFORME A CORRENTE: ");
            I = float.Parse(Console.ReadLine());
            Console.WriteLine("RESISTENCIA: "+ V / I);
            return V / I;
        }
    }
}
