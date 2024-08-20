using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] R = new float [25];
            float RT, soma_res;
            int opcao, resistencias;
            do
            {
                Console.Clear();
                Console.WriteLine("CALCULO DE RESISTENCIA");
                Console.WriteLine("[1] RESSITENCIA EM SERIE");
                Console.WriteLine("[2] RESISTENCIA EM PARALELO");
                Console.WriteLine("[0] SAIR");
                Console.Write("OPCAO ESCOLHIDA: ");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 0:
                        Console.WriteLine();
                        break;
                    case 1:
                        Console.Clear();
                        Console.WriteLine("=====              MÍNIMO 1 MÁXIMO 25               ======");
                        Console.Write("INSIRA O NÚMERO DE RESISTÊNCIAS: ");
                        resistencias = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("===== CASO NAO TENHA O VALOR DA RESISTENCIA DIGITE 0 =====");
                        for (int i = 0; i < resistencias; i++)
                        {
                            Console.Write($"INFORME O VALOR DA RESISTÊNCIA R{i + 1}: "); 
                            R[i] = float.Parse(Console.ReadLine());
                            if (R[i] == 0)
                            {
                                R[i] = calc_resistencia();
                            }
                        }
                        RT = 0;
                        Console.Clear();
                        Console.WriteLine("CÁLCULO DE RESISTÊNCIA EM SÉRIE\n");
                        for (int i = 0; i < resistencias; i++)
                        {
                            Console.WriteLine($"RESISTÊNCIA {i+1}R{i+1}: {R[i]}");
                            RT+= R[i];
                        }

                        Console.WriteLine("VALOR DA RESISTENCIA TOTAL: " + RT);
                        Console.Write("\nPressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("=====              MÍNIMO 1 MÁXIMO 25               ======");
                        Console.Write("INSIRA O NÚMERO DE RESISTÊNCIAS: ");
                        resistencias = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("===== CASO NAO TENHA O VALOR DA RESISTENCIA DIGITE 0 =====");
                        for (int i = 0; i < resistencias; i++)
                        {
                            Console.Write($"INFORME O VALOR DA RESISTÊNCIA R{i+1}: ");
                            R[i] = float.Parse(Console.ReadLine());
                            if (R[i] == 0)
                            {
                                R[i] = calc_resistencia();
                            }
                        }
                        RT = 0;
                        Console.Clear();
                        Console.WriteLine("CÁLCULO DE RESISTÊNCIA PARALELA\n");
                        soma_res = 0;
                        for (int i = 0; i < resistencias; i++)
                        {
                            Console.WriteLine($"RESISTÊNCIA {i + 1}(R{i + 1}): {R[i]}");
                            soma_res = soma_res + (1 / R[i]);
                        }
                        RT = 1/soma_res;
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
            Console.WriteLine("RESISTENCIA: " + V / I);
            return V / I;
        }
    }
}
