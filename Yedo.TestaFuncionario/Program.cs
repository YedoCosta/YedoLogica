using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yedo.TestaFuncionario
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            f1.nome = "Romulo Senai";
            f1.cargo = "Professor";
            f1.salario = 10800.50;

            Funcionario f2 = new Funcionario();
            f2.nome = "Damares Senai";
            f2.cargo = "Diretora";
            f2.salario = 12500.00;
            Console.WriteLine("================ F1 =============");
            Console.WriteLine(f1.nome);
            Console.WriteLine(f1.cargo);
            Console.WriteLine(f1.salario);
            Console.WriteLine("================ F2 =============");
            Console.WriteLine(f2.nome);
            Console.WriteLine(f2.cargo);
            Console.WriteLine(f2.salario);

            Console.ReadKey();


        }
    }
}
