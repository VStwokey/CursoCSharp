using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;


namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Variaveis e Constantes - Fundamentos",VariaveisEConstantes.Executar },
                {"Notação Ponto - Fundamentos ",NotacaoPonto.Executar },
                {"Lendo Dados - Fundamentos",LendoDados.Executar },
                {"Formatando Números - Fundamentos ",FormatandoNumeros.Executar},
                {"Operadores Aritméticos - Fundamentos ",OperadoresAritmeticos.Executar},
                {"Exercicioifelse -  Fundamentos ",Exercicioifelse.Executar },
                {"ExercicioRepeticao - Fundamentos",ExercicioRepeticao.Executar},

                //Estrutura de Controle
                {"Estrutura For Each - Estrutura de Controle",EstruturaForEach.Executar},
                {"Estrutura Switch - Estrutura de Controle",EstruturaSwitch.Executar},
                {"Estrutura While e For - Estrutura de Controle",EstruturaWhileEFor.Executar},
                {"Estrutura Repeticao - Estrutura de Controle",EstruturaRepeticao.Executar},
                {"Exercicio Switch - Estrutura de Controle",ExercicioSwitch.Executar},

                // Classes e Metodos

                {"Membros - Classes e Métodos",Membros.Executar},
                {"Construtores - Classes e Métodos",Construtores.Executar},
                {"Exercicios Metodos Com Retorno - Classes e Métodos",ExerciciosMetodosComRetorno.Executar},
                {"Metodos Estaticos - Classes e Métodos",ExerciciosMetodosComRetorno.Executar},
                {"Get e Set 1 - Classes e Métodos", GeteSet1.Executar},
                {"Get e Set 2 - Classes e Métodos", GeteSet2.Executar},
                {"Exercicios com get e set 1 - Classes e Métodos", ExerGeteSet1.Executar},
                {"Exercicios com get e set 2 - Classes e Métodos", ExerGeteSet2.Executar},
                {"Exercicios com get e set 3 - Classes e Métodos", ExerGeteSet3.Executar},

                 //Colecoes
                {"Arrays - Colecoes", Arrays.Executar},
                {"Queue (fila) - Colecoes", ColecoesQueue.Executar},
                {"Stack (pilha) - Colecoes", ColecoesStack.Executar},

                //POO
                {"Herança - POO", Heranca.Executar},
                {"Construtor This - POO", ConstrutorThis.Executar},
                {"Encapsulamento - POO", Encapsulamento.Executar},
                {"Polimorfismo - POO", Polimorfismo.Executar},
                {"Exercicio     Polimorfismo - POO", ExercicioPolimorfismo.Executar},
            }); ;

            central.SelecionarEExecutar();
        }
    }
}