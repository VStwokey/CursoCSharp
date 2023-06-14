using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.POO
{
    class Heranca
    {
        public class Carro
        {
            //vai ser transmitida por heranca por isso usamos o protected
            //e o readonly significa q é apenas para ler e não modificar
            protected readonly int VelocidadeMaxima;  

            int VelocidadeAtual;

            public Carro(int velocidadeMaxima)
            {
                VelocidadeMaxima = velocidadeMaxima;
            }

            protected int AlterarVelocidade(int delta)
            {
                int novaVelocidade = VelocidadeAtual + delta;
                if (novaVelocidade < 0)
                {
                    VelocidadeAtual = 0;
                }else if (novaVelocidade > VelocidadeMaxima)
                {
                    VelocidadeAtual = VelocidadeMaxima;
                }
                else
                {
                    VelocidadeAtual = novaVelocidade;
                }
                return VelocidadeAtual;
            }

            public int Acelerar()
            {
                return AlterarVelocidade(5);
            }

            public int Frear()
            {
                return AlterarVelocidade(-5);
            }
        }

        public class Uno : Carro {  
            public Uno() : base(200)
            {

            }
        }

        public class GolfãoRebaixado : Carro
        {
            public GolfãoRebaixado() : base(500)
            {

            }
        }



        public static void Executar()
        {
            Console.WriteLine("Uno");
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());

            Console.WriteLine("Golfão");
            Uno carro2 = new Uno();
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());
        }
    }
}
