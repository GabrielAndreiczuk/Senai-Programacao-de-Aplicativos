#include<stdio.h>
#include<stdlib.h>

float nota1,nota2,nota3,nota4,media;

int main(){
    printf("CALCULO DE MEDIA\n\n");
    printf("INFORME A PRIMEIRA NOTA: ");
    scanf("%f",&nota1);
    printf("INFORME A SEGUNDA NOTA: ");
    scanf("%f",&nota2);
    printf("INFORME A TERCEIRA NOTA: ");
    scanf("%f",&nota3);
    printf("INFORME A QUARTA NOTA: ");
    scanf("%f",&nota4);
    media = (nota1+nota2+nota3+nota4)/4;
    printf("MEDIA: %.1f",media);
    if(media>=7){
        printf("\nO ALUNO ESTA APROVADO!");
    }else{
        printf("\nO ALUNO ESTA REPROVADO!");
    }

    printf("\n");
    system("pause");
    return 0;
}
