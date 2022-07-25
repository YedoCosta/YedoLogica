using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yedo.TestaCartaoDeCredito
{
    internal class Program
    {
        class Cliente
        {
            public string nome;
        }
        class CartaoDeCredito
        {
            public int numero;
            public string dataDeValidade;
            public Cliente cliente;

            public CartaoDeCredito()
            {
                numero = 0;
            }

            public CartaoDeCredito(int numero)
            {
                this.numero = numero;
            }
        }
        class Agencia
        {
            public int numero;

            public Agencia(int numero)
            {
                this.numero = numero;
            }
        }
        class Conta
        {
            public int ctagencia;
            public Agencia agencia;

            public Conta(Agencia agencia)
            {
                this.agencia = agencia;
            }
        }
        static void Main(string[] args)
        {
            Cliente c = new Cliente();
            c.nome = "Romulo Andrade";

            CartaoDeCredito cdc1 = new CartaoDeCredito();
            cdc1.numero = 111111;
            cdc1.dataDeValidade = " 01/01/2013 ";
            cdc1.cliente = c;

            CartaoDeCredito cdc2 = new CartaoDeCredito();
            cdc2.numero = 222222;
            cdc2.dataDeValidade = " 01/01/2014 ";

            Console.WriteLine(cdc1.numero);
            Console.WriteLine(cdc1.dataDeValidade);
            Console.WriteLine(cdc1.cliente.nome);

            Console.WriteLine(cdc2.numero);
            Console.WriteLine(cdc2.dataDeValidade);

            //==========================================

            Console.WriteLine("\r\n ===========================================");

            CartaoDeCredito cd1 = new CartaoDeCredito(12345);

            Agencia ag1 = new Agencia(678);
            Agencia ag2 = new Agencia(444);

            Conta ct1 = new Conta(ag1);

            Console.WriteLine("Cartão de Crédito: " + cd1.numero);
            Console.WriteLine("Agencia: " + ag1.numero);
            Console.WriteLine("Agencia: " + ag2.numero);
            Console.WriteLine("Conta: " + ct1.agencia.numero);


            Console.ReadKey();
        }
    }
}
