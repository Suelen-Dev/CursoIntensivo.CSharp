using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoIntensivo.Exercicios.Fundamentos
{
    internal class Procedimentos
    {
        public static void Multiplos10(int n)
        {
            for (int i = n; i <= n * 10; i+= n) {
                Console.WriteLine($"{i}\t");
            }
        }
    }


}

