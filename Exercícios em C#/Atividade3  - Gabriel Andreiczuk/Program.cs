using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3, nota4, media;
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
            Console.WriteLine("MEDIA: "+ media);
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
    }
}
