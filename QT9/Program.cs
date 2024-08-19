/*-------------------------------------------------------------------
Atividade 9: Comparação de Poder de Ataque
• Contextualização: Em um jogo de luta, cada personagem tem um valor de ataque baseado em sua força, arma e bônus de habilidades. O total de ataque é afetado por modificadores críticos e pelo tipo da arma.
• Comando: Crie um programa que receba o valor da força do personagem, o poder da arma, o bônus de habilidades, um modificador de crítico, e um modificador para o tipo da arma. O programa deve calcular o total de ataque do personagem.

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
        int poderArma;
        double bonusHabilidades;
        double modificadorCritico;
        double modificadorTipoArma;
        double totalAtaque;
        /*===================================*/

        /*======== Entrada de Dados =========*/
        Console.WriteLine("======== Cálculo do Poder de Ataque ========\n");
        Console.Write("Força do Personagem: ");
        int.TryParse(Console.ReadLine(), out forca);

        Console.Write("Poder da Arma: ");
        int.TryParse(Console.ReadLine(), out poderArma);

        Console.Write("Bônus de Habilidades: ");
        double.TryParse(Console.ReadLine(), out bonusHabilidades);

        Console.Write("Modificador Crítico: ");
        double.TryParse(Console.ReadLine(), out modificadorCritico);

        Console.Write("Modificador Tipo da Arma: ");
        double.TryParse(Console.ReadLine(), out modificadorTipoArma);
        /*===================================*/

        /*==== Cálculo do Total de Ataque ====*/
        totalAtaque = forca + (poderArma * modificadorTipoArma) * bonusHabilidades * modificadorCritico;
        /*===================================*/

        /*========= Saída de Dados ==========*/
        Console.WriteLine("\n===== Resultado do Poder de Ataque =====\n");
        Console.WriteLine($"Total de Ataque: {totalAtaque.ToString("0.00")}");
        /*===================================*/

        Console.WriteLine("\nPressione ENTER para Fechar");
        Console.ReadLine();
    }
}
