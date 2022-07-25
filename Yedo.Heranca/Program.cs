using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yedo.Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gerente g = new Gerente();
            g.Nome = "Yedo Costa";
            g.Salario = 7000.00;
            g.Usuario = "yedo costa";
            g.Senha = "12345";
            //Console.WriteLine("Digite seu nome: ");
            //g.Nome = Console.ReadLine();

            Telefonista te = new Telefonista();
            te.Nome = "Maria Jose";
            te.Salario = 3000.00;
            te.EstacaoDeTrabalho = 13;

            Secretaria sec = new Secretaria();
            sec.Nome = "Talita Menina";
            sec.Salario = 2000.00;
            sec.Ramal = 10;

            Console.WriteLine("GERENTE");
            Console.WriteLine(g.Nome);
            Console.WriteLine(g.Salario);
            Console.WriteLine(g.Usuario);
            Console.WriteLine(g.Senha);
            Console.WriteLine(g.CalculaBonificacao());
            Console.WriteLine(g.SalarioTotal());

            Console.WriteLine("=====================");
            Console.WriteLine("TELEFONISTA");
            Console.WriteLine(te.Nome);
            Console.WriteLine(te.Salario);
            Console.WriteLine(te.EstacaoDeTrabalho);
            Console.WriteLine(te.CalculaBonificacao());
            Console.WriteLine(te.SalarioTotal());

            Console.WriteLine("======================");
            Console.WriteLine("SECRETARIA");
            Console.WriteLine(sec.Nome);
            Console.WriteLine(sec.Salario);
            Console.WriteLine(sec.Ramal);
            Console.WriteLine(sec.CalculaBonificacao());
            Console.WriteLine(sec.SalarioTotal());

            Console.ReadKey();
        }
    }
}
