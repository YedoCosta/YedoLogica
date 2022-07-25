using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yedo.TestaAluno
{
    internal class Program
    {
        class Turma
        {
            public string sigla;
        }
        class Aluno
        {
            public string nome;
            public int RG;
            public string dataNascimento;
            public Turma turma;
        }
        static void Main(string[] args)
        {
            Turma turma = new Turma();
            turma.sigla = "SMP1";

            Aluno aluno1 = new Aluno();
            aluno1.turma = turma;
            aluno1.nome = " Yedo Costa ";
            aluno1.RG = 1234;
            aluno1.dataNascimento = "21/12/1960";

            Aluno aluno2 = new Aluno();
            aluno2.nome = "Costa Martins";
            aluno2.RG = 4321;
            aluno2.dataNascimento = "09/09/2019";

            Console.WriteLine(aluno1.nome);
            Console.WriteLine(aluno1.RG);
            Console.WriteLine(aluno1.dataNascimento);
            Console.WriteLine(aluno1.turma.sigla);

            Console.WriteLine("\r\n"+aluno2.nome);
            Console.WriteLine(aluno2.RG);
            Console.WriteLine(aluno2.dataNascimento);

            Console.ReadKey();
        }
    }
}
