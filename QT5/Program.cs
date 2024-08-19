/*-------------------------------------------------------------------
Questão 5: Cálculo de Distância Percorrida
• Contextualização: Um veículo no jogo percorre uma certa distância 
  em um tempo determinado.
• Comando: Crie um programa que receba a velocidade do veículo, o 
  tempo de viagem e dois multiplicadores (um para condições climáticas 
  e outro para estado do veículo), e calcule a distância total percorrida.

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
        double velocidade;
        double tempo;
        double multiplicadorClimatico;
        double multiplicadorEstadoVeiculo;
        double distanciaPercorrida;
        /*===================================*/

        /*======== Entrada de Dados =========*/
        Console.WriteLine("======== Carro em Movimento ========\n");
        Console.Write("Qual é a velocidade do veículo (em km/h): ");
        double.TryParse(Console.ReadLine(), out velocidade);

        Console.Write("Qual é o tempo de viagem (em horas): ");
        double.TryParse(Console.ReadLine(), out tempo);

        Console.Write("Qual é o multiplicador para condições climáticas: ");
        double.TryParse(Console.ReadLine(), out multiplicadorClimatico);

        Console.Write("Qual é o multiplicador para estado do veículo: ");
        double.TryParse(Console.ReadLine(), out multiplicadorEstadoVeiculo);
        /*===================================*/

        /*===== Cálculo da Distância Percorrida =====*/
        distanciaPercorrida = velocidade * tempo * multiplicadorClimatico * multiplicadorEstadoVeiculo;
        /*===========================================*/

        /*========= Saída de Dados ==========*/
        Console.WriteLine("\n======== Distância Percorrida ========\n");
        Console.WriteLine($"Distância Percorrida: {distanciaPercorrida.ToString("0.00")} km");
        /*===================================*/

        Console.WriteLine("\nPressione ENTER para Fechar");
        Console.ReadLine();
    }
}
