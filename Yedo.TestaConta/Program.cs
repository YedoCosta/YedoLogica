using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yedo.TestaConta
{
    internal class Program
    {
        class Conta
        {
            public int numero;
            public double saldo;
            public double limite = 100;

            public void deposita(double valor)
            {
                this.saldo += valor;
            }
            public void saca(double valor)
            {
                this.saldo -= valor;
            }
            public void ImprimeExtrato()
            {
                System.Console.WriteLine(" SALDO : " + this.saldo);
            }
            public double ConsultaSaldoDisponivel()
            {
                return this.saldo + this.limite;
            }

        }

        static void Main(string[] args)
        {
            //teste que imprima os atributos de um objeto da classe Conta logo após a sua criação

            Conta c = new Conta();
            c.deposita(1000);


            Console.WriteLine(c.numero);
            Console.WriteLine(c.saldo);
            Console.WriteLine(c.limite);

            //teste que imprima os atributos de um objeto da classe Conta logo após atribuir valores

            Conta c1 = new Conta();
            c1.numero = 1234;
            c1.deposita(2000);
            //c1.saldo = 1000;
            c1.limite = 500;
            c1.ImprimeExtrato();
            c1.saca(1000);
            c1.ImprimeExtrato();
            double saldoDisponivelc1 = c1.ConsultaSaldoDisponivel();

            Conta c2 = new Conta();
            c2.numero = 5678;
            c2.deposita(3000);
            c2.ImprimeExtrato();
            c2.saca(2000);
            c2.ImprimeExtrato();
            //c2.saldo = 2000;
            c2.limite = 250;
            double saldoDisponivelc2 = c2.ConsultaSaldoDisponivel();



            Console.WriteLine("==========={ C1 }===============");
            Console.WriteLine(c1.numero);
            Console.WriteLine(c1.saldo);
            Console.WriteLine(c1.limite);
            Console.WriteLine(" SALDO DISPONÍVEL : " + saldoDisponivelc1);
            Console.WriteLine("==========={ C2 }==============");
            Console.WriteLine(c2.numero);
            Console.WriteLine(c2.saldo);
            Console.WriteLine(c2.limite);
            Console.WriteLine(" SALDO DISPONÍVEL : " + saldoDisponivelc2);

            Console.ReadKey();
        }
    }
}
