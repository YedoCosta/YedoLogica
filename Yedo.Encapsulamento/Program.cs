using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yedo.Encapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();
            f.Nome = "Yedo Costa";
            f.Salario = 10000.00;

            Console.WriteLine("Nome do funcionario : " + f.Nome);
            Console.WriteLine("Salario do funcionario: " + f.Salario);

            Console.ReadKey();


        }
    }
}
