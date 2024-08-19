/*-------------------------------------------------------------------
Atividade 7: Experiência e Nível do Jogador após Batalha
• Contextualização: Em um jogo, o jogador enfrenta dois tipos diferentes 
  de inimigos em uma batalha. Cada tipo de inimigo concede uma 
  quantidade específica de XP. Após a batalha, o jogador ganha esse XP 
  e precisa somá-lo ao XP total acumulado para determinar o nível 
  atual do personagem.
• Comando: Desenvolva um programa que receba a quantidade de XP 
  acumulado, o XP concedido pelo primeiro tipo de inimigo, o XP 
  concedido pelo segundo tipo de inimigo, o número de cada tipo de 
  inimigo derrotado, e a constante de nível. O programa deve calcular 
  o XP total acumulado após a batalha e determinar o nível atual do 
  jogador.

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
        int xpAcumulado;
        int xpInimigo1;
        int xpInimigo2;
        int inimigos1Derrotados;
        int inimigos2Derrotados;
        int constanteNivel;
        int xpTotal;
        int nivelJogador;
        /*===================================*/

        /*======== Entrada de Dados =========*/
        Console.WriteLine("======== Batalha Concluída! ========\n");
        Console.Write("XP Acumulado: ");
        int.TryParse(Console.ReadLine(), out xpAcumulado);

        Console.Write("XP por Inimigo Tipo 1: ");
        int.TryParse(Console.ReadLine(), out xpInimigo1);

        Console.Write("Número de Inimigos Tipo 1 Derrotados: ");
        int.TryParse(Console.ReadLine(), out inimigos1Derrotados);

        Console.Write("XP por Inimigo Tipo 2: ");
        int.TryParse(Console.ReadLine(), out xpInimigo2);

        Console.Write("Número de Inimigos Tipo 2 Derrotados: ");
        int.TryParse(Console.ReadLine(), out inimigos2Derrotados);

        Console.Write("Constante de Nível: ");
        int.TryParse(Console.ReadLine(), out constanteNivel);
        /*===================================*/

        /*==== Cálculo de XP e Nível ====*/
        xpTotal = xpAcumulado + (xpInimigo1 * inimigos1Derrotados) + (xpInimigo2 * inimigos2Derrotados);
        nivelJogador = xpTotal / constanteNivel;
        /*================================*/

        /*========= Saída de Dados ==========*/
        Console.WriteLine("\n===== Resultado da Batalha =====\n");
        Console.WriteLine($"XP Total: {xpTotal}");
        Console.WriteLine($"Nível Atual do Jogador: {nivelJogador}");
        /*===================================*/

        Console.WriteLine("\nPressione ENTER para Fechar");
        Console.ReadLine();
    }
}
