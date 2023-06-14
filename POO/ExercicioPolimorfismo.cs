using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.POO
{
    class ExercicioPolimorfismo
    {
        public class Cliente    
        {
            public string Nome;
            public string Tipo;
        }

        public class Juridica: Cliente
        {
       
        }

        public class Fisica : Cliente
        {

        }


        public static void Executar()
        {
            Cliente cliente = new Cliente();

            Console.WriteLine("Qual é seu nome?");
            cliente.Nome = Console.ReadLine();
            Console.WriteLine("Você é pessoa física ou jurídica?");
            cliente.Tipo = Console.ReadLine();
            
            Console.WriteLine($"{cliente.Nome}, Você é pessoa {cliente.Tipo}");
        }
    }
}
