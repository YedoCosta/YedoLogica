using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yedo.TestaTurma
{
    internal class Program
    {
        class Turma
        {
            public string periodo;
            public string serie;
            public string sigla;
            public string tipoEnsino;
        }
        static void Main(string[] args)
        {
            Turma turma1 = new Turma();
            turma1.periodo = "Matutino";
            turma1.serie = "Primeira";
            turma1.sigla = "FMP1";
            turma1.tipoEnsino = "Fundamental";

            Turma turma2 = new Turma();
            turma2.periodo = "Matutino";
            turma2.serie = "Primeira";
            turma2.sigla = "SMP2";
            turma2.tipoEnsino = "Secundário";

            Console.WriteLine("================== TURMA 1 =================");
            Console.WriteLine(turma1.periodo);
            Console.WriteLine(turma1.serie);
            Console.WriteLine(turma1.sigla);
            Console.WriteLine(turma1.tipoEnsino);

            Console.WriteLine("================== TURMA 2 =================");
            Console.WriteLine(turma2.periodo);
            Console.WriteLine(turma2.serie);
            Console.WriteLine(turma2.sigla);
            Console.WriteLine(turma2.tipoEnsino);

            Console.ReadKey();

        }
    }
}
