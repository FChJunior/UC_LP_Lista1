# LISTA DE EXERCÍCIOS Nº 1

**Unidade Operacional:** CFP – AUA  
**Curso:** Técnico Programador de Jogos Digitais  
**Modalidade:** Habilitação Técnica  
**Turma:** 2º ano  
**Módulo:** Integrador Introdutório  
**Unidade Curricular:** Lógica de Programação  
**Conteúdo:** Entrada, Saída e Operações de Dados  

**Observações:**
- Crie cada questão em uma pasta com o nome da questão. Ex.: Quest1;
- Todas as Questões devem estar dentro de uma pasta com o nome da atividade. Ex.: Lista1
- Build cada código fonte e deixe o executável na pasta da atividade. Crie uma pasta com o nome `build`;
- Crie um repositório público no GitHub e disponibilize o link para seu professor.
- Use um cabeçalho em cada código fonte. Ex.:

    ```c
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
    ```

## Questão 1: Informações do Personagem

**Contextualização:** Em um jogo de RPG, o jogador precisa inserir as informações básicas do personagem antes de começar a aventura.  
**Comando:** Crie um programa que receba o nome, idade, nível inicial, classe, e raça do personagem e exiba esses dados no console.  

**Quadro de Testes:**

| Input                     | Resultado Esperado |
|---------------------------|---------------------|
| Nome: "Arthas"            | Nome: Arthas        |
| Idade: 30                 | Idade: 30           |
| Nível Inicial: 1          | Nível Inicial: 1    |
| Classe: "Guerreiro"       | Classe: Guerreiro   |
| Raça: "Humano"            | Raça: Humano        |
|---------------------------|---------------------|
| Nome: "Luna"              | Nome: Luna          |
| Idade: 25                 | Idade: 25           |
| Nível Inicial: 3          | Nível Inicial: 3    |
| Classe: "Maga"            | Classe: Maga        |
| Raça: "Elfo"              | Raça: Elfo          |
|---------------------------|---------------------|
| Nome: "Drake"             | Nome: Drake         |
| Idade: 40                 | Idade: 40           |
| Nível Inicial: 5          | Nível Inicial: 5    |
| Classe: "Ladrão"          | Classe: Ladrão      |
| Raça: "Anão"              | Raça: Anão          |

## Questão 2: Pontuação Final

**Contextualização:** No final de uma missão em um jogo, a pontuação do jogador é calculada com base nos inimigos derrotados e pontos adicionais.  
**Comando:** Desenvolva um programa que receba o número de inimigos derrotados, a pontuação por inimigo, bônus por missão, e dois multiplicadores (um para tipo de inimigo e outro para dificuldade), e então calcule e exiba a pontuação final.  

**Quadro de Testes:**

| Input                                | Resultado Esperado |
|--------------------------------------|---------------------|
| Inimigos Derrotados: 10              | Pontuação Final: 2050 |
| Pontos por Inimigo: 100              |                     |
| Bônus por Missão: 50                 |                     |
| Multiplicador Tipo Inimigo: 1        |                     |
| Multiplicador Dificuldade: 2          |                     |
|--------------------------------------|---------------------|
| Inimigos Derrotados: 5               | Pontuação Final: 920  |
| Pontos por Inimigo: 80               |                     |
| Bônus por Missão: 20                 |                     |
| Multiplicador Tipo Inimigo: 1.5      |                     |
| Multiplicador Dificuldade: 1.5        |                     |
|--------------------------------------|---------------------|
| Inimigos Derrotados: 20              | Pontuação Final: 1100 |
| Pontos por Inimigo: 50               |                     |
| Bônus por Missão: 100                |                     |
| Multiplicador Tipo Inimigo: 1        |                     |
| Multiplicador Dificuldade: 1          |                     |

## Questão 3: Cálculo de Vida Restante

**Contextualização:** Durante um combate, o jogador recebe dano e a vida do personagem diminui.  
**Comando:** Crie um programa que receba o valor da vida inicial, o dano recebido, o bônus de regeneração, e dois modificadores (um para equipamentos e outro para habilidades), e calcule a vida restante.  

**Quadro de Testes:**

| Input                                   | Resultado Esperado |
|-----------------------------------------|---------------------|
| Vida Inicial: 100                      | Vida Restante: 90   |
| Dano Recebido: 30                      |                     |
| Bônus de Regeneração: 20               |                     |
| Modificador Equipamentos: 1            |                     |
| Modificador Habilidades: 1             |                     |
|-----------------------------------------|---------------------|
| Vida Inicial: 150                      | Vida Restante: 120  |
| Dano Recebido: 30                      |                     |
| Bônus de Regeneração: 10               |                     |
| Modificador Equipamentos: 1.2          |                     |
| Modificador Habilidades: 1.1           |                     |
|-----------------------------------------|---------------------|
| Vida Inicial: 200                      | Vida Restante: 155  |
| Dano Recebido: 40                      |                     |
| Bônus de Regeneração: 15               |                     |
| Modificador Equipamentos: 1            |                     |
| Modificador Habilidades: 1.5           |                     |

## Questão 4: Somatório de Moedas

**Contextualização:** No seu jogo, o jogador coleta moedas durante uma fase. A cada coleta, o total de moedas aumenta.  
**Comando:** Desenvolva um programa que receba cinco valores de moedas coletadas e some-os, exibindo o total de moedas coletadas ao final.  

**Quadro de Testes:**

| Input                                  | Resultado Esperado |
|----------------------------------------|---------------------|
| Moedas Coletadas 1: 5                 | Total de Moedas: 30 |
| Moedas Coletadas 2: 7                 |                     |
| Moedas Coletadas 3: 8                 |                     |
| Moedas Coletadas 4: 4                 |                     |
| Moedas Coletadas 5: 6                 |                     |
|----------------------------------------|---------------------|
| Moedas Coletadas 1: 10                | Total de Moedas: 50 |
| Moedas Coletadas 2: 10                |                     |
| Moedas Coletadas 3: 5                 |                     |
| Moedas Coletadas 4: 15                |                     |
| Moedas Coletadas 5: 10                |                     |
|----------------------------------------|---------------------|
| Moedas Coletadas 1: 2                 | Total de Moedas: 22 |
| Moedas Coletadas 2: 5                 |                     |
| Moedas Coletadas 3: 4                 |                     |
| Moedas Coletadas 4: 6                 |                     |
| Moedas Coletadas 5: 5                 |                     |

## Questão 5: Cálculo de Distância Percorrida

**Contextualização:** Um veículo no jogo percorre uma certa distância em um tempo determinado.  
**Comando:** Crie um programa que receba a velocidade do veículo, o tempo de viagem e dois multiplicadores (um para condições climáticas e outro para estado do veículo), e calcule a distância total percorrida.  

**Quadro de Testes:**

| Input                                   | Resultado Esperado |
|-----------------------------------------|---------------------|
| Velocidade: 60                         | Distância Percorrida: 144,00 |
| Tempo: 2                               |                     |
| Multiplicador Climático: 1              |                     |
| Multiplicador Estado do Veículo: 1.2    |                     |
|-----------------------------------------|---------------------|
| Velocidade: 80                         | Distância Percorrida: 211,20 |
| Tempo: 3                               |                     |
| Multiplicador Climático: 0.8            |                     |
| Multiplicador Estado do Veículo: 1.1    |                     |
|-----------------------------------------|---------------------|
| Velocidade: 50                         | Distância Percorrida: 81,00  |
| Tempo: 2                               |                     |
| Multiplicador Climático: 0.9            |                     |
| Multiplicador Estado do Veículo: 0.9    |                     |

## Questão 6: Conversão de Moedas para Cristais

**Contextualização:** No jogo, o jogador troca moedas de ouro por cristais em uma loja.  
**Comando:** Desenvolva um programa que receba o valor de moedas de ouro, o valor da taxa de conversão (1 cristal = X moedas de ouro), e dois bônus de conversão (um baseado em eventos e outro em habilidades), e calcule o número de cristais que o jogador pode obter.  

**Quadro de Testes:**

| Input                                  | Resultado Esperado |
|----------------------------------------|---------------------|
| Moedas de Ouro: 100                   | Cristais Obtidos: 80   |
| Taxa de Conversão: 2                   |                     |
| Bônus de Evento: 1.1                   |                     |
| Bônus de Habilidades: 1.2              |                     |
|----------------------------------------|---------------------|
| Moedas de Ouro: 150                   | Cristais Obtidos: 90   |
| Taxa de Conversão: 2.5                 |                     |
| Bônus de Evento: 1.2                   |                     |
| Bônus de Habilidades: 1.1              |                     |
|----------------------------------------|---------------------|
| Moedas de Ouro: 200                   | Cristais Obtidos: 88   |
| Taxa de Conversão: 3                   |                     |
| Bônus de Evento: 1.0                   |                     |
| Bônus de Habilidades: 1.1              |                     |

## Questão 7: Cálculo de Nível do Jogador

**Contextualização:** O nível do jogador é determinado pelo total de XP acumulado dividido por uma constante de nível.  
**Comando:** Desenvolva um programa que receba a quantidade de XP acumulado e a constante de nível, e calcule o nível atual do jogador.  

**Quadro de Testes:**

| Input                                  | Resultado Esperado |
|----------------------------------------|---------------------|
| XP Acumulado: 1000                    | Nível: 10           |
| Constante de Nível: 100                |                     |
|----------------------------------------|---------------------|
| XP Acumulado: 1500                    | Nível: 15           |
| Constante de Nível: 100                |                     |
|----------------------------------------|---------------------|
| XP Acumulado: 2500                    | Nível: 20           |
| Constante de Nível: 125                |                     |

## Questão 8: Determinação do Nível do Personagem

**Contextualização:** Após uma batalha, o jogador enfrenta dois tipos diferentes de inimigos que concedem diferentes quantidades de XP.  
**Comando:** Crie um programa que receba a quantidade de XP concedida por cada tipo de inimigo e some esses valores ao XP total acumulado para determinar o nível atual do personagem.  

**Quadro de Testes:**

| Input                                  | Resultado Esperado |
|----------------------------------------|---------------------|
| XP Tipo 1: 50                         | Nível: 3            |
| XP Tipo 2: 100                        |                     |
| XP Total Acumulado: 300               |                     |
| Constante de Nível: 100                |                     |
|----------------------------------------|---------------------|
| XP Tipo 1: 70                         | Nível: 4            |
| XP Tipo 2: 120                        |                     |
| XP Total Acumulado: 400               |                     |
| Constante de Nível: 100                |                     |
|----------------------------------------|---------------------|
| XP Tipo 1: 40                         | Nível: 5            |
| XP Tipo 2: 80                         |                     |
| XP Total Acumulado: 500               |                     |
| Constante de Nível: 100                |                     |

## Questão 9: Calculadora de Experiência de Missão

**Contextualização:** O jogador ganha experiência (XP) ao completar missões em um jogo.  
**Comando:** Desenvolva um programa que calcule a quantidade de XP total recebida após completar várias missões, somando os valores de XP ganhos em cada missão.  

**Quadro de Testes:**

| Input                                  | Resultado Esperado |
|----------------------------------------|---------------------|
| XP Missão 1: 200                      | XP Total: 550      |
| XP Missão 2: 150                      |                     |
| XP Missão 3: 200                      |                     |
| XP Missão 4: 0                        |                     |
| XP Missão 5: 0                        |                     |
|----------------------------------------|---------------------|
| XP Missão 1: 300                      | XP Total: 800      |
| XP Missão 2: 250                      |                     |
| XP Missão 3: 250                      |                     |
| XP Missão 4: 0                        |                     |
| XP Missão 5: 0                        |                     |
|----------------------------------------|---------------------|
| XP Missão 1: 100                      | XP Total: 550      |
| XP Missão 2: 150                      |                     |
| XP Missão 3: 200                      |                     |
| XP Missão 4: 100                      |                     |
| XP Missão 5: 0                        |                     |
## Questão 10: Gerenciamento de Recursos

**Contextualização:** No jogo, o jogador coleta diferentes tipos de recursos e precisa gerenciá-los para realizar construções ou melhorar seu personagem.  
**Comando:** Desenvolva um programa que receba a quantidade de três tipos diferentes de recursos (madeira, pedra e ferro) e calcule a quantidade total de recursos disponíveis.  

**Quadro de Testes:**

| Input                                  | Resultado Esperado |
|----------------------------------------|---------------------|
| Madeira: 50                           | Total de Recursos: 130 |
| Pedra: 30                             |                     |
| Ferro: 50                             |                     |
|----------------------------------------|---------------------|
| Madeira: 100                          | Total de Recursos: 200 |
| Pedra: 50                             |                     |
| Ferro: 50                             |                     |
|----------------------------------------|---------------------|
| Madeira: 20                           | Total de Recursos: 80  |
| Pedra: 30                             |                     |
| Ferro: 30                             |                     |
