using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class ExerciciosMetodosComRetorno
    {
        class RealParaDolar
        {
           public double Convertor()
            {
                Console.WriteLine("Informe um valor para realizar a conversão.");
                double.TryParse(Console.ReadLine(), out double R);
                return R * 4.95;
            }
        }
        
        class CelsiusParaFahrenheit
        {
            public double Conversao()
            {
                Console.WriteLine("Informe um valor para realizar a conversão");
                double.TryParse(Console.ReadLine(), out double celsius);
                return celsius * 9 / 5 + 32;

            }
        }



        public static void Executar()
        {
            
            var realparadolar = new RealParaDolar();
            var convertor = realparadolar.Convertor();
            Console.WriteLine(convertor.ToString("F1"));
            

            var celsiusparafahrenheit = new CelsiusParaFahrenheit();
            var conversao = celsiusparafahrenheit.Conversao();
            Console.WriteLine(conversao.ToString());
        }
    }
}
