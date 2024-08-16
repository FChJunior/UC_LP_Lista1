/*-------------------------------------------------------------------
Questão 2: Pontuação Final
• Contextualização: No final de uma missão em um jogo, a pontuação 
  do jogador é calculada com base nos inimigos derrotados e pontos 
  adicionais.
• Comando: Desenvolva um programa que receba o número de inimigos 
  derrotados, a pontuação por inimigo, bônus por missão, e dois 
  multiplicadores (um para tipo de inimigo e outro para dificuldade), 
  e então calcule e exiba a pontuação final.

@Lista: 01 - Lógica de Programação
@Autor: Chagas Junior
@Data: 16/08/2024
---------------------------------------------------------------------*/

using System;

class Program
{
    static void Main(string[] args)
    {
        /*======= Variáveis Auxiliares ======*/
        int inimigosDerrotados;
        int pontuacaoPorInimigo;
        int bonusMissao;
        double multiplicadorTipoInimigo;
        double multiplicadorDificuldade;
        double pontuacaoFinal;
        /*===================================*/

        /*======== Entrada de Dados =========*/
        Console.Write("Número de inimigos derrotados: ");
        int.TryParse(Console.ReadLine(), out inimigosDerrotados);

        Console.Write("Pontuação por inimigo: ");
        int.TryParse(Console.ReadLine(), out pontuacaoPorInimigo);

        Console.Write("Bônus por missão: ");
        int.TryParse(Console.ReadLine(), out bonusMissao);

        Console.Write("Multiplicador para tipo de inimigo: ");
       double.TryParse(Console.ReadLine(), out multiplicadorTipoInimigo);

        Console.Write("Multiplicador para dificuldade: ");
        double.TryParse(Console.ReadLine(), out multiplicadorDificuldade);
        /*===================================*/

        /*========= Cálculo da Pontuação ==========*/
        pontuacaoFinal = inimigosDerrotados * multiplicadorTipoInimigo * multiplicadorDificuldade * pontuacaoPorInimigo + bonusMissao;
        /*=========================================*/

        /*========= Saída de Dados ==========*/
        Console.WriteLine($"\nPontuação Final: {pontuacaoFinal}");
        /*===================================*/

        Console.WriteLine("\nPressione ENTER para Fechar");
        Console.ReadLine();
    }
}