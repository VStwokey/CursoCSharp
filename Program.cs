﻿using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;

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
                {"ExercicioRepeticao - Fundamentos",ExercicioRepeticao.Executar}
            });

            central.SelecionarEExecutar();
        }
    }
}