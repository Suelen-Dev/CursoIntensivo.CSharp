using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoIntensivo.Exercicios.Fundamentos
{
    internal class Vetores
    {
        void ExibirOrdem(int valor1, int valor2)
        {
            int menor, maior;

            if (valor1 < valor2)
            {
                menor = valor1;
                maior = valor2;
            }
            else
            {
                maior = valor1;
                menor = valor2;
            }
            for (int i = menor; menor <= maior; menor++)
            {
                Console.WriteLine($"{menor}");
            }

        }
        //ExibirOrdem(2, 8);

        void exibirVetor(int[] v)
        {
            for (int i = 0; i < v.Length; i++)
            {
                Console.WriteLine($"{i} => {v[i]}");
            }

        }

        int[] vetor = { 98, 45, 12, 87, 16 };
        //exibirVetor(vetor);
    }
}
