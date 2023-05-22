using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class ExercicioRepeticao
    {
        public static void Executar()
        {
            /**int soma = 0;
            for(int i = 0; i <10; i++)
            {
                Console.WriteLine("Informe um número: ");
                int.TryParse(Console.ReadLine(), out int n1);
                soma += n1;

            }
            Console.WriteLine(soma);
            **/

            /**
            Console.WriteLine("Informe um Número: ");
            int.TryParse(Console.ReadLine(), out int n1);

            for (int i = 0; i <= n1; i++)
            {
                Console.WriteLine(i);
            }
            **/

            Console.WriteLine("Informe um número: ");
            int.TryParse(Console.ReadLine(), out int n1);

            for(int i = 0; i <=n1; i++)
            {
                Console.WriteLine($"{n1} X {i} = {n1 * i}");
            }
        }
    }
}
