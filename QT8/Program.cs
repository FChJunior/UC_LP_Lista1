/*-------------------------------------------------------------------
Atividade 8: Cálculo de Pontos de Habilidade
• Contextualização: Ao subir de nível, um jogador recebe pontos de habilidade que podem ser distribuídos entre cinco características: força, agilidade, inteligência, destreza e vitalidade.
• Comando: Desenvolva um programa que receba a quantidade de pontos de habilidade atribuídos a cada uma das cinco características e calcule o total de pontos distribuídos.

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
        int forca;
        int agilidade;
        int inteligencia;
        int destreza;
        int vitalidade;
        int totalPontos;
        /*===================================*/

        /*======== Entrada de Dados =========*/
        Console.WriteLine("======== Distribuição de Pontos de Habilidade ========\n");
        Console.Write("Pontos para Força: ");
        int.TryParse(Console.ReadLine(), out forca);

        Console.Write("Pontos para Agilidade: ");
        int.TryParse(Console.ReadLine(), out agilidade);

        Console.Write("Pontos para Inteligência: ");
        int.TryParse(Console.ReadLine(), out inteligencia);

        Console.Write("Pontos para Destreza: ");
        int.TryParse(Console.ReadLine(), out destreza);

        Console.Write("Pontos para Vitalidade: ");
        int.TryParse(Console.ReadLine(), out vitalidade);
        /*===================================*/

        /*==== Cálculo do Total de Pontos ====*/
        totalPontos = forca + agilidade + inteligencia + destreza + vitalidade;
        /*===================================*/

        /*========= Saída de Dados ==========*/
        Console.WriteLine("\n===== Total de Pontos Distribuídos =====\n");
        Console.WriteLine($"Total de Pontos: {totalPontos}");
        /*===================================*/

        Console.WriteLine("\nPressione ENTER para Fechar");
        Console.ReadLine();
    }
}
