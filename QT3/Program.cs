/*-------------------------------------------------------------------
Questão 3: Cálculo de Vida Restante
•	Contextualização: Durante um combate, o jogador recebe dano e a 
    vida do personagem diminui.

•	Comando: Crie um programa que receba o valor da vida inicial, o 
    dano recebido, o bônus de regeneração, e dois modificadores (um 
    para equipamentos e outro para habilidades), e calcule a vida 
    restante.
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
        float vidaInicial;
        float danoRecebido;
        float bonusRegeneracao;
        float modificadorEquipamento;
        float modificadorHabilidade;
        float vidaFinal;
        /*===================================*/

        /*======== Entrada de Dados =========*/
        Console.WriteLine("======== Batalha: Calculo de Dano Recebido ========\n");

        Console.Write("Vida inicial do personagem: ");
        float.TryParse(Console.ReadLine(), out vidaInicial);

        Console.Write("Dano recebido: ");
        float.TryParse(Console.ReadLine(), out danoRecebido);

        Console.Write("Bônus de Regeneração de vida: ");
        float.TryParse(Console.ReadLine(), out bonusRegeneracao);

        Console.Write("Valor do Modificador de Equipamento do Inimigo: ");
        float.TryParse(Console.ReadLine(), out modificadorEquipamento);     

        Console.Write("Valor do Modificador de Habilidade do Inimigo: ");
        float.TryParse(Console.ReadLine(), out modificadorHabilidade);    
        /*===================================*/

        /*========= Cálculo da Pontuação ==========*/
        vidaFinal = vidaInicial - (danoRecebido * modificadorEquipamento * modificadorHabilidade) + bonusRegeneracao;
        /*=========================================*/

        /*========= Saída de Dados ==========*/
        Console.WriteLine("\n========= Dano Calculado ==========\n");
        Console.WriteLine($"Depois do ataque, sua nova vida é {vidaFinal.ToString("0")}.");
       
        /*===================================*/

        Console.WriteLine("\nPressione ENTER para Fechar");
        Console.ReadLine();
    }
}