using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaWhileEFor
    {
        public static void Executar()
        {
            Console.WriteLine("Até quanto você quer contar? ");
            int.TryParse(Console.ReadLine(), out int valor);

            Console.WriteLine("Qual o valor dos saltos? ");
            int.TryParse(Console.ReadLine(), out int saltos);


            int i = 1;
            while (i <= valor)
            {
                Console.WriteLine(i);
                i += saltos;



            }
        }
    }
}
