using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yedo.Logica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Uma variável do tipo int chamada numeroDaConta .
            int numeroDaConta;

            // Uma variável do tipo double chamada precoDoProduto .
            double precoDoProduto;

            Console.WriteLine(" Olá Mundo ");

        //===============================================================

        // Declaração com Inicialização
        int numero = 10;

            // Uso da variável
            Console.WriteLine(numero);

            // Outra Declaração com Inicialização
            double preco = 137.6;

            // Uso da variável
            Console.WriteLine("Preço = " + preco);

            //=============================================
           
            int umMaisUm = 1 + 1;           // umMaisUm = 2
            int tresVezesDois = 3 * 2;      // tresVezesDois = 6
            int quatroDivididoPor2 = 4 / 2; // quatroDivididoPor2 = 2
            int seisModuloCinco = 6 % 5;    // seisModuloCinco = 1
            int x = 7;
            x = x + 1 * 2;                        // x = 9
            x = x - 3;                            // x = 6
            x = x / (6 - 2 + (3 * 5) / (16 - 1)); // x = 2

            Console.WriteLine("X = " + x);
          
            //====================================================
            // ATRIBUIÇÂO
            //Os operadores de atribuição são:
             
            int valor = 1; // valor = 1
            valor += 2; // valor = 3
            valor -= 1; // valor = 2
            valor *= 6; // valor = 12
            valor /= 3; // valor = 4
            valor %= 3; // valor = 1

            Console.WriteLine("Valor = " + valor);

            //As instruções acima poderiam ser escritas de outra forma:

            valor = 1; // valor = 1
            valor = valor + 2; // valor = 3
            valor = valor - 1; // valor = 2
            valor = valor * 6; // valor = 12
            valor = valor / 3; // valor = 4
            valor = valor % 3; // valor = 1

            Console.WriteLine("Valor = " + valor);
             
            //====================================================

            // Operador RELACIONAL
            /* Igualdade ==
             • Diferença !=
             • Menor <
             • Menor ou igual <=
             • Maior >
             • Maior ou igual >=
            */
            
            valor = 2;
            bool t = false;
            t = (valor == 2); // t = true
            t = (valor != 2); // t = false
            t = (valor < 2); // t = false
            t = (valor <= 2); // t = true
            t = (valor > 1); // t = true
            t = (valor >= 1); // t = true
             
            /* Operador LOGICO
            • “E” lógico &&
            • “OU” lógico ||
            */
             
            valor = 30;
            bool teste = false;
            teste = valor < 40 && valor > 20; // teste = true
            teste = valor < 40 && valor > 30; // teste = false
            teste = valor > 30 || valor > 20; // teste = true
            teste = valor > 30 || valor < 20; // teste = false
             
            //=============================================================
             
            //      IF/ELSE

            if (preco < 0)
            {
                System.Console.WriteLine("O preço do produto não pode ser negativo ");
            }
            else
            {
                System.Console.WriteLine(" Produto cadastrado com sucesso \n\n");
            }
            
            //=================================================
             
           //      WHILE

           int contador = 0;

           while (contador < 10)
           {
               System.Console.WriteLine(" Bom Dia ");
               contador++;
           }
            
            //====================================
              
            // FOR
            //O comando for é análogo ao while.A diferença entre esses dois comandos é que o for recebe
            //três argumentos.
             
            for (int contador1 = 0; contador1 < 10; contador1++)
            {
                System.Console.WriteLine(" == Bom Dia ");
            }
             
            //==========================================

             
            Console.ReadKey();



        } //  SAI DO MAIN

        }
}

