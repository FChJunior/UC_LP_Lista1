/*-------------------------------------------------------------------
Questão 4: Somatório de Moedas
•	Contextualização: No seu jogo, o jogador coleta moedas durante uma 
    fase. A cada coleta, o total de moedas aumenta.
•	Comando: Desenvolva um programa que receba cinco valores de moedas 
    coletadas e some-os, exibindo o total de moedas coletadas ao final.

@Lista: 01 - Lógica de Programação
@Autor: Chagas Junior
@Data: 19/08/2024
---------------------------------------------------------------------*/

using System;

class Program
{
    static void Main(string[] args)
    {
        /*======= Variáveis Auxiliares ======*/
        int moedasColetadas;
        int totalMoedas = 0;
        /*===================================*/

        /*======== Entrada de Dados =========*/
        Console.WriteLine("======== Recebendo Moedas ========\n");

        Console.Write("Primeira remessa de moedas: ");
        int.TryParse(Console.ReadLine(), out moedasColetadas);
        totalMoedas += moedasColetadas;

        Console.Write("Segunda remessa de moedas: ");
        int.TryParse(Console.ReadLine(), out moedasColetadas);
        totalMoedas += moedasColetadas;

        Console.Write("Terceira remessa de moedas: ");
        int.TryParse(Console.ReadLine(), out moedasColetadas);
        totalMoedas += moedasColetadas;

        Console.Write("Quarta remessa de moedas: ");
        int.TryParse(Console.ReadLine(), out moedasColetadas);
        totalMoedas += moedasColetadas;

        Console.Write("Quinta remessa de moedas: ");
        int.TryParse(Console.ReadLine(), out moedasColetadas);
        totalMoedas += moedasColetadas;
        /*===================================*/

        /*========= Cálculo da Pontuação ==========*/
       
        /*=========================================*/

        /*========= Saída de Dados ==========*/
        Console.WriteLine("\n========= Total de Moeda ==========\n");
        Console.WriteLine($"Agora você possui um total de {totalMoedas} moedas.");
       
        /*===================================*/

        Console.WriteLine("\nPressione ENTER para Fechar");
        Console.ReadLine();
    }
}   