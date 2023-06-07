using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class GeteSet2
    {
        public class CarroOpcional
        {
            double desconto = 0.01;
            string nome;

            public string Nome
            {
                get
                {
                    return "Opcional" + Nome;
                }
                set
                {
                    nome = value;
                }
            }

            public double Desconto { get; set; }

            public double Preco { get; set; }

            public double PrecoDesconto
            {
                get
                {
                    return Preco - (desconto * Preco);
                }
            }

            //criando construtor personalizado
            public CarroOpcional(string nome, double preco)
            {
                Nome = nome;
                Preco = preco;
            }
        }


        public static void Executar()
        {
            var op = new CarroOpcional("Aerofolio", 1.500);
            var op2 = new CarroOpcional("Ar condicionado", 3.500);

            Console.WriteLine(op.PrecoDesconto);
            Console.WriteLine(op2.PrecoDesconto);
        }
    }
}
