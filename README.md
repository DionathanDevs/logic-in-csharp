# Exercícios em C#


## Integrantes:
- Tamires Rodrigues da Veiga
- Dionathan Boing Mesquita


## Breve descrição dos exercícios:

### Questão 1: Verificação de senha forte
O programa solicita que o usuário digite uma senha e verifica se ela atende a quatro critérios:
- Mínimo de 8 caracteres
- Pelo menos uma letra maiúscula
- Pelo menos um número
- Pelo menos um caractere especial

Ao final, informa se a senha é forte ou quais requisitos não foram atendidos.

---

### Questão 2: Tabuada de um número
O programa solicita um número ao usuário e exibe a tabuada completa de 1 a 10.

---

### Questão 3: Cálculo de fatorial
O programa solicita um número inteiro positivo e calcula o fatorial usando um loop `while`.
- Verifica se o número é válido.
- Calcula o fatorial.
- Exibe o resultado.

---

### Questão 4: Conversor de temperaturas
Menu com 3 opções:
1. Celsius para Fahrenheit  
2. Fahrenheit para Celsius  
3. Encerrar o programa

O usuário escolhe a opção, insere a temperatura, e o programa exibe o resultado usando `switch`.

---

### Questão 5: Verificação de palíndromo
O programa lê uma palavra ou frase e verifica se é um palíndromo.
- Remove espaços, acentos, pontuação e diferenciação de maiúsculas/minúsculas.
- Compara a string original e invertida.
- Exibe o resultado.

---

### Questão 6: Cadastro de produtos
O programa permite cadastrar 3 produtos com nome, preço e quantidade.
- Calcula o valor total em estoque (preço × quantidade).
- Exibe uma lista com os dados e valores formatados.

---

### Questão 7: Soma de números pares
O usuário digita 10 números inteiros.
- O programa armazena em um array.
- Soma apenas os números pares.
- Exibe o resultado.

---

### Questão 8: Cálculo de IMC
O usuário informa altura e peso.
- Calcula o IMC.
- Classifica em: abaixo do peso, peso normal, sobrepeso ou obesidade.

---

### Questão 9: Jogo de adivinhação
O computador gera um número aleatório entre 1 e 100.
- O usuário tenta adivinhar.
- O programa dá dicas: maior ou menor.
- Conta e exibe o número de tentativas.

---

### Questão 10: Lista de tarefas
Menu interativo para gerenciar tarefas:
- Adicionar novas tarefas
- Visualizar tarefas
- Marcar tarefas como concluídas

As tarefas concluídas aparecem destacadas. O programa roda até o usuário sair.

## Descrição detalhada do exercício 7 e 8:

--- 

### Questão 7: Soma de números pares de um array

#### Objetivo:
Desenvolver um programa que:
- Solicite ao usuário 10 números inteiros.
- Armazene-os em um array.
- Calcule a soma apenas dos números pares.
- Exiba o resultado no console.

#### Explicação:

Neste exercício, estamos utilizando uma estrutura chamada "array" (pode ser visto como uma caixa ou recipiente onde podemos armazenar vários valores). O programa vai pedir para o usuário digitar 10 números inteiros e vai guardar esses números nessa caixa (o array). Em seguida, ele vai olhar dentro dessa caixa e somar somente os números que são pares (aqueles divisíveis por 2).

Explicação Simplificada:

O programa pede para o usuário digitar 10 números.

Esses números são armazenados dentro de uma "caixa" (o array).

O programa então verifica, um a um, se os números dentro da caixa são pares (divisíveis por 2).

Somando os números pares, o programa exibe o resultado final.

Conceitos:

- Array: Uma caixa que armazena vários valores (neste caso, 10 números).

- Loop: O programa passa por todos os números, um a um, para verificar quais são pares.

- Condicional: Ele verifica se o número é par, ou seja, se pode ser dividido por 2 sem sobrar nada.

#### Componentes do Código:
- **Importação de Bibliotecas:**  
  `using System;` e `using System.Globalization;` 
  
- **Classe Principal:**  
  `class Exerc7`

- **Método Main:**  
  Ponto de entrada do programa.

- **Leitura da Entrada:**  
  Usa `Console.WriteLine` e `Console.ReadLine()` para coletar números.

- **Cálculo e Exibição:**  
  Utiliza loop `for` para percorrer o array, identifica números pares e soma.

#### Conceitos de Programação:
- Entrada e saída de dados.
- Conversão de tipos (`int.Parse`).
- Estrutura de repetição (`for`).
- Condicional para números pares.

### Questão 8: Cálculo do IMC

#### Objetivo:
Desenvolver um programa que:
- Solicite altura (m) e peso (kg) do usuário.
- Calcule o IMC com a fórmula: `IMC = peso / (altura * altura)`.
- Classifique o resultado conforme as faixas:
  - Abaixo do peso
  - Peso normal
  - Sobrepeso
  - Obesidade

#### Explicação: 

Este exercício trabalha com a fórmula do IMC, que é usada para avaliar se uma pessoa está no peso adequado para sua altura. O programa solicita ao usuário que forneça sua altura (em metros) e seu peso (em quilogramas). Com essas informações, ele calcula o IMC e depois classifica o resultado nas categorias de baixo peso, peso normal, sobrepeso e obesidade.

Explicação Simplificada:

- O programa pede para o usuário digitar sua altura e peso.

- O IMC é calculado usando a fórmula: IMC = peso / (altura * altura).

- O programa então verifica o resultado do IMC e classifica a pessoa de acordo com a tabela:

- Abaixo do peso: IMC menor que 18,5.

- Peso normal: IMC entre 18,5 e 24,9.

- Sobrepeso: IMC entre 25 e 29,9.

- Obesidade: IMC acima de 30.

- O programa exibe a categoria do IMC no console.

#### Conceitos:

- Entrada de dados: O programa solicita e recebe a altura e o peso do usuário.

- Operações matemáticas: A fórmula do IMC é utilizada para calcular o índice.

Estruturas condicionais: O programa usa "if" e "else if" para classificar o IMC em diferentes faixas.
#### Componentes do Código:
- **Importação de Bibliotecas:**  
  `using System;`

- **Classe Principal:**  
  `class Exerc8`

- **Método Main:**  
  Ponto de entrada do programa.

- **Leitura de Altura e Peso:**  
  Usa `Console.WriteLine` e `Console.ReadLine()` com `float.Parse`.

- **Cálculo do IMC:**  
  Realiza a operação aritmética.

- **Classificação:**  
  Usa `if / else if` para categorizar o IMC.

#### Conceitos de Programação:
- Entrada e saída de dados.
- Conversão de tipos (`float.Parse`).
- Operadores aritméticos.
- Estruturas condicionais.