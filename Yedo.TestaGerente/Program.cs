using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yedo.TestaGerente
{
    internal class Program
    {
        class Gerente
        {
            public string nome;
            public double salario;

            public void AumentaSalario()
            {
                this.salario += this.salario * 0.1;

            }

            public void AumentaSalario(double taxa)
            {
                this.salario += this.salario * taxa;
            }
        }
        static void Main(string[] args)
        {
            Gerente g = new Gerente();
            g.nome = "Teste de Aumento";
            g.salario = 1000.00;

            Console.WriteLine(" Nome... : " + g.nome);
            Console.WriteLine(" Salário : " + g.salario);

            Console.WriteLine("\r\n Aumentando o salário em 10% ");
            g.AumentaSalario();

            Console.WriteLine(" Salário : " + g.salario);

            Console.WriteLine("\r\n Aumentando o salário em 30% ");
            g.AumentaSalario(0.3);

            Console.WriteLine(" Salário : " + g.salario);

            Console.ReadKey();
        }
    }
}
