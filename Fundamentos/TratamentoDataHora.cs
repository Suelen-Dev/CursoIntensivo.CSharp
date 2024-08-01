using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoIntensivo.Exercicios.Fundamentos
{
    internal class TratamentoDataHora
    {
        void dataDia()
        {
            DateTime dataAtual = DateTime.Now;
            Console.WriteLine(dataAtual);

            DateTime dataHoje = new DateTime(2022, 07, 02);
            Console.WriteLine(dataHoje);

            DateTime dataHoraHoje = new DateTime(2022, 07, 02, 21, 16, 59);
            Console.WriteLine(dataHoraHoje);
            Console.ReadLine();

        }
        dataDia();
    }
}
