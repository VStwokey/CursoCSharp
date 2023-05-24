using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaRepeticao
    {
        public static void Executar()
        {

            int soma = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Informe um número: ");
                int.TryParse(Console.ReadLine(), out int n1);

                soma += n1;
            }
            Console.WriteLine("A soma é " + soma);


            /**
            ----------------------------------------------------------------
             Console.WriteLine("Informe um número: ");
            int.TryParse(Console.ReadLine(), out int n);

            for (int i =0; i<=n; i++)
            {
                Console.WriteLine(i);
            }
            -----------------------------------------------------------------
            /**

            /**Console.WriteLine("Informe um número: ");
            int.TryParse(Console.ReadLine(), out int n);

            for (int i = 0; i<=n; i++)
            {
                Console.WriteLine($"{n} X {i} = {n*i}");
            }**/

        }
    }
}