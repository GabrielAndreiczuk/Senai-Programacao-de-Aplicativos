using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] nota = new float[25];
            float media, soma = 0;
            int qtd_notas, i;

            Console.Write("CALCULO DE MEDIA\n\n");
            Console.Write("INFORME A QUANTIDADE DE NOTAS: ");
            qtd_notas = int.Parse(Console.ReadLine());
            for (i = 0; i < qtd_notas; i++)
            {
                Console.Write($"INFORME A NOTA {i+1}: ");
                nota[i] = float.Parse(Console.ReadLine());
                soma = soma + nota[i];
            }
            Console.Clear();
            Console.Write("CALCULO DE MEDIA\n");
            for (i = 0; i < qtd_notas; i++)
            {
                Console.Write($"\nNOTA {i+1}: {nota[i]}");
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
    }
}
