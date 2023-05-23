using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Membros
    {
        public static void Executar()
        {
            /* Instanciando a classe Pessoa
             * e criando um objeto*/

            Pessoa pessoa1 = new Pessoa();

            pessoa1.Nome = "Cleiton Peres";
            pessoa1.Idade = 22;

            Pessoa pessoa2 = new Pessoa();

            pessoa2.Nome = "Kléber Machado";
            pessoa2.Idade = 50;

            

            //Console.WriteLine(pessoa2.Nome);

            // Crie mais um objeto e tente exibir no console

            //chamando o método apresentar
            pessoa1.ApresentarNoConsole();

            Computador computador1 = new Computador();

            computador1.Placa_de_Video = "RTX 4090";
            computador1.Processador = "Ryzen 9 5950X";
            computador1.Armazenamento = "SSD 2 TB";
            computador1.Placa_Mãe = "Z570 ASUS";
            computador1.Gabinete = "Gabinete Gamer";
            computador1.Fonte = "Fonte Platinum 1250w ASUS";
            computador1.Memória = "64GB 16X4 DDR5 HyperX";

        }
    }
}
