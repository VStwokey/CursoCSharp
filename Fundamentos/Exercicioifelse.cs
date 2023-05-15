using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class Exercicioifelse
    {
        public static void Executar()
        {

            /*
            Console.WriteLine("Informe o ano que você nasceu: ");
            int anonasc = int.Parse(Console.ReadLine());

            int idade = 2023 - anonasc;

            if (idade < 18)
            {
                Console.WriteLine("Você tem " + idade + " e não pode votar.");
            }
            else
            {
                Console.WriteLine("Voce tem " + idade + " e pode votar");
            }
            */

            /*
            string senha = "7taz9HvJ";

            Console.WriteLine("Digite sua senha: ");
            string usenha = Console.ReadLine();

            if(usenha == senha)
            {
                Console.WriteLine("Acesso Permitido");
            }
            else
            {
                Console.WriteLine("Acesso Negado");
            }
            */

            /*
            Console.WriteLine("Informe a primeira nota: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a primeira nota: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a primeira nota: ");
            double n3 = double.Parse(Console.ReadLine());

            double media = (n1+n2+n3) / 3;

            if (media >= 7)
            {
                Console.WriteLine("Esse aluno foi aprovado.");
            } 
            else if (media >= 5 && media < 7)
            {
                Console.WriteLine("Esse aluno está de recuperação");
            }
            else
            {
                Console.WriteLine("Esse aluno está reprovado");
            }
            */

            Console.WriteLine("Informe sua altura: ");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe seu peso: ");
            int peso = int.Parse(Console.ReadLine()); 

            double IMC = peso / (altura * altura);

            if (IMC < 18.5)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (IMC >= 18.5 && IMC <= 24.9)
            {
                Console.WriteLine("Peso Normal");
            }
            else if (IMC > 24.9 && IMC <= 29.9)
            {
                Console.WriteLine("Acima do peso");
            }
            else if (IMC > 29.9 && IMC <= 34.9)
            {
                Console.WriteLine("Obesidade Grau I");
            }
            else if (IMC > 34.9 && IMC <= 39.9)
            {
                Console.WriteLine("Obesidade Grau II");
            }
            else if (IMC > 39.9)
            {
                Console.WriteLine("Obesidade Grau III");
            }
            


        }
    }
}
