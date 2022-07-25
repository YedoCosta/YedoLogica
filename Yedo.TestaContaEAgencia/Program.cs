using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yedo.TestaContaEAgencia
{
    internal class Program
    {
        class Agencia
        {
            public int numero;
        }
        class Conta
        {
            public int numero;
            public double saldo;
            public double limite = 100;
            public Agencia agencia;
        }
        static void Main(string[] args)
        {
            Agencia agencia = new Agencia();
            Conta conta = new Conta();

            agencia.numero = 678;
            conta.saldo = 1000.00;
            conta.agencia = agencia;

            Console.WriteLine(conta.agencia.numero);
            Console.WriteLine(conta.saldo);

            Console.ReadKey();

        }
    }
}
