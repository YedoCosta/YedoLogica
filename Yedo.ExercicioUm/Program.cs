using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yedo.ExercicioUm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string asterisco = "*************************";
            int ct = 0;
            for (int i = 1; i < 19; i++)
            {
                ct ++;

                Console.WriteLine(asterisco.Substring(1,ct));
                if (ct == 6)
                {
                    ct = 0;
                }
                /*
                 * string  autorNome = bio.Substring(0, 12);    
                   Console.WriteLine(nomedoautor);
                if ((i % 4) == 0)
                {
                    Console.WriteLine($"{i} - PI");
                }
                if ((i%2) == 0)
                {
                    Console.WriteLine($"{i} - ** - Par");
                }
                else
                {
                    Console.WriteLine($"{i} - * - Impar");
                }
                Console.WriteLine($"{i} - Yedo Martins");
                */

            }


            Console.ReadKey();
        }

    }
}
