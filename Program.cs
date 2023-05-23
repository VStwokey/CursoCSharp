using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
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

                // Classes e Metodos

                {"Membros - Classes e Métodos",Membros.Executar},
                {"Construtores - Classes e Métodos",Construtores.Executar}
            });

            central.SelecionarEExecutar();
        }
    }
}