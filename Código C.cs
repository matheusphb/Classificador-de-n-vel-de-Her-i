#include <stdio.h>

int main() {
    // Declarando variáveis
    char nome[50];
    int xp;

    // Solicitando o nome e a quantidade de XP do herói
    printf("Digite o nome do herói: ");
    scanf("%49s", nome);

    printf("Digite a quantidade de XP do herói: ");
    if (scanf("%d", &xp) != 1) {
        printf("Erro: Entrada inválida. Certifique-se de digitar um número inteiro para o XP.\n");
        return 1;
    }

    // Classificando o nível do herói com base no XP
    const char* nivel;

    if (xp < 1000) {
        nivel = "Ferro";
    } else if (xp <= 2000) {
        nivel = "Bronze";
    } else if (xp <= 5000) {
        nivel = "Prata";
    } else if (xp <= 7000) {
        nivel = "Ouro";
    } else if (xp <= 8000) {
        nivel = "Platina";
    } else if (xp <= 9000) {
        nivel = "Ascendente";
    } else if (xp <= 10000) {
        nivel = "Imortal";
    } else {
        nivel = "Radiante";
    }

    // Exibindo o resultado
    printf("O Herói de nome %s está no nível de %s.\n", nome, nivel);

    return 0;
}
