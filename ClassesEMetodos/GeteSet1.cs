using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class GeteSet1
    {
        class Cliente
        {
            //o modificador private vai garantir q apenas a class Cliente vai ter acesso ao nome
            private string nome;

            //entretanto havera momentos em q precisarems tirar esse valor ou abstrair alguma informação entao usamos GET e SET
            //GET -> pega o valor SET -> enviar valor
            // GET e o SET precisams ser iguais ao nosso atributo  da classe porem com a primeira letra maiscula
            public string Nome
            {
                // aqui vms especificar nossas ações
                get
                {
                    //para pegar valor de NOME vou usar o return 
                    return nome;
                }
                set
                {
                    //set vai servir para q eu envie um valor, então esse value é o valor q o usuario vai informar na outra classe
                    nome = value;
                }

            }

        }



        public static void Executar()
        {
            Cliente cliente1 = new Cliente();


            cliente1.Nome = "Felipe";
            Console.WriteLine(cliente1.Nome);
        }
    }
}