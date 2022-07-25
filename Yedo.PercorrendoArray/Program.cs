using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yedo.PercorrendoArray
{
    internal class Program
    {
 
        static void Main(string[] args)
        {
            int[] numeros = new int[100];
            numeros[0] = 136;
            numeros[99] = 17;

            for (int i = 0; i < 100; i++)
            {
                numeros[i] = i;
                numeros[0] = 136;
                numeros[99] = 17;
                Console.WriteLine(numeros[i]);
            }

            Console.WriteLine("======================");

            int[] numeros0 = new int[50];

            Numeros num = new Numeros();
            num.ImprimeArray(numeros0);

            Console.ReadKey();
        }
    }
}
