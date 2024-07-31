using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoIntensivo.Exercicios.Fundamentos
{
    internal class Matrizes
    {
        public static void metodosArray()
        {
            string[] cores = { "Preto", "Branco", "Vermelho", "Azul", "Amarelo" };
            Console.WriteLine($"Tamanho do Vetor: {cores.Length}");
            Console.WriteLine($"Conteúdo do Vetor");
            for (int i = 0; i < cores.Length; i++)
            {
                Console.WriteLine($"{i} => {cores[i]}");
            }
            //Invertendo os valores do vetor
            Console.WriteLine("\nInvertendo os valores do vetor");
            Array.Reverse(cores);
            for (int i = 0; i < cores.Length; i++)
            {
                Console.WriteLine($"{i} => {cores[i]}");
            }
            Console.WriteLine("\nReordenando Vetores");
            Array.Sort(cores);// por ordem alfabetica
            for (int i = 0; i < cores.Length; i++)
            {
                Console.WriteLine($"{i} => {cores[i]}");
            }
            //Procurando um elemento vetor
            Console.WriteLine("\n Buscar no vetor ");
            string corEscolhida;
            Console.WriteLine(" Digite uma cor: ");
            corEscolhida = Console.ReadLine();

            int indice = Array.BinarySearch(cores, corEscolhida);
            Console.WriteLine(indice);
            if (indice >= 0)
            {
                Console.WriteLine($"A cor {corEscolhida} está no indice: {indice}");
            }
            else
            {
                Console.WriteLine("Cor não encontrada!");
            }
            //Procurando um elemento vetor de forma sequencial
            Console.WriteLine("\n Buscar no vetor ");
            Console.WriteLine(" Digite uma cor: ");
            corEscolhida = Console.ReadLine();

            indice = Array.IndexOf(cores, corEscolhida);
            Console.WriteLine(indice);


        }

        //metodosArray();

        void manipulandoMatrizes()
        {
            //Matrizes
            int[,] matriz = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            //exibindo conteúdo de uma matriz
            for (int linha = 0; linha < 3; linha++)
                for (int coluna = 0; coluna < 2; coluna++)
                {
                    Console.Write($"{linha}, {coluna} => {matriz[linha, coluna]}\t");
                }
            Console.WriteLine();
        }


    }
}
