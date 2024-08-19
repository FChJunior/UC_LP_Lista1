/*-------------------------------------------------------------------
Questão 6: Conversão de Moeda do Jogo
• Contextualização: O jogo possui uma loja onde os jogadores podem 
  trocar moedas de ouro por cristais.
• Comando: Desenvolva um programa que receba o valor de moedas de 
  ouro, o valor da taxa de conversão (1 cristal = X moedas de ouro), 
  e dois bônus de conversão (um baseado em eventos e outro em habilidades), 
  e calcule o número de cristais que o jogador pode obter.

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
        double moedasOuro;
        double taxaConversao;
        double bonusEvento;
        double bonusHabilidade;
        double cristaisObtidos;
        /*===================================*/

        /*======== Entrada de Dados =========*/
        Console.WriteLine("======== Câmbio de Cristais ========\n");
        Console.Write("Quantas moedas de ouro você tem: ");
        double.TryParse(Console.ReadLine(), out moedasOuro);

        Console.Write("Qual é a taxa de conversão (1 cristal = X moedas de ouro): ");
        double.TryParse(Console.ReadLine(), out taxaConversao);

        Console.Write("Qual é o bônus de evento: ");
        double.TryParse(Console.ReadLine(), out bonusEvento);

        Console.Write("Qual é o bônus de habilidade: ");
        double.TryParse(Console.ReadLine(), out bonusHabilidade);
        /*===================================*/

        /*===== Cálculo de Cristais Obtidos =====*/
        cristaisObtidos = (moedasOuro / taxaConversao) * bonusEvento * bonusHabilidade;
        /*=======================================*/

        /*========= Saída de Dados ==========*/
        Console.WriteLine("\n======== Valor de Cristais Recebido ========\n");
        Console.WriteLine($"Cristais Obtidos: {cristaisObtidos.ToString("0")}");
        /*===================================*/

        Console.WriteLine("\nPressione ENTER para Fechar");
        Console.ReadLine();
    }
}