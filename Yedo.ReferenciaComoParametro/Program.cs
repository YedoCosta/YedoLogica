using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yedo.ReferenciaComoParametro
{
    /*
     Crie uma pasta chamada complementar dentro da pasta orientacao-a-objetos. Os arquivos a
        seguir devem ser salvos nessa pasta.
     Crie uma classe que represente as contas do banco. Essa classe deve conter três atributos:
        numero, limite e saldo.
     Crie uma classe chamada TestaConta. Dentro dessa classe, crie um objeto do tipo Conta. 
     Receba do teclado os valores para os atributos numero, saldo e limite. 
     Depois crie um laço que permita que o usuário escolha a operação que ele deseja realizar. 
     As operações que ele pode realizar são: depositar, sacar e imprimir extrato.
     */
    internal class Program
    {
        class Conta
        {
            public int numero;
            public double limite;
            public double saldo;

            public void Transfere(Conta Destino, double valor)
            {
                this.saldo -= valor;
                Destino.saldo = valor;
            }
            /*public void deposito(double valord)
            {
                this.saldo += valord;
            }*/
        }

        static void Main(string[] args)
        {
            Conta origem = new Conta();
            origem.saldo = 1000;
            Console.WriteLine(origem.saldo);
            Console.WriteLine("=======================");

            Conta destino = new Conta();

            origem.Transfere(destino, 200);

            Console.WriteLine(destino.saldo);
            Console.WriteLine(origem.saldo);
            Console.WriteLine("=======================");

            Conta dep = new Conta();
            dep.saldo = 2000;
            origem.saldo += dep.saldo;

            Console.WriteLine(dep.saldo);
            Console.WriteLine(origem.saldo);
            Console.WriteLine("=======================");

            origem.Transfere(destino, 600);

            Console.WriteLine(destino.saldo);
            Console.WriteLine(origem.saldo);


            Console.ReadKey();
        }
    }
}
