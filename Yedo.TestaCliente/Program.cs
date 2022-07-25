using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yedo.TestaCliente
{
    internal class Program
    {
        class Cliente
        {
            public string nome;
            public int codigo;
        }
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente();
            c1.nome = " Rafael Cosentino ";
            c1.codigo = 1;

            Cliente c2 = new Cliente();
            c2.nome = " Jonas Hirata ";
            c2.codigo = 2;

            Console.WriteLine(c1.nome);
            Console.WriteLine(c1.codigo);

            Console.WriteLine(c2.nome);
            Console.WriteLine(c2.codigo);

            Console.ReadKey();
        }
    }
}
