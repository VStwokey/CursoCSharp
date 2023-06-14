using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    class ColecoesStack
    {
        public static void Executar()
        {
            var pilha = new Stack();
            //adicionando elementos a pilha
            pilha.Push(5);
            pilha.Push("oi");
            pilha.Push(true);
            pilha.Push(4.7);

            foreach (var item in pilha)
            {
                Console.WriteLine($"{item}");
            }
                
            //removendo elemnto da pilha
            Console.WriteLine($"Pop {pilha.Pop()}");

            foreach (var item in pilha)
            {
                Console.WriteLine($"foreach: {item}");
            }

            //usando peek
            Console.WriteLine($"Peek: {pilha.Peek()}");
            //contando os elementos
            Console.WriteLine(pilha.Count);


        }
    }
}
