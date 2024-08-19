/*-------------------------------------------------------------------
Atividade 10: Atualização de Pontos de Vida
• Contextualização: Em um jogo de estratégia, um personagem pode ganhar pontos de vida a cada nível alcançado.
• Comando: Desenvolva um programa que receba os pontos de vida iniciais e o aumento de vida por nível, e calcule a quantidade de pontos de vida após alcançar um novo nível.

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
        int pontosVidaIniciais;
        int aumentoPorNivel;
        int nivelAlcancado;
        int pontosVidaFinais;
        /*===================================*/

        /*======== Entrada de Dados =========*/
        Console.WriteLine("======== Atualização de Pontos de Vida ========\n");
        Console.Write("Pontos de Vida Iniciais: ");
        int.TryParse(Console.ReadLine(), out pontosVidaIniciais);

        Console.Write("Aumento de Vida por Nível: ");
        int.TryParse(Console.ReadLine(), out aumentoPorNivel);

        Console.Write("Nível Alcançado: ");
        int.TryParse(Console.ReadLine(), out nivelAlcancado);
        /*===================================*/

        /*==== Cálculo dos Pontos de Vida Finais ====*/
        pontosVidaFinais = pontosVidaIniciais + (aumentoPorNivel * nivelAlcancado);
        /*==========================================*/

        /*========= Saída de Dados ==========*/
        Console.WriteLine("\n===== Resultado da Atualização =====\n");
        Console.WriteLine($"Pontos de Vida Finais: {pontosVidaFinais}");
        /*===================================*/

        Console.WriteLine("\nPressione ENTER para Fechar");
        Console.ReadLine();
    }
}
