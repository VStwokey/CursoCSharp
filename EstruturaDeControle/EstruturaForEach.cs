﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaForEach
    {
    public static void Executar()
        {
            /**
            var palavra = "Banana";
            foreach(var letra in palavra)
            {
                Console.WriteLine(letra);
            }
            **/

            //Percorrendo um Array

            var alunos = new string[] { "José", "Cleiton", "Maria", "Josenildo" };
            foreach(var indice in alunos)
            {
                Console.WriteLine(indice);
            }
            

        }
    }
}
