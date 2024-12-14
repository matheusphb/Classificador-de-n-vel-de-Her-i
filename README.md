# Classificador de Nível de Herói

## Descrição
Este programa é uma aplicação em linguagem C que classifica o nível de um herói com base em sua quantidade de experiência (XP). O usuário fornece o nome do herói e sua XP, e o programa determina o nível correspondente de acordo com a seguinte classificação:

- **Ferro**: XP menor que 1.000
- **Bronze**: XP entre 1.001 e 2.000
- **Prata**: XP entre 2.001 e 5.000
- **Ouro**: XP entre 5.001 e 7.000
- **Platina**: XP entre 7.001 e 8.000
- **Ascendente**: XP entre 8.001 e 9.000
- **Imortal**: XP entre 9.001 e 10.000
- **Radiante**: XP maior ou igual a 10.001

## Requisitos
- Compilador C (como GCC ou Clang).
- Sistema operacional compatível com programas em C.

## Como usar

1. Clone ou baixe este repositório.
2. Compile o programa usando o comando:
   ```sh
   gcc -o classificador_heroi classificador_heroi.c
   ```
3. Execute o programa:
   ```sh
   ./classificador_heroi
   ```
4. Forneça o nome do herói e a quantidade de XP conforme solicitado pelo programa.
5. Veja o resultado exibido na tela, indicando o nível do herói.

## Exemplo de Saída

```sh
Digite o nome do herói: Arthus
Digite a quantidade de XP do herói: 4500
O Herói de nome Arthus está no nível de Prata.
```

## Tratamento de Erros
- Caso o usuário digite um valor inválido para a XP (não seja um número inteiro), o programa exibirá uma mensagem de erro e será encerrado:

```sh
Digite o nome do herói: Arthus
Digite a quantidade de XP do herói: abc
Erro: Entrada inválida. Certifique-se de digitar um número inteiro para o XP.
```

## Estrutura do Código

- O programa utiliza as seguintes estruturas de programação:
  - **Variáveis** para armazenar o nome e o XP do herói.
  - **scanf** para leitura de dados do usuário.
  - **if-else** para determinar o nível do herói com base no XP.
  - **printf** para exibir mensagens ao usuário.

