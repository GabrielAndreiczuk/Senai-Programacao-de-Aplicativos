using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float peso, altura, imc;

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
    }
}
