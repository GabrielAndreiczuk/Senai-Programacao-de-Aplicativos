using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float distancia, consumoG, consumoE, consumoD,
                  precoG, precoE, precoD,
                  tamanho,
                  total_valor, total_consumo, total_tanques;

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
    }
}
