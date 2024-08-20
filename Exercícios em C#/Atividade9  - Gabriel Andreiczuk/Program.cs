using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao, loop = 0;
            do
            {
                Console.Clear();
                Console.Write("--------------------- MENU DE ATIVIDADES ---------------------\n");
                Console.Write("\n[1] CALCULO DE 3 RESISTENCIAS  [2] CALCULO DE 'N' RESISTENCIAS");
                Console.Write("\n[3] CALCULO DE MEDIA 4 NOTAS   [4] CALCULO DE MEDIA 'N' NOTAS ");
                Console.Write("\n[5] CALCULO DE COMBUSTIVEL     [6] CALCULO DE TEMPERATURA");
                Console.Write("\n[7] CALCULO DE IMC             [8] FORMA DE PAGAMENTO");
                Console.Write("\n[0] SAIR DO SISTEMA");
                Console.Write("\n\nOPCAO ESCOLHIDA: ");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 0:
                        loop = 1;
                        break;
                    case 1:
                        atividade1();
                        break;
                    case 2:
                        atividade2();
                        break;
                    case 3:
                        atividade3();
                        break;
                    case 4:
                        atividade4();
                        break;
                    case 5:
                        atividade5();
                        break;
                    case 6:
                        atividade6();
                        break;
                    case 7:
                        atividade7();
                        break;
                    case 8:
                        atividade8();
                        break;
                }
            } while (loop == 0);

            Console.WriteLine("\n\nPressione qualquer tecla para continuar. . .");
            Console.ReadKey();
        }
        static void atividade1()
        {
            float R1, R2, R3;
            float RT;
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("CALCULO DE RESISTENCIA");
                Console.WriteLine("[1] RESISTENCIA EM SERIE");
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
        static void atividade2()
        {
            float[] R = new float[25];
            float RT, soma_res;
            int opcao, resistencias;
            do
            {
                Console.Clear();
                Console.WriteLine("CALCULO DE RESISTENCIA");
                Console.WriteLine("[1] RESISTENCIA EM SERIE");
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
                            Console.WriteLine($"RESISTÊNCIA {i + 1}R{i + 1}: {R[i]}");
                            RT += R[i];
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
                            Console.Write($"INFORME O VALOR DA RESISTÊNCIA R{i + 1}: ");
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
                        RT = 1 / soma_res;
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
        static void atividade3()
        {
            float nota1, nota2, nota3, nota4, media;
            Console.Clear();
            Console.WriteLine("CALCULO DE MEDIA\n");
            Console.Write("INFORME A PRIMEIRA NOTA: ");
            nota1 = float.Parse(Console.ReadLine());
            Console.Write("INFORME A SEGUNDA NOTA: ");
            nota2 = float.Parse(Console.ReadLine());
            Console.Write("INFORME A TERCEIRA NOTA: ");
            nota3 = float.Parse(Console.ReadLine());
            Console.Write("INFORME A QUARTA NOTA: ");
            nota4 = float.Parse(Console.ReadLine());
            media = (nota1 + nota2 + nota3 + nota4) / 4;
            Console.WriteLine("MEDIA: " + media);
            if (media >= 7)
            {
                Console.WriteLine("\nO ALUNO ESTA APROVADO!");
            }
            else
            {
                Console.WriteLine("\nO ALUNO ESTA REPROVADO!");
            }
            Console.WriteLine("Pressione qualquer tecla para continuar. . .");
            Console.ReadKey();
        }
        static void atividade4()
        {
            float[] nota = new float[25];
            float media, soma = 0;
            int qtd_notas, i;

            Console.Clear();
            Console.Write("CALCULO DE MEDIA\n\n");
            Console.Write("INFORME A QUANTIDADE DE NOTAS: ");
            qtd_notas = int.Parse(Console.ReadLine());
            for (i = 0; i < qtd_notas; i++)
            {
                Console.Write($"INFORME A NOTA {i + 1}: ");
                nota[i] = float.Parse(Console.ReadLine());
                soma = soma + nota[i];
            }
            Console.Clear();
            Console.Write("CALCULO DE MEDIA\n");
            for (i = 0; i < qtd_notas; i++)
            {
                Console.Write($"\nNOTA {i + 1}: {nota[i]}");
            }
            media = soma / qtd_notas;
            Console.Write($"\n\nMEDIA: {media:0.00}");
            if (media >= 7)
            {
                Console.WriteLine("\nO ALUNO ESTA APROVADO!");
            }
            else
            {
                Console.WriteLine("\nO ALUNO ESTA REPROVADO!");
            }
            Console.WriteLine("\nPressione qualquer tecla para continuar. . .");
            Console.ReadKey();
        }
        static void atividade5()
        {
            float distancia, consumoG, consumoE, consumoD,
                  precoG, precoE, precoD,
                  tamanho,
                  total_valor, total_consumo, total_tanques;

            Console.Clear();
            Console.Write("------------ CALCULO DE COMBUSTIVEL ------------\n\n");
            Console.Write("INFORME A DISTANCIA PERCORRIDA EM KM: ");
            distancia = float.Parse(Console.ReadLine());
            Console.Write("INFORME O TAMANHO DO TANQUE DE COMBUSTIVEL EM L: ");
            tamanho = float.Parse(Console.ReadLine());
            Console.Write("INFORME O CONSUMO MEDIO EM KM/L DO VEICULO NA GASOLINA: ");
            consumoG = float.Parse(Console.ReadLine());
            Console.Write("INFORME O PRECO DA GASOLINA EM REAIS: ");
            precoG = float.Parse(Console.ReadLine());
            Console.Write("INFORME O CONSUMO MEDIO EM KM/L DO VEICULO NO ETANOL: ");
            consumoE = float.Parse(Console.ReadLine());
            Console.Write("INFORME O PRECO DO ETANOL EM REAIS: ");
            precoE = float.Parse(Console.ReadLine());
            Console.Write("INFORME O CONSUMO MEDIO EM KM/L DO VEICULO NO DIESEL: ");
            consumoD = float.Parse(Console.ReadLine());
            Console.Write("INFORME O PRECO DO DIESEL EM REAIS: ");
            precoD = float.Parse(Console.ReadLine());

            Console.Clear();
            total_valor = (distancia / consumoG) * precoG;
            total_consumo = total_valor / precoG;
            total_tanques = total_valor / (tamanho * precoG);
            Console.Write("------------ CALCULO DE COMBUSTIVEL ------------\n\n");
            Console.Write("COMBUSTIVEL: GASOLINA");
            Console.Write($"\nVALOR TOTAL GASTO ------ R${total_valor:F2}");
            Console.Write($"\nCONSUMO R$/LITRO ------- {total_consumo:F2}");
            Console.Write($"\nTANQUES UTILIZADOS ----- {total_tanques:F2}");
            total_valor = (distancia / consumoE) * precoE;
            total_consumo = total_valor / precoE;
            total_tanques = total_valor / (tamanho * precoE);
            Console.Write("\n\n");
            Console.Write("COMBUSTIVEL: ETANOL");
            Console.Write($"\nVALOR TOTAL GASTO ------ R${total_valor:F2}");
            Console.Write($"\nCONSUMO R$/LITRO ------- {total_consumo:F2}");
            Console.Write($"\nTANQUES UTILIZADOS ----- {total_tanques:F2}");
            total_valor = (distancia / consumoD) * precoD;
            total_consumo = total_valor / precoD;
            total_tanques = total_valor / (tamanho * precoD);
            Console.Write("\n\n");
            Console.Write("COMBUSTIVEL: DIESEL");
            Console.Write($"\nVALOR TOTAL GASTO ------ R${total_valor:F2}");
            Console.Write($"\nCONSUMO R$/LITRO ------- {total_consumo:F2}");
            Console.Write($"\nTANQUES UTILIZADOS ----- {total_tanques:F2}");
            Console.WriteLine("\n\nPressione qualquer tecla para continuar. . .");
            Console.ReadKey();
        }
        static void atividade6()
        {
            int loop = 0, opcao;
            float valor, resultado;

            do
            {
                Console.Clear();
                Console.Write("------------------ CONVERTER TEMPERATURA ------------------\n");
                Console.Write("\n[1] CELCIUS PARA FAHREINHEIT   [2] FAHREINHEIT PARA CELCIUS");
                Console.Write("\n[3] CELCIUS PARA KEVIN         [4] KELVIN PARA CELCIUS");
                Console.Write("\n[0] VOLTAR AO MENU INICIAL");
                Console.Write("\n\nOPCAO ESCOLHIDA: ");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 0:
                        loop = 1;
                        break;
                    case 1:
                        valor = informar_Valor();
                        resultado = (float)((valor * 1.8) + 32);
                        Console.Write($"\nRESULTADO: {valor:1} C = {resultado:1} F\n\n");
                        Console.WriteLine("Pressione qualquer tecla para continuar. . .");
                        Console.ReadKey();
                        break;
                    case 2:
                        valor = informar_Valor();
                        resultado = (float)((valor - 32) / 1.8);
                        Console.Write($"\nRESULTADO: {valor:0.00} F = {resultado:0.00} C\n\n");
                        Console.WriteLine("Pressione qualquer tecla para continuar. . .");
                        Console.ReadKey();
                        break;
                    case 3:
                        valor = informar_Valor();
                        resultado = (float)(valor + 273.15);
                        Console.Write($"\nRESULTADO: {valor:0.00} C = {resultado:0.00} K\n\n");
                        Console.WriteLine("Pressione qualquer tecla para continuar. . .");
                        Console.ReadKey();
                        break;
                    case 4:
                        valor = informar_Valor();
                        resultado = (float)(valor - 273.15);
                        Console.Write($"\nRESULTADO: {valor:0.00} K = {resultado:0.00} C\n\n");
                        Console.WriteLine("Pressione qualquer tecla para continuar. . .");
                        Console.ReadKey();
                        break;
                }
            } while (loop == 0);
        }
        static float informar_Valor()
        {
            float valor;
            Console.Write("\nINFORME O VALOR DA TEMPERATURA: ");
            valor = float.Parse(Console.ReadLine());
            return valor;
        }
        static void atividade7()
        {
            float peso, altura, imc;
            
            Console.Clear();
            Console.Write("---------- CALCULO DE IMC ----------\n");
            Console.Write("INFORME SEU PESO: ");
            peso = float.Parse(Console.ReadLine());
            Console.Write("INFORME SUA ALTURA: ");
            altura = float.Parse(Console.ReadLine());
            imc = (float)(peso / Math.Pow(altura, 2));
            Console.Write($"\n\nSEU IMC: {imc:F2}");

            if (imc >= 40)
            {
                Console.Write("\nSITUACAO: OBESIDADE GRAU III(MORBIDA)");
            }
            else if (imc >= 35)
            {
                Console.Write("\nSITUACAO: OBESIDADE GRAU II(SEVERA)");
            }
            else if (imc >= 30)
            {
                Console.Write("\nSITUACAO: OBESIDADE GRAU I");
            }
            else if (imc >= 25)
            {
                Console.Write("\nLEVEMENTE ACIMA DO PESO");
            }
            else if (imc >= 18.6)
            {
                Console.Write("\nPESO IDEAL(PARABENS)");
            }
            else
            {
                Console.Write("\nABAIXO DO PESO");
            }
            Console.WriteLine("\n\nPressione qualquer tecla para continuar. . .");
            Console.ReadKey();
        }
        static void atividade8()
        {
            Console.Clear();
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
                    Console.Write($"\n2X DE R${preco / 2}");
                    break;
                case 4:
                    Console.Write("\nDESEJA PARCELAR EM QUANTAS VEZES?: ");
                    parcelas = int.Parse(Console.ReadLine());
                    if (parcelas >= 3)
                    {
                        preco = (float)(preco * 1.1);
                        Console.Write($"\nVALOR FINAL: R${preco}");
                        Console.Write($"\n{parcelas} X DE R${preco / parcelas}");
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
