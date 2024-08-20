using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int loop = 0, opcao;
            float valor, resultado;

            do
            {
                Console.Clear();
                Console.Write("------------------ CONVERTER TEMPERATURA ------------------\n");
                Console.Write("\n[1] CELCIUS PARA FAHREINHEIT   [2] FAHREINHEIT PARA CELCIUS");
                Console.Write("\n[3] CELCIUS PARA KEVIN         [4] KELVIN PARA CELCIUS");
                Console.Write("\n[0] SAIR DO SISTEMA");
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
    }
}
