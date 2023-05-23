using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Pessoa
    {
        /* Estamos colocando o tipo public porque
         * quero que esse atributo fique visivel para
         a minha classe. Imagine que na vida real temos alguns atributos
        que precisam ser publicos e outros atributos precisam ser privados */

        public string Nome;
        public int Idade;

        public string Apresentar()
        {
            return string.Format($"Olá! Me chamo {Nome} e tenho {Idade} anos");
        }
        /*o Método Format retorna uma
         string formatada e imprime no console*/

        public void ApresentarNoConsole()
            {
            // Aqui eu vou chamar no console
            // o método que eu criei que é o Apresentar()
            Console.WriteLine(Apresentar());    
            }
        
    }
}
