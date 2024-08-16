/*-------------------------------------------------------------------
Questão 1: Informações do Personagem
• Contextualização: Em um jogo de RPG, o jogador precisa inserir 
  as informações básicas do personagem antes de começar a aventura.
• Comando: Crie um programa que receba o nome, idade, nível inicial, 
  classe, e raça do personagem e exiba esses dados no console.

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
        string nome;
        int idade;
        byte nivelInicial;
        string classe;
        string raca; // Ajustado para evitar caracteres especiais
        /*===================================*/
        /*============ Introdução ===========*/
        Console.WriteLine("============ Sejam Bem-vindos ao SenAUA Online ============");
        Console.WriteLine("Antes de iniciar o jogo, insira os dados do seu personagem:");
        Console.WriteLine("===========================================================\n");
        /*===================================*/

        /*======== Entrada de Dados =========*/
        Console.Write("Qual será o nome do seu personagem: ");
        nome = Console.ReadLine();

        Console.Write("Qual a idade do seu personagem: ");
        int.TryParse(Console.ReadLine(), out idade);

        Console.Write("Qual o nível inicial do seu personagem: ");
        byte.TryParse(Console.ReadLine(), out nivelInicial);

        Console.Write("Qual a classe do seu personagem: ");
        classe = Console.ReadLine();

        Console.Write("Qual a raça do seu personagem: ");
        raca = Console.ReadLine();
        /*===================================*/

        /*========= Saída de Dados ==========*/
        Console.WriteLine("\n===== Informações do Personagem =====");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Nível Inicial: {nivelInicial}");
        Console.WriteLine($"Classe: {classe}");
        Console.WriteLine($"Raça: {raca}");
        /*===================================*/

        Console.WriteLine("\nPressione ENTER para Fechar");
        Console.ReadLine();
    }
}
